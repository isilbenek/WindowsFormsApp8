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
    public partial class CalisanGüncelle : Form
    {
        public CalisanGüncelle()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = ISILBENEK\\SQLEXPRESS; initial catalog= bankamatik2; integrated security =sspi ");
        private void CalisanGüncelle_Load(object sender, EventArgs e)
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
                txtCTel.Text = dr["calisanTelefon"].ToString();
                txtCBolum.Text = dr["calisanBolum"].ToString();
                txtCSifre.Text = dr["calisanSifre"].ToString();
            }
            else
            {
                MessageBox.Show(txtCID.Text + "Numaralı Kayıt Bulunamadı", "Kayıt Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCID.Text = "";
                txtCBolum.Text = "";
                txtCAdSoyad.Text = "";
                txtCTel.Text = "";
                txtCSifre.Text = "";

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update calisanlar set calisanAdSoyad=@p1, adres=@p2,telefon=@p3 where ID=@p4 OR tcNo=@p5", con);
            komut.Parameters.AddWithValue("@p4", txtAra.Text);
            komut.Parameters.AddWithValue("@p5", txtAra.Text);
            komut.Parameters.AddWithValue("@p1", txtCAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtCTel.Text);

            con.Open();
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc == 1)
            {
                MessageBox.Show("Güncelleme Yapıldı", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                MessageBox.Show("Güncelleme Yapılamadı", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCID.Text = "";
                txtTcNo.Text = "";
                txtCAdSoyad.Text = "";
                txtCAdres.Text = "";
                txtCTel.Text = "";
                txtBakiye.Text = "";
            }
            con.Close();
        }
    }
}
        

