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
    public partial class UpdateForm : Form
    {
        private readonly Hayvan hayvan;
        private readonly SqlConnection con;

        public UpdateForm(Hayvan hayvan, SqlConnection con)
        {
            InitializeComponent();
            this.hayvan = hayvan;
            this.con = con;
            txtAd.Text = hayvan.Ad;
            txtTur.Text = hayvan.Tur;
            nudKutle.Value = hayvan.Kutle;
            dtpDogumTarihi.Value = hayvan.DogumTarihi;
            if (hayvan.Cinsiyet == "F")
            {
                cmbCinsiyet.SelectedIndex = 1;
            }
            else if (hayvan.Cinsiyet == "M")
            {
                cmbCinsiyet.SelectedIndex = 2;
            }
            else
            {
                cmbCinsiyet.SelectedIndex = 0;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update hayvanlar set Ad = @p1,cinsiyet =@p2,dogumtarihi = @p3, Kutle = @p4, Tur = @p5 where Id = @p6", con);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p3", dtpDogumTarihi.Value);
            cmd.Parameters.AddWithValue("@p4", nudKutle.Value);
            cmd.Parameters.AddWithValue("@p5", txtTur.Text);
            cmd.Parameters.AddWithValue("@p6", hayvan.Id);
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
            if (cinsiyet != null)
            {
                cmd.Parameters.AddWithValue("@p2", cinsiyet);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p2", DBNull.Value);
            }
            cmd.ExecuteNonQuery();
            this.Close();


        }
    }
}
