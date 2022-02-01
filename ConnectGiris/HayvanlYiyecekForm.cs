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
    public partial class HayvanlYiyecekForm : Form
    {
        private readonly SqlConnection con;
        private readonly int yiyecekId;

        public HayvanlYiyecekForm(SqlConnection con, int yiyecekId)
        {
            InitializeComponent();
            this.con = con;
            this.con = con;
            this.yiyecekId = yiyecekId;
            LoadData();

        }

        private void LoadData()
        {
            SqlCommand cmd = new SqlCommand("sp_YiyecegiSevenler", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", yiyecekId);
            SqlDataReader dr = cmd.ExecuteReader();
            bool yazdiMi = false;
            while (dr.Read())
            {
                if (!yazdiMi)
                {
                    lblYiyecek.Text = dr[9] + " " + dr[12];

                }
                dgvHayvanlar.Rows.Add(dr[2], dr[3], dr[4], dr[5], dr[6], dr[7]);

            }
            dr.Close();
        }

        private void HayvanlYiyecekForm_Load(object sender, EventArgs e)
        {

        }
    }
}
