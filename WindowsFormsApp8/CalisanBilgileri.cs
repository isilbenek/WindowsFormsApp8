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
    public partial class CalisanBilgileri : Form
    {
        public CalisanBilgileri()
        {
            InitializeComponent();
        }

        
        private void btnCEkle_Click(object sender, EventArgs e)
        {
            CalisanEkle ce = new CalisanEkle();
            ce.Show();
        }

        private void btnCAra_Click(object sender, EventArgs e)
        {
            CalisanAra ca = new CalisanAra();
            ca.Show();
        }

        private void btnCGuncelle_Click(object sender, EventArgs e)
        {
            CalisanGüncelle cg = new CalisanGüncelle();
            cg.Show();
        }
    }
}
