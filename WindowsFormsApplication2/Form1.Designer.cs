namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlog = new System.Windows.Forms.Button();
            this.btncon = new System.Windows.Forms.Button();
            this.btnab = new System.Windows.Forms.Button();
            this.btnproj = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelhome = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pUseProj1 = new WindowsFormsApplication2.PUseProj();
            this.pUseLog1 = new WindowsFormsApplication2.PUseLog();
            this.pUseAb1 = new WindowsFormsApplication2.PUseAb();
            this.pUseCon2 = new WindowsFormsApplication2.PUseCon();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelhome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnlog);
            this.panel1.Controls.Add(this.btncon);
            this.panel1.Controls.Add(this.btnab);
            this.panel1.Controls.Add(this.btnproj);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Location = new System.Drawing.Point(-8, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 300);
            this.panel1.TabIndex = 0;
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.Color.SteelBlue;
            this.btnlog.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.Color.Linen;
            this.btnlog.Location = new System.Drawing.Point(14, 258);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(100, 30);
            this.btnlog.TabIndex = 2;
            this.btnlog.Text = "Login";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.button5_Click);
            // 
            // btncon
            // 
            this.btncon.BackColor = System.Drawing.Color.SteelBlue;
            this.btncon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncon.Location = new System.Drawing.Point(11, 201);
            this.btncon.Name = "btncon";
            this.btncon.Size = new System.Drawing.Size(103, 35);
            this.btncon.TabIndex = 5;
            this.btncon.Text = "Contact us";
            this.btncon.UseVisualStyleBackColor = false;
            this.btncon.Click += new System.EventHandler(this.btncon_Click);
            // 
            // btnab
            // 
            this.btnab.BackColor = System.Drawing.Color.SteelBlue;
            this.btnab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnab.Location = new System.Drawing.Point(11, 146);
            this.btnab.Name = "btnab";
            this.btnab.Size = new System.Drawing.Size(103, 35);
            this.btnab.TabIndex = 4;
            this.btnab.Text = "About us";
            this.btnab.UseVisualStyleBackColor = false;
            this.btnab.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnproj
            // 
            this.btnproj.BackColor = System.Drawing.Color.SteelBlue;
            this.btnproj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproj.Location = new System.Drawing.Point(11, 88);
            this.btnproj.Name = "btnproj";
            this.btnproj.Size = new System.Drawing.Size(103, 35);
            this.btnproj.TabIndex = 3;
            this.btnproj.Text = "Projects";
            this.btnproj.UseVisualStyleBackColor = false;
            this.btnproj.Click += new System.EventHandler(this.btnproj_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.SteelBlue;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(11, 27);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(103, 35);
            this.btnhome.TabIndex = 2;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 56);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "R.R Group Pvt Ltd.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelhome
            // 
            this.panelhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelhome.BackgroundImage")));
            this.panelhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelhome.Controls.Add(this.label3);
            this.panelhome.Controls.Add(this.label2);
            this.panelhome.Location = new System.Drawing.Point(134, 56);
            this.panelhome.Name = "panelhome";
            this.panelhome.Size = new System.Drawing.Size(489, 297);
            this.panelhome.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-2, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 144);
            this.label3.TabIndex = 1;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome";
            // 
            // pUseProj1
            // 
            this.pUseProj1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pUseProj1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pUseProj1.BackgroundImage")));
            this.pUseProj1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pUseProj1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pUseProj1.Location = new System.Drawing.Point(134, 56);
            this.pUseProj1.Name = "pUseProj1";
            this.pUseProj1.Size = new System.Drawing.Size(489, 297);
            this.pUseProj1.TabIndex = 8;
            // 
            // pUseLog1
            // 
            this.pUseLog1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pUseLog1.BackgroundImage")));
            this.pUseLog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pUseLog1.Location = new System.Drawing.Point(134, 56);
            this.pUseLog1.Name = "pUseLog1";
            this.pUseLog1.Size = new System.Drawing.Size(489, 294);
            this.pUseLog1.TabIndex = 5;
            // 
            // pUseAb1
            // 
            this.pUseAb1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pUseAb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pUseAb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pUseAb1.Location = new System.Drawing.Point(134, 56);
            this.pUseAb1.Name = "pUseAb1";
            this.pUseAb1.Size = new System.Drawing.Size(489, 297);
            this.pUseAb1.TabIndex = 3;
            // 
            // pUseCon2
            // 
            this.pUseCon2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pUseCon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pUseCon2.Location = new System.Drawing.Point(134, 56);
            this.pUseCon2.Name = "pUseCon2";
            this.pUseCon2.Size = new System.Drawing.Size(489, 297);
            this.pUseCon2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelhome);
            this.Controls.Add(this.pUseProj1);
            this.Controls.Add(this.pUseLog1);
            this.Controls.Add(this.pUseAb1);
            this.Controls.Add(this.pUseCon2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RR Group Ltd.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelhome.ResumeLayout(false);
            this.panelhome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncon;
        private System.Windows.Forms.Button btnab;
        private System.Windows.Forms.Button btnproj;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnlog;
        private PUseAb pUseAb1;
        private PUseLog pUseLog1;
         private PUseCon pUseCon2;
        private PUseProj pUseProj1;
        private System.Windows.Forms.Panel panelhome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

