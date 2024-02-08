using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saperBadowski4c
{
    public partial class Poziom1 : Form
    {
        PictureBox[] pola = new PictureBox[64]; // https://www.spriters-resource.com/pc_computer/minesweeper/sheet/19849/ - sprites
        private void inicjalizujPola()
        {
            int count = 0;
            int x = 0;
            int y = 0;
            int index = 0;
            Random rand = new Random();
            for (int i = 0; i < 64; i++)
            {
                pola[i] = new PictureBox();
                pola[i].Width = 25;
                pola[i].Height = 25;
                pola[i].Left = x;
                pola[i].Top = y;
                pola[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pola[i].BackColor = Color.Gray;
                pola[i].BorderStyle = BorderStyle.FixedSingle;
                pola[i].Click += new EventHandler(poleKlik);
                pola[i].Tag = "ok";
                panel1.Controls.Add(pola[i]);
                x += 25;
                count++;
                if (count == 8)
                {
                    x = 0;
                    count = 0;
                    y += 25;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                index = rand.Next(0, 65);
                if ((string)pola[index].Tag == "bomba")
                {
                    i--;
                }
                else
                {
                    //pola[index].Image = image.Images[0];
                    pola[index].Tag = "bomba";
                }

            }
        }
        public Poziom1()
        {
            InitializeComponent();
            inicjalizujPola();
        }
        private void poleKlik(object sender, EventArgs e)
        {
            PictureBox pole = (PictureBox)sender;
            coords.Text = pole.Tag.ToString();
            if ((string)pole.Tag == "bomba")
            {
                for(int i = 0; i < 64; i++)
                {
                    if ((string)pola[i].Tag == "bomba")
                    {
                        pola[i].Image = image.Images[0];
                    }
                }
            }
            coords.Text = pole.Left + " " + pole.Top;
            for(int i = 0; i < 64; i++)
            {
                if (pola[i].Left == pole.Left) 
                {
                    if (pola[i].Top == pole.Top)
                    {
                        pola[i].BackColor = Color.Red; // to samo pole (do cyferek bedzie fajne)
                        break;
                    }
                }
                if (pola[i].Left == pole.Left)
                {
                    if (pola[i].Top + 25 == pole.Top)
                    {
                        pola[i].BackColor = Color.Red;
                        break;
                    }
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e) { }

        private void panel1_MouseDown(object sender, MouseEventArgs e) { }
    }
}
