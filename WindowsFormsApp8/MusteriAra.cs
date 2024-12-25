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
    public partial class MusteriAra : Form
    {
        public MusteriAra()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = ISILBENEK\\SQLEXPRESS; initial catalog= bankamatik2; integrated security =sspi ");

        private void txtbaslik_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from musteriler where ID=@p1 OR tcNo=@p2 ", con);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);
            komut.Parameters.AddWithValue("@p2", txtAra.Text);
            
            con.Open();
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                txtID.Text = dr["ID"].ToString();
                txtTcNo.Text = dr["tcNo"].ToString();
                txtAdSoyad.Text = dr["adSoyad"].ToString();
                txtAdres.Text = dr["adres"].ToString();
                txtTel.Text = dr["telefon"].ToString();
                txtBakiye.Text = dr["bakiye"].ToString();
            }
            else
            {
                MessageBox.Show(txtID.Text + "Numaralı Kayıt Bulunamadı", "Kayıt Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Text = "";
                txtTcNo.Text = "";
                txtAdSoyad.Text = "";
                txtAdres.Text = "";
                txtTel.Text = "";
                txtBakiye.Text = "";
 }
            con.Close();
    }

        private void MusteriAra_Load(object sender, EventArgs e)
        {

        }
    }
    }

