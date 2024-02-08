
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
            coords = new System.Windows.Forms.Label();
            image = new System.Windows.Forms.ImageList(components);
            SuspendLayout();
            // 
            // reset
            // 
            reset.Location = new System.Drawing.Point(36, 46);
            reset.Name = "reset";
            reset.Size = new System.Drawing.Size(75, 23);
            reset.TabIndex = 1;
            reset.Text = "reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // panel1
            // 
            panel1.Location = new System.Drawing.Point(36, 146);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(200, 200);
            panel1.TabIndex = 2;
            panel1.MouseClick += panel1_MouseClick;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // coords
            // 
            coords.AutoSize = true;
            coords.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            coords.Location = new System.Drawing.Point(426, 136);
            coords.Name = "coords";
            coords.Size = new System.Drawing.Size(65, 28);
            coords.TabIndex = 0;
            coords.Text = "label1";
            // 
            // image
            // 
            image.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            image.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("image.ImageStream");
            image.TransparentColor = System.Drawing.Color.Transparent;
            image.Images.SetKeyName(0, "bomba.png");
            // 
            // Poziom1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(coords);
            Controls.Add(panel1);
            Controls.Add(reset);
            Name = "Poziom1";
            Text = "Łatwy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label coords;
        private System.Windows.Forms.ImageList image;
    }
}