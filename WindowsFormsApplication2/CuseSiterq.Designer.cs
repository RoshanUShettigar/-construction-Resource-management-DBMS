namespace WindowsFormsApplication2
{
    partial class CuseSiterq
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuseSiterq));
            this.label1 = new System.Windows.Forms.Label();
            this.sitereqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porjectDataSet5 = new WindowsFormsApplication2.porjectDataSet5();
            this.site_reqTableAdapter = new WindowsFormsApplication2.porjectDataSet5TableAdapters.Site_reqTableAdapter();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSR = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siteRuseUp1 = new WindowsFormsApplication2.SiteRuseUp();
            this.siteRuseIn1 = new WindowsFormsApplication2.SiteRuseIn();
            this.siteRuseSrch1 = new WindowsFormsApplication2.SiteRuseSrch();
            this.siteRuseDel1 = new WindowsFormsApplication2.SiteRuseDel();
            ((System.ComponentModel.ISupportInitialize)(this.sitereqBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet5)).BeginInit();
            this.panelSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site Requirements";
            // 
            // sitereqBindingSource
            // 
            this.sitereqBindingSource.DataMember = "Site_req";
            this.sitereqBindingSource.DataSource = this.porjectDataSet5;
            // 
            // porjectDataSet5
            // 
            this.porjectDataSet5.DataSetName = "porjectDataSet5";
            this.porjectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // site_reqTableAdapter
            // 
            this.site_reqTableAdapter.ClearBeforeFill = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(498, 49);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 31);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(355, 49);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 31);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnIns
            // 
            this.btnIns.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.Location = new System.Drawing.Point(216, 49);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(75, 31);
            this.btnIns.TabIndex = 8;
            this.btnIns.Text = "Insert";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(64, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSR
            // 
            this.panelSR.Controls.Add(this.pictureBox1);
            this.panelSR.Location = new System.Drawing.Point(0, 89);
            this.panelSR.Name = "panelSR";
            this.panelSR.Size = new System.Drawing.Size(640, 237);
            this.panelSR.TabIndex = 16;
            this.panelSR.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 237);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // siteRuseUp1
            // 
            this.siteRuseUp1.BackColor = System.Drawing.Color.Bisque;
            this.siteRuseUp1.Location = new System.Drawing.Point(0, 91);
            this.siteRuseUp1.Name = "siteRuseUp1";
            this.siteRuseUp1.Size = new System.Drawing.Size(640, 235);
            this.siteRuseUp1.TabIndex = 14;
            // 
            // siteRuseIn1
            // 
            this.siteRuseIn1.BackColor = System.Drawing.Color.CadetBlue;
            this.siteRuseIn1.Location = new System.Drawing.Point(3, 91);
            this.siteRuseIn1.Name = "siteRuseIn1";
            this.siteRuseIn1.Size = new System.Drawing.Size(637, 232);
            this.siteRuseIn1.TabIndex = 15;
            // 
            // siteRuseSrch1
            // 
            this.siteRuseSrch1.BackColor = System.Drawing.Color.SandyBrown;
            this.siteRuseSrch1.Location = new System.Drawing.Point(3, 91);
            this.siteRuseSrch1.Name = "siteRuseSrch1";
            this.siteRuseSrch1.Size = new System.Drawing.Size(634, 232);
            this.siteRuseSrch1.TabIndex = 13;
            // 
            // siteRuseDel1
            // 
            this.siteRuseDel1.BackColor = System.Drawing.Color.YellowGreen;
            this.siteRuseDel1.Location = new System.Drawing.Point(0, 91);
            this.siteRuseDel1.Name = "siteRuseDel1";
            this.siteRuseDel1.Size = new System.Drawing.Size(637, 232);
            this.siteRuseDel1.TabIndex = 12;
            // 
            // CuseSiterq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siteRuseUp1);
            this.Controls.Add(this.siteRuseIn1);
            this.Controls.Add(this.siteRuseSrch1);
            this.Controls.Add(this.siteRuseDel1);
            this.Name = "CuseSiterq";
            this.Size = new System.Drawing.Size(640, 385);
            this.Load += new System.EventHandler(this.CuseSiterq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sitereqBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet5)).EndInit();
            this.panelSR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sitereqBindingSource;
        private porjectDataSet5 porjectDataSet5;
        private porjectDataSet5TableAdapters.Site_reqTableAdapter site_reqTableAdapter;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button button1;
        private SiteRuseDel siteRuseDel1;
        private SiteRuseSrch siteRuseSrch1;
        private SiteRuseUp siteRuseUp1;
        private SiteRuseIn siteRuseIn1;
        private System.Windows.Forms.Panel panelSR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
