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
    public partial class kurpage : Form
    {
        public kurpage()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Anasayfa hp = new Anasayfa();
            hp.Show();
            this.Close();
        }

        private void kurpage_Load(object sender, EventArgs e)
        {

        }
    }
}
