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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginpage lp = new loginpage();
            lp.Show();
            this.Hide();

        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            reportspage rp = new reportspage();
            rp.Show();
            this.Hide();

        }

        private void kurBtn_Click(object sender, EventArgs e)
        {
            kurpage kp = new kurpage();
            kp.Show();
            this.Hide();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            settingspage sp = new settingspage();
            sp.Show();
            this.Hide();
        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
