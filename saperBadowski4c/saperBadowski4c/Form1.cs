using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saperBadowski4c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void easy_Click(object sender, EventArgs e)
        {
            Poziom1 lvEasy = new Poziom1();
            lvEasy.Show();
        }

        private void mid_Click(object sender, EventArgs e)
        {
            Poziom2 lvMedium = new Poziom2();
            lvMedium.Show();
        }

        private void hard_Click(object sender, EventArgs e)
        {
            Poziom3 lvHard = new Poziom3();
            lvHard.Show();
        }
    }
}
