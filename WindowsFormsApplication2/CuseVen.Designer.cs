namespace WindowsFormsApplication2
{
    partial class CuseVen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuseVen));
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porjectDataSet = new WindowsFormsApplication2.porjectDataSet();
            this.vendorTableAdapter = new WindowsFormsApplication2.porjectDataSetTableAdapters.VendorTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnsrch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.venuseSrch1 = new WindowsFormsApplication2.VenuseSrch();
            this.venuseUp1 = new WindowsFormsApplication2.VenuseUp();
            this.venuseIn1 = new WindowsFormsApplication2.VenuseIn();
            this.venuseDel1 = new WindowsFormsApplication2.VenuseDel();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.porjectDataSet;
            // 
            // porjectDataSet
            // 
            this.porjectDataSet.DataSetName = "porjectDataSet";
            this.porjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendor Information";
            // 
            // btnIns
            // 
            this.btnIns.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.Location = new System.Drawing.Point(186, 54);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(75, 31);
            this.btnIns.TabIndex = 2;
            this.btnIns.Text = "Insert";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(349, 55);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 31);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(500, 56);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 31);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnsrch
            // 
            this.btnsrch.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrch.Location = new System.Drawing.Point(21, 56);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(84, 31);
            this.btnsrch.TabIndex = 5;
            this.btnsrch.Text = "Search";
            this.btnsrch.UseVisualStyleBackColor = true;
            this.btnsrch.Click += new System.EventHandler(this.btnsrch_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 294);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 315);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // venuseSrch1
            // 
            this.venuseSrch1.BackColor = System.Drawing.Color.BurlyWood;
            this.venuseSrch1.Location = new System.Drawing.Point(0, 93);
            this.venuseSrch1.Name = "venuseSrch1";
            this.venuseSrch1.Size = new System.Drawing.Size(640, 265);
            this.venuseSrch1.TabIndex = 9;
            // 
            // venuseUp1
            // 
            this.venuseUp1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.venuseUp1.Location = new System.Drawing.Point(0, 93);
            this.venuseUp1.Name = "venuseUp1";
            this.venuseUp1.Size = new System.Drawing.Size(640, 237);
            this.venuseUp1.TabIndex = 8;
            // 
            // venuseIn1
            // 
            this.venuseIn1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.venuseIn1.Location = new System.Drawing.Point(3, 92);
            this.venuseIn1.Name = "venuseIn1";
            this.venuseIn1.Size = new System.Drawing.Size(637, 238);
            this.venuseIn1.TabIndex = 7;
            // 
            // venuseDel1
            // 
            this.venuseDel1.BackColor = System.Drawing.Color.DarkOrange;
            this.venuseDel1.Location = new System.Drawing.Point(0, 93);
            this.venuseDel1.Name = "venuseDel1";
            this.venuseDel1.Size = new System.Drawing.Size(647, 237);
            this.venuseDel1.TabIndex = 6;
            // 
            // CuseVen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsrch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.venuseSrch1);
            this.Controls.Add(this.venuseUp1);
            this.Controls.Add(this.venuseIn1);
            this.Controls.Add(this.venuseDel1);
            this.Name = "CuseVen";
            this.Size = new System.Drawing.Size(640, 380);
            this.Load += new System.EventHandler(this.CuseVen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private porjectDataSet porjectDataSet;
        private porjectDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnsrch;
        private VenuseDel venuseDel1;
        private VenuseIn venuseIn1;
        private VenuseUp venuseUp1;
        private VenuseSrch venuseSrch1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
