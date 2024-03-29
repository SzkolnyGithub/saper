﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace saperBadowski4c
{
    public partial class Poziom1 : Form
    {
        private static System.Timers.Timer timer;
        int time = 0;
        int flag = 10;
        bool agan = false;
        private void wygrales()
        {
            reset.BackgroundImage = image.Images[15];
            timer.Stop();
        }
        private void SetTimer()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += tick;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void tick(object sender, ElapsedEventArgs e)
        {
            Thread thread = new Thread(
                delegate ()
                {
                    czasElapsed();
                }
                );
            thread.Start();
        }
        private void czasElapsed()
        {
            if (time < 10)
            {
                if (this.czas.InvokeRequired)
                {
                    this.czas.Invoke((MethodInvoker)delegate ()
                    {
                        czas.Text = "00" + time;
                        time++;
                    });
                }
                return;
            }
            if (time < 100)
            {
                if (this.czas.InvokeRequired)
                {
                    this.czas.Invoke((MethodInvoker)delegate ()
                    {
                        czas.Text = "0" + time;
                        time++;
                    });
                }
                return;
            }
            if (time < 1000)
            {
                if (this.czas.InvokeRequired)
                {
                    this.czas.Invoke((MethodInvoker)delegate ()
                    {
                        czas.Text = time.ToString();
                        time++;
                    });
                }
                return;
            }
            if (time == 1000)
            {
                if (this.czas.InvokeRequired)
                {
                    this.czas.Invoke((MethodInvoker)delegate ()
                    {
                        gameOver();
                    });
                }
                return;
            }
        }
        PictureBox[] pola = new PictureBox[64];
        bool flagmode = false;
        int[] directions = { -9, -8, -7, -1, 1, 7, 8, 9 };
        int bombyTotal = 10;
        bool start = false;
        private void gameOver()
        {
            for (int i = 0; i < 64; i++)
            {
                pola[i].Enabled = false;
                if ((string)pola[i].Tag == "bomba")
                {
                    pola[i].Image = image.Images[0];
                }
                if ((string)pola[i].Tag == "flaga")
                {
                    pola[i].Image = image.Images[13];
                }
            }
            timer.Stop();
            reset.BackgroundImage = image.Images[14];
        }
        private int bombyCheck(int index)
        {
            int count = 0;

            foreach (int dir in directions)
            {
                if (index % 8 == 7 && (dir == 1 || dir == 9 || dir == -7))
                {
                    continue;
                }
                if (index % 8 == 0 && (dir == -1 || dir == -9 || dir == 7))
                {
                    continue;
                }
                if (index + dir >= 64 || index + dir < 0)
                {
                    continue;
                }
                if ((string)pola[index + dir].Tag == "bomba" || (string)pola[index + dir].Tag == "flagaBomba")
                {
                    count++;
                }
            }
            return count;
        }
        private void sprawdzPola(int currentIndex)
        {
            int counter = 0;
            PictureBox pole = pola[currentIndex];
            if ((string)pole.Tag == "ok" && flagmode)
            {
                if (flag == 0)
                {
                    return;
                }
                pole.Tag = "flaga";
                pole.Image = image.Images[9];
                flag--;
                FlagiC.Text = "00" + flag;
                return;
            }
            if ((string)pole.Tag == "bomba" && flagmode)
            {
                if (flag == 0)
                {
                    return;
                }
                pole.Tag = "flagaBomba";
                pole.Image = image.Images[9];
                flag--;
                FlagiC.Text = "00" + flag;
                for (int i = 0; i < 64; i++)
                {
                    if ((string)pola[i].Tag == "flagaBomba")
                    {
                        counter++;
                    }
                }
                if (counter == bombyTotal)
                {
                    wygrales();
                }
                return;
            }
            if ((string)pole.Tag == "flaga" && flagmode)
            {
                pole.Tag = "ok";
                pole.Image = image.Images[11];
                flag++;
                if (flag < 10)
                {
                    FlagiC.Text = "00" + flag;
                }
                else
                {
                    FlagiC.Text = "0" + flag;
                }
                return;
            }
            if ((string)pole.Tag == "flagaBomba" && flagmode)
            {
                pole.Tag = "bomba";
                pole.Image = image.Images[11];
                flag++;
                if (flag < 10)
                {
                    FlagiC.Text = "00" + flag;
                }
                else
                {
                    FlagiC.Text = "0" + flag;
                }
                return;
            }
            if ((string)pole.Tag == "flaga" && !flagmode || (string)pole.Tag == "flagaBomba" && !flagmode)
            {
                return;
            }
            if ((string)pole.Tag == "bomba")
            {
                gameOver();
                return;
            }
            if ((string)pole.Tag == "git")
            {
                return;
            }
            pole.Tag = "git";
            int bomby = bombyCheck(currentIndex);
            if (bomby == 0)
            {
                pole.Image = image.Images[12];
                foreach (int dir in directions)
                {
                    if (currentIndex % 8 == 7 && (dir == 1 || dir == 9 || dir == -7))
                    {
                        continue;
                    }
                    if (currentIndex % 8 == 0 && (dir == -1 || dir == -9 || dir == 7))
                    {
                        continue;
                    }
                    int nextIndex = currentIndex + dir;
                    if (nextIndex >= 0 && nextIndex < 64 && (string)pola[nextIndex].Tag == "ok")
                    {
                        sprawdzPola(nextIndex);
                    }
                }

            }
            else
            {
                pole.Image = image.Images[bomby];
            }
        }
        private void inicjalizujPola()
        {
            reset.BackgroundImage = image.Images[10];
            int count = 0;
            int x = 0;
            int y = 0;
            int index = 0;
            Random rand = new Random();
            for (int i = 0; i < 64; i++) // tworzenie i dodawanie pol
            {
                pola[i] = new PictureBox();
                pola[i].Width = 25;
                pola[i].Height = 25;
                pola[i].Left = x;
                pola[i].Top = y;
                pola[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pola[i].BorderStyle = BorderStyle.FixedSingle;
                pola[i].Click += new EventHandler(poleKlik);
                pola[i].Tag = "ok";
                pola[i].Image = image.Images[11];
                pola[i].Enabled = true;
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
            for (int i = 0; i < 10; i++) // losowanie bomb
            {
                index = rand.Next(0, 64);
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
            if (!start)
            {
                SetTimer();
            }
            if (agan)
            {
                timer.Start();
                agan = false;
            }
            start = true;
            PictureBox pole = (PictureBox)sender;
            for (int i = 0; i < 64; i++)
            {
                if (pola[i].Left == pole.Left)
                {
                    if (pola[i].Top == pole.Top)
                    {
                        sprawdzPola(i);
                    }
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            agan = true;
            time = 0;
            flag = 10;
            czas.Text = "000";
            FlagiC.Text = "010";
            for (int i = 0; i < 64; i++)
            {
                pola[i].Tag = "ok";
                pola[i].Image = image.Images[11];
                pola[i].Enabled = true;
            }
            int index = 0;
            Random rand = new Random();
            for (int i = 0; i < 10; i++) // losowanie bomb
            {
                index = rand.Next(0, 64);
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
            reset.BackgroundImage = image.Images[10];
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e) { }

        private void panel1_MouseDown(object sender, MouseEventArgs e) { }

        private void flagMode_CheckedChanged(object sender, EventArgs e)
        {
            if (flagMode.Checked)
            {
                flagmode = true;
            }
            if (!flagMode.Checked)
            {
                flagmode = false;
            }
        }
    }
}
