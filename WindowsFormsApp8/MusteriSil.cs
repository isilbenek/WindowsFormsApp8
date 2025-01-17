﻿using System;
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
    public partial class MusteriSil : Form
    {
        public MusteriSil()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = ISILBENEK\\SQLEXPRESS; initial catalog= bankamatik2; integrated security =sspi ");
        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("delete musteriler where ID=@p1 or tcNo=@p2", con);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);
            komut.Parameters.AddWithValue("@p2", txtAra.Text);




            DialogResult dr = MessageBox.Show("Müşteri Kaydını Silmek İstediğinize Emin Misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.No)
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Silme İşlemi");
            }
            else
            {
                con.Open();
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc == 1)
                {
                    MessageBox.Show("Silme İşlemi Yapıldı", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                else
                {
                     MessageBox.Show("Silme İşlemi Yapılamadı", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
                txtID.Text = "";
                txtTcNo.Text = "";
                txtAdSoyad.Text = "";
                txtAdres.Text = "";
                txtTel.Text = "";
                txtBakiye.Text = "";
            }
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

        private void MusteriSil_Load(object sender, EventArgs e)
        {

        }
    }
}
