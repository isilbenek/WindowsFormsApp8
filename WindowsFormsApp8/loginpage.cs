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
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = ISILBENEK\\SQLEXPRESS; initial catalog= bankamatik2; integrated security =sspi ");
        public static string adSoyad = "";
        public static int mID;

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Anasayfa hp = new Anasayfa();
            hp.Show();
            this.Close();

        }

        private void loginpage_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kAdi = textBox1.Text;
            string parola = textBox2.Text;
            bool sonuc = false;
            // MessageBox.Show(radioButton1.Checked.ToString()); kontrol amaçlı




            if (radioButton1.Checked)
            {
                if (kAdi == "admin" && parola == "123")

                {
                    Yetkiliislem yi = new Yetkiliislem();
                    yi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya parola !");
                }

            }
            else
            {
                con.Open();
                SqlCommand komut = new SqlCommand("select *from musteriler where tcNo=@p1 and sifre =@p2", con);
                komut.Parameters.AddWithValue("@p1", kAdi);
                komut.Parameters.AddWithValue("@p2", parola);
                SqlDataReader dr = komut.ExecuteReader();


                while (dr.Read())
                {
                    adSoyad = dr["adSoyad"].ToString();
                    mID = int.Parse(dr["ID"].ToString());
                    sonuc = true;
                }

                con.Close();
                if (sonuc)
                {
                    sonuc = false;
                    Musteriislem mi = new Musteriislem();
                    mi.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya parola !");


                }


            }
            textBox1.Text = "";
            textBox2.Text = "";

        }
    }
}
