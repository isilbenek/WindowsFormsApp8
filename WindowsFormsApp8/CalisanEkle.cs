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
    public partial class CalisanEkle : Form
    {
        public CalisanEkle()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = ISILBENEK\\SQLEXPRESS; initial catalog= bankamatik2; integrated security =sspi ");
        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into calisanlar(calisanID,calisanAdSoyad,calisanBolum,calisanTelefon,calisanSifre) values (@p1,@p2,@p3,@p4,@p5) ", con);
            komut.Parameters.AddWithValue("@p1", txtCID.Text);
            komut.Parameters.AddWithValue("@p2", txtCAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtCBolum.Text);
            komut.Parameters.AddWithValue("@p4", txtCTel.Text);
            komut.Parameters.AddWithValue("@p5", txtCSifre.Text);

            if (txtCID.Text == "" || txtCAdSoyad.Text == "" || txtCTel.Text == "" || txtCBolum.Text == ""  || txtCSifre.Text == "")
            {
                MessageBox.Show("Tüm Alanları Eksiksiz Giriniz", "Müşteri Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                int sonuc = komut.ExecuteNonQuery();
                con.Close();
                if (sonuc == 1)
                    MessageBox.Show("Yeni Müşteri Kaydedildi", "Müşteri Kaydı");
                else
                    MessageBox.Show("Yeni Müşteri Kaydedilemedi", "Müşteri Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




            txtCID.Text = "";
            txtCAdSoyad.Text = "";
            txtCBolum.Text = "";
            txtCTel.Text = "";
            txtCSifre.Text = "";

        }


    }
    }

