
namespace saperBadowski4c
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            easy = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            mid = new System.Windows.Forms.Button();
            hard = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // easy
            // 
            easy.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            easy.Location = new System.Drawing.Point(310, 163);
            easy.Name = "easy";
            easy.Size = new System.Drawing.Size(116, 38);
            easy.TabIndex = 0;
            easy.Text = "Łatwy";
            easy.UseVisualStyleBackColor = true;
            easy.Click += easy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(202, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(333, 74);
            label1.TabIndex = 1;
            label1.Text = "Witaj w grze Saper! \r\nWybierz poziom trudności:";
            // 
            // mid
            // 
            mid.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            mid.Location = new System.Drawing.Point(310, 230);
            mid.Name = "mid";
            mid.Size = new System.Drawing.Size(116, 38);
            mid.TabIndex = 2;
            mid.Text = "Średni";
            mid.UseVisualStyleBackColor = true;
            mid.Click += mid_Click;
            // 
            // hard
            // 
            hard.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            hard.Location = new System.Drawing.Point(310, 303);
            hard.Name = "hard";
            hard.Size = new System.Drawing.Size(116, 38);
            hard.TabIndex = 3;
            hard.Text = "Trudny";
            hard.UseVisualStyleBackColor = true;
            hard.Click += hard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(hard);
            Controls.Add(mid);
            Controls.Add(label1);
            Controls.Add(easy);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mid;
        private System.Windows.Forms.Button hard;
    }
}

