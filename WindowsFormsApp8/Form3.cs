using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Yetkiliislem : Form
    {
        public Yetkiliislem()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Anasayfa hp = new Anasayfa();
            hp.Show();
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            loginpage form = new loginpage();
            form.Show();
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MüşteriEkle me = new MüşteriEkle();
            me.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            MusteriAra ma = new MusteriAra();
            ma.Show();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelle mg = new MusteriGuncelle();
            mg.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MusteriSil ms = new MusteriSil();
            ms.Show();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            MusteriListele ml = new MusteriListele();
            ml.Show();
        }

        private void Yetkiliislem_Load(object sender, EventArgs e)
        {

        }

        private void btnCalisan_Click_1(object sender, EventArgs e)
        {
            CalisanBilgileri cb = new CalisanBilgileri();
            cb.Show();
        }
    }
}
