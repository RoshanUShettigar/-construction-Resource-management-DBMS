namespace WindowsFormsApplication2
{
    partial class CRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnven = new System.Windows.Forms.Button();
            this.btnMat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnprj = new System.Windows.Forms.Button();
            this.btnsiterq = new System.Windows.Forms.Button();
            this.btnsite = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cuseMatrl1 = new WindowsFormsApplication2.CuseMatrl();
            this.cuseCost1 = new WindowsFormsApplication2.CuseCost();
            this.cuseVen1 = new WindowsFormsApplication2.CuseVen();
            this.cuseSiterq1 = new WindowsFormsApplication2.CuseSiterq();
            this.cuseProj1 = new WindowsFormsApplication2.CuseProj();
            this.cuseSite1 = new WindowsFormsApplication2.CuseSite();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.btnven);
            this.panel1.Controls.Add(this.btnMat);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnprj);
            this.panel1.Controls.Add(this.btnsiterq);
            this.panel1.Controls.Add(this.btnsite);
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnven
            // 
            this.btnven.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnven.Location = new System.Drawing.Point(641, 7);
            this.btnven.Name = "btnven";
            this.btnven.Size = new System.Drawing.Size(75, 29);
            this.btnven.TabIndex = 7;
            this.btnven.Text = "Vendor";
            this.btnven.UseVisualStyleBackColor = true;
            this.btnven.Click += new System.EventHandler(this.btnven_Click_1);
            // 
            // btnMat
            // 
            this.btnMat.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMat.Location = new System.Drawing.Point(328, 7);
            this.btnMat.Name = "btnMat";
            this.btnMat.Size = new System.Drawing.Size(94, 29);
            this.btnMat.TabIndex = 6;
            this.btnMat.Text = "Materials";
            this.btnMat.UseVisualStyleBackColor = true;
            this.btnMat.Click += new System.EventHandler(this.btnMat_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(544, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "Cost";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnprj
            // 
            this.btnprj.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprj.Location = new System.Drawing.Point(449, 7);
            this.btnprj.Name = "btnprj";
            this.btnprj.Size = new System.Drawing.Size(75, 29);
            this.btnprj.TabIndex = 4;
            this.btnprj.Text = "Project";
            this.btnprj.UseVisualStyleBackColor = true;
            this.btnprj.Click += new System.EventHandler(this.btnprj_Click);
            // 
            // btnsiterq
            // 
            this.btnsiterq.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiterq.Location = new System.Drawing.Point(223, 7);
            this.btnsiterq.Name = "btnsiterq";
            this.btnsiterq.Size = new System.Drawing.Size(81, 29);
            this.btnsiterq.TabIndex = 3;
            this.btnsiterq.Text = "SiteReq";
            this.btnsiterq.UseVisualStyleBackColor = true;
            this.btnsiterq.Click += new System.EventHandler(this.btnsiterq_Click);
            // 
            // btnsite
            // 
            this.btnsite.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsite.Location = new System.Drawing.Point(121, 7);
            this.btnsite.Name = "btnsite";
            this.btnsite.Size = new System.Drawing.Size(75, 29);
            this.btnsite.TabIndex = 2;
            this.btnsite.Text = "Site";
            this.btnsite.UseVisualStyleBackColor = true;
            this.btnsite.Click += new System.EventHandler(this.btnsite_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 62);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Construction Resource Management";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.cuseMatrl1);
            this.panel3.Controls.Add(this.cuseCost1);
            this.panel3.Controls.Add(this.cuseVen1);
            this.panel3.Controls.Add(this.cuseSiterq1);
            this.panel3.Controls.Add(this.cuseProj1);
            this.panel3.Controls.Add(this.cuseSite1);
            this.panel3.Location = new System.Drawing.Point(0, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 332);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(57, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 332);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(307, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome";
            // 
            // cuseMatrl1
            // 
            this.cuseMatrl1.BackColor = System.Drawing.Color.SandyBrown;
            this.cuseMatrl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuseMatrl1.Location = new System.Drawing.Point(57, 0);
            this.cuseMatrl1.Name = "cuseMatrl1";
            this.cuseMatrl1.Size = new System.Drawing.Size(636, 329);
            this.cuseMatrl1.TabIndex = 2;
            // 
            // cuseCost1
            // 
            this.cuseCost1.BackColor = System.Drawing.Color.LightBlue;
            this.cuseCost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuseCost1.Location = new System.Drawing.Point(57, 0);
            this.cuseCost1.Name = "cuseCost1";
            this.cuseCost1.Size = new System.Drawing.Size(636, 329);
            this.cuseCost1.TabIndex = 1;
            this.cuseCost1.Load += new System.EventHandler(this.cuseCost1_Load);
            // 
            // cuseVen1
            // 
            this.cuseVen1.BackColor = System.Drawing.Color.Chocolate;
            this.cuseVen1.Location = new System.Drawing.Point(57, 0);
            this.cuseVen1.Name = "cuseVen1";
            this.cuseVen1.Size = new System.Drawing.Size(636, 380);
            this.cuseVen1.TabIndex = 0;
            // 
            // cuseSiterq1
            // 
            this.cuseSiterq1.BackColor = System.Drawing.Color.PeachPuff;
            this.cuseSiterq1.Location = new System.Drawing.Point(57, -3);
            this.cuseSiterq1.Name = "cuseSiterq1";
            this.cuseSiterq1.Size = new System.Drawing.Size(636, 332);
            this.cuseSiterq1.TabIndex = 5;
            // 
            // cuseProj1
            // 
            this.cuseProj1.BackColor = System.Drawing.Color.Tomato;
            this.cuseProj1.Location = new System.Drawing.Point(57, -3);
            this.cuseProj1.Name = "cuseProj1";
            this.cuseProj1.Size = new System.Drawing.Size(636, 332);
            this.cuseProj1.TabIndex = 3;
            // 
            // cuseSite1
            // 
            this.cuseSite1.BackColor = System.Drawing.Color.DarkOrange;
            this.cuseSite1.Location = new System.Drawing.Point(57, 0);
            this.cuseSite1.Name = "cuseSite1";
            this.cuseSite1.Size = new System.Drawing.Size(636, 345);
            this.cuseSite1.TabIndex = 8;
            // 
            // CRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 442);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(20, 39);
            this.Name = "CRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConstructionResourceManagement";
            this.Load += new System.EventHandler(this.CRM_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnprj;
        private System.Windows.Forms.Button btnsiterq;
        private System.Windows.Forms.Button btnsite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private CuseSiterq cuseSiterq1;
        private CuseProj cuseProj1;
        private CuseMatrl cuseMatrl1;
        private CuseCost cuseCost1;
        private CuseVen cuseVen1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMat;
        private System.Windows.Forms.Button btnven;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CuseSite cuseSite1;
        private System.Windows.Forms.Label label2;
    }
}