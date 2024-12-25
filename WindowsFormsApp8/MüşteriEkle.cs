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
    public partial class MüşteriEkle : Form
    {
        public MüşteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = ISILBENEK\\SQLEXPRESS; initial catalog= bankamatik2; integrated security =sspi ");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into musteriler(tcNo,adSoyad,adres,telefon,sifre,bakiye,durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7) ", con);
            komut.Parameters.AddWithValue("@p1", txtTcNo.Text);
            komut.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtAdres.Text);
            komut.Parameters.AddWithValue("@p4", txtTel.Text);
            komut.Parameters.AddWithValue("@p5", txtTcNo.Text);
            komut.Parameters.AddWithValue("@p6", txtBakiye.Text);
            komut.Parameters.AddWithValue("@p7", 1);

            if(txtTcNo.Text==""  || txtAdSoyad.Text=="" || txtAdres.Text == "" || txtTel.Text == "" || txtBakiye.Text=="")
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


            

            txtTcNo.Text = "";
            txtAdSoyad.Text = "";
            txtAdres.Text = "";
            txtTel.Text = "";
            txtBakiye.Text = "";
           
 }

        private void txtbaslik_Click(object sender, EventArgs e)
        {

        }
    }
}
