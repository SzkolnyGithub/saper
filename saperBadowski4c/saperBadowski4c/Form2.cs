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
    public partial class pLatwy : Form
    {private void pLatwy_Click(object sender, EventArgs e) { }

        int licznik = 0;
        List<string> pola = new List<string>();
        int[] bomby = new int[10];
        public pLatwy()
        {
            InitializeComponent();
            Random rand = new Random();
            for(int i = 0; i < 10; i++)
            {
                int temp = rand.Next(0, 64);
                if(!bomby.Contains(temp))
                {
                    bomby[i] = temp;
                    bombyInd.Text += temp + " ";
                } else
                {
                    i--;
                }
            } // https://www.geeksforgeeks.org/cpp-implementation-minesweeper-game/
            for (int i = 0; i < 64; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if(i == bomby[j])
                    {
                        pola.Add("bomba");
                    }
                }
            }
        }
        private void button8_Click(object sender, EventArgs e) 
        { 
            if(pola[0] == "bomba")
            {
                licznik++;
                poleTest.Text = licznik + "bomba";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // zrob reset nwm jak
        }

        private void pole1_2_Click(object sender, EventArgs e)
        {
            if (pola[1] == "bomba")
            {
                licznik++;
                poleTest.Text = licznik + "bomba";
            }
        }
        private void pole1_3_Click(object sender, EventArgs e)
        {
            if (pola[2] == "bomba")
            {
                licznik++;
                poleTest.Text = licznik + "bomba";
            }
        }
        private void pole1_4_Click(object sender, EventArgs e)
        {
            if (pola[3] == "bomba")
            {
                licznik++;
                poleTest.Text = licznik + "bomba";
            }
        }
        private void pole1_5_Click(object sender, EventArgs e)
        {
            if (pola[4] == "bomba")
            {
                licznik++;
                poleTest.Text = licznik + "bomba";
            }
        }
    }
}
