namespace Wizualne_Obraz
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Negatyw = new System.Windows.Forms.Button();
            this.Zielony = new System.Windows.Forms.Button();
            this.OBRÓT = new System.Windows.Forms.Button();
            this.ODBICIE_LUSTRZANE_I = new System.Windows.Forms.Button();
            this.ODBICIE_LUSTRZANE_II = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 306);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(216, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "WCZYTAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OBRÓT
            // 
            this.OBRÓT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OBRÓT.Location = new System.Drawing.Point(599, 181);
            this.OBRÓT.Name = "OBRÓT";
            this.OBRÓT.Size = new System.Drawing.Size(148, 68);
            this.OBRÓT.TabIndex = 2;
            this.OBRÓT.Text = "OBRÓT O 90";
            this.OBRÓT.UseVisualStyleBackColor = true;
            this.OBRÓT.Click += new System.EventHandler(this.move_by_90_degree_Click);
            // 
            // ODBICIE_LUSTRZANE_I
            // 
            this.ODBICIE_LUSTRZANE_I.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ODBICIE_LUSTRZANE_I.Location = new System.Drawing.Point(599, 266);
            this.ODBICIE_LUSTRZANE_I.Name = "ODBICIE_LUSTRZANE_I";
            this.ODBICIE_LUSTRZANE_I.Size = new System.Drawing.Size(148, 68);
            this.ODBICIE_LUSTRZANE_I.TabIndex = 3;
            this.ODBICIE_LUSTRZANE_I.Text = "ODBICIE LUSTRZANE II";
            this.ODBICIE_LUSTRZANE_I.UseVisualStyleBackColor = true;
            this.ODBICIE_LUSTRZANE_I.Click += new System.EventHandler(this.mirror_reflection_I_Click);
            // 
            // ODBICIE_LUSTRZANE_II
            // 
            this.ODBICIE_LUSTRZANE_II.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ODBICIE_LUSTRZANE_II.Location = new System.Drawing.Point(599, 350);
            this.ODBICIE_LUSTRZANE_II.Name = "ODBICIE_LUSTRZANE_II";
            this.ODBICIE_LUSTRZANE_II.Size = new System.Drawing.Size(148, 68);
            this.ODBICIE_LUSTRZANE_II.TabIndex = 4;
            this.ODBICIE_LUSTRZANE_II.Text = "ODBICIE LUSTRZANE II";
            this.ODBICIE_LUSTRZANE_II.UseVisualStyleBackColor = true;
            this.ODBICIE_LUSTRZANE_II.Click += new System.EventHandler(this.mirror_reflection_Click);
            // 
            // Negatyw
            // 
            this.Negatyw.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Negatyw.Location = new System.Drawing.Point(602, 114);
            this.Negatyw.Name = "Negatyw";
            this.Negatyw.Size = new System.Drawing.Size(148, 68);
            this.Negatyw.TabIndex = 2;
            this.Negatyw.Text = "NEGATYW";
            this.Negatyw.UseVisualStyleBackColor = true;
            this.Negatyw.Click += new System.EventHandler(this.Negative_Click);
            // 
            // Zielony
            // 
            this.Zielony.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Zielony.Location = new System.Drawing.Point(602, 28);
            this.Zielony.Name = "Zielony";
            this.Zielony.Size = new System.Drawing.Size(148, 68);
            this.Zielony.TabIndex = 3;
            this.Zielony.Text = "ZIELONY!!!";
            this.Zielony.UseVisualStyleBackColor = true;
            this.Zielony.Click += new System.EventHandler(this.All_green_pixels_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zielony);
            this.Controls.Add(this.Negatyw);
            this.Controls.Add(this.ODBICIE_LUSTRZANE_II);
            this.Controls.Add(this.ODBICIE_LUSTRZANE_I);
            this.Controls.Add(this.OBRÓT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button OBRÓT;
        private Button ODBICIE_LUSTRZANE_I;
        private Button ODBICIE_LUSTRZANE_II;
        private Button Negatyw;
        private Button Zielony;
    }
}