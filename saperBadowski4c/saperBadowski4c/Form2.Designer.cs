﻿
namespace saperBadowski4c
{
    partial class Poziom1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poziom1));
            reset = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            image = new System.Windows.Forms.ImageList(components);
            flagMode = new System.Windows.Forms.CheckBox();
            FlagiC = new System.Windows.Forms.Label();
            czas = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // reset
            // 
            reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            reset.ImageKey = "(none)";
            reset.Location = new System.Drawing.Point(103, 51);
            reset.Name = "reset";
            reset.Size = new System.Drawing.Size(60, 57);
            reset.TabIndex = 1;
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // panel1
            // 
            panel1.Location = new System.Drawing.Point(37, 115);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(200, 200);
            panel1.TabIndex = 2;
            panel1.MouseClick += panel1_MouseClick;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // image
            // 
            image.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            image.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("image.ImageStream");
            image.TransparentColor = System.Drawing.Color.Transparent;
            image.Images.SetKeyName(0, "bomba.png");
            image.Images.SetKeyName(1, "1.png");
            image.Images.SetKeyName(2, "2.png");
            image.Images.SetKeyName(3, "3.png");
            image.Images.SetKeyName(4, "4.png");
            image.Images.SetKeyName(5, "5.png");
            image.Images.SetKeyName(6, "6.png");
            image.Images.SetKeyName(7, "7.png");
            image.Images.SetKeyName(8, "8.png");
            image.Images.SetKeyName(9, "flaga.png");
            image.Images.SetKeyName(10, "reset.png");
            image.Images.SetKeyName(11, "tile.png");
            image.Images.SetKeyName(12, "tileClear.png");
            image.Images.SetKeyName(13, "bombWrong.png");
            image.Images.SetKeyName(14, "resetOver.png");
            image.Images.SetKeyName(15, "resetWin.png");
            // 
            // flagMode
            // 
            flagMode.AutoSize = true;
            flagMode.Location = new System.Drawing.Point(192, 18);
            flagMode.Name = "flagMode";
            flagMode.Size = new System.Drawing.Size(51, 19);
            flagMode.TabIndex = 3;
            flagMode.Text = "Flagi";
            flagMode.UseVisualStyleBackColor = true;
            flagMode.CheckedChanged += flagMode_CheckedChanged;
            // 
            // FlagiC
            // 
            FlagiC.AutoSize = true;
            FlagiC.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FlagiC.ForeColor = System.Drawing.Color.Red;
            FlagiC.Location = new System.Drawing.Point(37, 70);
            FlagiC.Name = "FlagiC";
            FlagiC.Size = new System.Drawing.Size(62, 37);
            FlagiC.TabIndex = 4;
            FlagiC.Text = "010";
            // 
            // czas
            // 
            czas.AutoSize = true;
            czas.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            czas.ForeColor = System.Drawing.Color.Red;
            czas.Location = new System.Drawing.Point(167, 70);
            czas.Name = "czas";
            czas.Size = new System.Drawing.Size(62, 37);
            czas.TabIndex = 5;
            czas.Text = "000";
            // 
            // Poziom1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(270, 349);
            Controls.Add(czas);
            Controls.Add(FlagiC);
            Controls.Add(flagMode);
            Controls.Add(panel1);
            Controls.Add(reset);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "Poziom1";
            Text = "Łatwy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList image;
        private System.Windows.Forms.CheckBox flagMode;
        private System.Windows.Forms.Label FlagiC;
        private System.Windows.Forms.Label czas;
    }
}