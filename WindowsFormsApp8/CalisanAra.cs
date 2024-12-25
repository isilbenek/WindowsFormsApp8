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

namespace WindowsFormsApp8
{
    public partial class CalisanAra : Form
    {
        public CalisanAra()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = ISILBENEK\\SQLEXPRESS; initial catalog= bankamatik2; integrated security =sspi ");
        private void CalisanAra_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from calisanlar where calisanID=@p1", con);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);
            

            con.Open();
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                txtCID.Text = dr["calisanID"].ToString();
                txtCAdSoyad.Text = dr["calisanAdSoyad"].ToString();
                txtCBolum.Text = dr["calisanBolum"].ToString();
                txtCTel.Text = dr["calisanTelefon"].ToString();
               
            }
            else
            {
                MessageBox.Show(txtAra.Text + "Numaralı Kayıt Bulunamadı", "Kayıt Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCID.Text = "";
                txtCAdSoyad.Text = "";
                txtCBolum.Text = "";
                txtCTel.Text = "";
               
            }
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

