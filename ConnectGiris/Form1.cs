using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectGiris
{
    public partial class Form1 : Form
    {
        ///*SqlConnection con = new Sq*/lConnection("Server=DESKTOP-B0E6NUI;Database=AnkBoost6.1;User Id=sa;Password=1234;");
        ///
        SqlConnection con = new SqlConnection();

        public Form1()
        {
            con.ConnectionString = "Server=DESKTOP-B0E6NUI;Database=AnkBoost6.1;User Id=sa;Password=1234;";

            con.Open();
            InitializeComponent();
            cmbCinsiyet.SelectedIndex = 0;
            HayvanlariListele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HayvanSayisi();
            dgvHayvanlar.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvHayvanlar.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvHayvanlar.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private void HayvanSayisi()
        {
            //sorguyla yapınız.
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select count(*) from hayvanlar";
            cmd.Connection = con;
            int hayvanSayisi = (int)cmd.ExecuteScalar();
            lblHayvanSayisi.Text = "Hayvan Sayisi " + hayvanSayisi;
        }

        private void HayvanlariListele()
        {
            //dgv de database deki tum hayvanları gösteriniz
            //lblHayvanSayisini da guncelleyiniz
            dgvHayvanlar.Rows.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Id,Ad,Cinsiyet,DogumTarihi,Kutle,Tur,Yas,FavoriYiyecekId from Hayvanlar";
            cmd.Connection = con;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvHayvanlar.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6],dr[7],"SIL", "GUNCELLE");
            }
            dr.Close();
            //dataGridView1.DataSource = hayvan;          
            HayvanSayisi();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            //hayvanlar tablosuna insert işlemi yapınız.
            string cinsiyet = "";
            if (cmbCinsiyet.SelectedIndex == 1)
            {
                cinsiyet = "F";

            }
            else if (cmbCinsiyet.SelectedIndex == 2)
            {
                cinsiyet = "M";

            }
            else
            {
                cinsiyet = null;
            }
            SqlCommand cmd = new SqlCommand("insert into hayvanlar (Ad,Cinsiyet,DogumTarihi,Kutle,Tur) values (@p1,@p2,@p3,@p4,@p5)", con);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            if (cinsiyet != null)
            {
                cmd.Parameters.AddWithValue("@p2", cinsiyet);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p2", DBNull.Value);
            }

            cmd.Parameters.AddWithValue("@p3", dtpDogumTarihi.Value);
            cmd.Parameters.AddWithValue("@p4", nudKutle.Value);
            cmd.Parameters.AddWithValue("@p5", txtTur.Text);
            cmd.ExecuteNonQuery();
            HayvanlariListele();

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void dgvHayvanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewCell dgvcell = ((DataGridView)sender)[e.ColumnIndex, e.RowIndex];
            if (dgvcell is DataGridViewButtonCell && ((string)dgvcell.Value) == "SIL")
            {
                //MessageBox.Show("butonu sil");
                //delete işlemi
                //silmek istiyor musunuz evet derse silelim
                int silinecekId = (int)dgvHayvanlar.SelectedRows[0].Cells[0].Value;
                DialogResult dr = MessageBox.Show(silinecekId.ToString() + "id li hayvan silinecek onayıyor musunuz ", "silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand($"delete from hayvanlar where Id  = @p1", con);
                        cmd.Parameters.AddWithValue("@p1", silinecekId);
                        cmd.ExecuteNonQuery();
                        HayvanlariListele();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Silmek istediginiz hayvanın bakıcısı vardır silemezsiniz");
                    }
                }

            }
            else if (dgvcell is DataGridViewButtonCell && ((string)dgvcell.Value) == "GUNCELLE")
            {

                //update işlemi
                Hayvan hayvan = new Hayvan()
                {
                    Id = (int)(dgvHayvanlar.SelectedRows[0].Cells[0].Value),
                    Ad = (string)(dgvHayvanlar.SelectedRows[0].Cells[1].Value),
                    DogumTarihi = (DateTime)(dgvHayvanlar.SelectedRows[0].Cells[3].Value),
                    Kutle = (decimal)(dgvHayvanlar.SelectedRows[0].Cells[4].Value),
                    Tur = (string)(dgvHayvanlar.SelectedRows[0].Cells[5].Value)
                };
                object cinsiyet = dgvHayvanlar.SelectedRows[0].Cells[2].Value;
                if (cinsiyet is DBNull)
                {
                    cinsiyet = "null";
                }
                hayvan.Cinsiyet = (string)cinsiyet;
                UpdateForm updateform = new UpdateForm(hayvan, con);
                updateform.ShowDialog();
                HayvanlariListele();
            }
        }

        private void dgvHayvanlar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //seçili hayvanın idsini alarak yeni bir formda dgv de o yiyeceği seven hayvanları listeleyiniz
            //bu işlem yapılırken store procedure execute edilecek 
            //dgv üzerinde ise yiyeceğin adı ve kalıri bilgisi yazsın
            if (e.RowIndex<0)
            {
                return;
            }
            int yiyecekId =(int)dgvHayvanlar.SelectedRows[0].Cells[7].Value;
            HayvanlYiyecekForm hayvanYiyecekForm = new HayvanlYiyecekForm(con,yiyecekId);
            MessageBox.Show(yiyecekId.ToString());
            hayvanYiyecekForm.ShowDialog();



        }
    }
}
