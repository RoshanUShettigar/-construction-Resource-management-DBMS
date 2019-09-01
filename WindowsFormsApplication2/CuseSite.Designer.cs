namespace WindowsFormsApplication2
{
    partial class CuseSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuseSite));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitevendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pjidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteMgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porjectDataSet6 = new WindowsFormsApplication2.porjectDataSet6();
            this.siteTableAdapter = new WindowsFormsApplication2.porjectDataSet6TableAdapters.SiteTableAdapter();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsrchS = new System.Windows.Forms.Button();
            this.btninsS = new System.Windows.Forms.Button();
            this.btnupS = new System.Windows.Forms.Button();
            this.btndelS = new System.Windows.Forms.Button();
            this.siteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.porjectDataSet8 = new WindowsFormsApplication2.porjectDataSet8();
            this.siteTableAdapter1 = new WindowsFormsApplication2.porjectDataSet8TableAdapters.SiteTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siteuseDel2 = new WindowsFormsApplication2.SiteuseDel();
            this.siteuseIns2 = new WindowsFormsApplication2.SiteuseIns();
            this.siteuseUp2 = new WindowsFormsApplication2.SiteuseUp();
            this.siteuseSrch2 = new WindowsFormsApplication2.SiteuseSrch();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siteidDataGridViewTextBoxColumn,
            this.siteownerDataGridViewTextBoxColumn,
            this.sitevendDataGridViewTextBoxColumn,
            this.pjidDataGridViewTextBoxColumn,
            this.addrDataGridViewTextBoxColumn,
            this.siteMgDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 98);
            this.dataGridView1.TabIndex = 1;
            // 
            // siteidDataGridViewTextBoxColumn
            // 
            this.siteidDataGridViewTextBoxColumn.DataPropertyName = "Site_id";
            this.siteidDataGridViewTextBoxColumn.HeaderText = "Site_id";
            this.siteidDataGridViewTextBoxColumn.Name = "siteidDataGridViewTextBoxColumn";
            // 
            // siteownerDataGridViewTextBoxColumn
            // 
            this.siteownerDataGridViewTextBoxColumn.DataPropertyName = "Site_owner";
            this.siteownerDataGridViewTextBoxColumn.HeaderText = "Site_owner";
            this.siteownerDataGridViewTextBoxColumn.Name = "siteownerDataGridViewTextBoxColumn";
            // 
            // sitevendDataGridViewTextBoxColumn
            // 
            this.sitevendDataGridViewTextBoxColumn.DataPropertyName = "Site_vend";
            this.sitevendDataGridViewTextBoxColumn.HeaderText = "Site_vend";
            this.sitevendDataGridViewTextBoxColumn.Name = "sitevendDataGridViewTextBoxColumn";
            // 
            // pjidDataGridViewTextBoxColumn
            // 
            this.pjidDataGridViewTextBoxColumn.DataPropertyName = "pj_id";
            this.pjidDataGridViewTextBoxColumn.HeaderText = "pj_id";
            this.pjidDataGridViewTextBoxColumn.Name = "pjidDataGridViewTextBoxColumn";
            // 
            // addrDataGridViewTextBoxColumn
            // 
            this.addrDataGridViewTextBoxColumn.DataPropertyName = "Addr";
            this.addrDataGridViewTextBoxColumn.HeaderText = "Addr";
            this.addrDataGridViewTextBoxColumn.Name = "addrDataGridViewTextBoxColumn";
            // 
            // siteMgDataGridViewTextBoxColumn
            // 
            this.siteMgDataGridViewTextBoxColumn.DataPropertyName = "Site_Mg";
            this.siteMgDataGridViewTextBoxColumn.HeaderText = "Site_Mg";
            this.siteMgDataGridViewTextBoxColumn.Name = "siteMgDataGridViewTextBoxColumn";
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.porjectDataSet6;
            // 
            // porjectDataSet6
            // 
            this.porjectDataSet6.DataSetName = "porjectDataSet6";
            this.porjectDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(504, 55);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 31);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(332, 56);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 31);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnIns
            // 
            this.btnIns.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.Location = new System.Drawing.Point(181, 56);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(75, 31);
            this.btnIns.TabIndex = 8;
            this.btnIns.Text = "Insert";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(32, 55);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(78, 31);
            this.btnsearch.TabIndex = 11;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Site Details";
            // 
            // btnsrchS
            // 
            this.btnsrchS.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrchS.Location = new System.Drawing.Point(57, 69);
            this.btnsrchS.Name = "btnsrchS";
            this.btnsrchS.Size = new System.Drawing.Size(75, 33);
            this.btnsrchS.TabIndex = 1;
            this.btnsrchS.Text = "Search";
            this.btnsrchS.UseVisualStyleBackColor = true;
            this.btnsrchS.Click += new System.EventHandler(this.button1_Click);
            // 
            // btninsS
            // 
            this.btninsS.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsS.Location = new System.Drawing.Point(207, 69);
            this.btninsS.Name = "btninsS";
            this.btninsS.Size = new System.Drawing.Size(75, 33);
            this.btninsS.TabIndex = 2;
            this.btninsS.Text = "Insert";
            this.btninsS.UseVisualStyleBackColor = true;
            this.btninsS.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnupS
            // 
            this.btnupS.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupS.Location = new System.Drawing.Point(357, 69);
            this.btnupS.Name = "btnupS";
            this.btnupS.Size = new System.Drawing.Size(75, 33);
            this.btnupS.TabIndex = 3;
            this.btnupS.Text = "Update";
            this.btnupS.UseVisualStyleBackColor = true;
            this.btnupS.Click += new System.EventHandler(this.btnupS_Click);
            // 
            // btndelS
            // 
            this.btndelS.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelS.Location = new System.Drawing.Point(494, 69);
            this.btndelS.Name = "btndelS";
            this.btndelS.Size = new System.Drawing.Size(75, 33);
            this.btndelS.TabIndex = 4;
            this.btndelS.Text = "Delete";
            this.btndelS.UseVisualStyleBackColor = true;
            this.btndelS.Click += new System.EventHandler(this.btndelS_Click);
            // 
            // siteBindingSource1
            // 
            this.siteBindingSource1.DataMember = "Site";
            this.siteBindingSource1.DataSource = this.porjectDataSet8;
            // 
            // porjectDataSet8
            // 
            this.porjectDataSet8.DataSetName = "porjectDataSet8";
            this.porjectDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siteTableAdapter1
            // 
            this.siteTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 224);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 224);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // siteuseDel2
            // 
            this.siteuseDel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.siteuseDel2.Location = new System.Drawing.Point(-10, 124);
            this.siteuseDel2.Name = "siteuseDel2";
            this.siteuseDel2.Size = new System.Drawing.Size(654, 221);
            this.siteuseDel2.TabIndex = 6;
            // 
            // siteuseIns2
            // 
            this.siteuseIns2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.siteuseIns2.Location = new System.Drawing.Point(-1, 121);
            this.siteuseIns2.Name = "siteuseIns2";
            this.siteuseIns2.Size = new System.Drawing.Size(634, 212);
            this.siteuseIns2.TabIndex = 9;
            // 
            // siteuseUp2
            // 
            this.siteuseUp2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.siteuseUp2.Location = new System.Drawing.Point(0, 121);
            this.siteuseUp2.Name = "siteuseUp2";
            this.siteuseUp2.Size = new System.Drawing.Size(636, 212);
            this.siteuseUp2.TabIndex = 8;
            this.siteuseUp2.Load += new System.EventHandler(this.siteuseUp2_Load);
            // 
            // siteuseSrch2
            // 
            this.siteuseSrch2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.siteuseSrch2.Location = new System.Drawing.Point(-1, 121);
            this.siteuseSrch2.Name = "siteuseSrch2";
            this.siteuseSrch2.Size = new System.Drawing.Size(637, 212);
            this.siteuseSrch2.TabIndex = 7;
            // 
            // CuseSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btndelS);
            this.Controls.Add(this.btnupS);
            this.Controls.Add(this.btninsS);
            this.Controls.Add(this.btnsrchS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siteuseDel2);
            this.Controls.Add(this.siteuseIns2);
            this.Controls.Add(this.siteuseUp2);
            this.Controls.Add(this.siteuseSrch2);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.siteBindingSource1, "pj_id", true));
            this.Name = "CuseSite";
            this.Size = new System.Drawing.Size(636, 345);
            this.Load += new System.EventHandler(this.CuseSite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitevendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pjidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteMgDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private porjectDataSet6 porjectDataSet6;
        private porjectDataSet6TableAdapters.SiteTableAdapter siteTableAdapter;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnsearch;
        private SiteuseSrch siteuseSrch1;
        private SiteuseDel siteuseDel1;
        private SiteuseUp siteuseUp1;
        private SiteuseIns siteuseIns1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsrchS;
        private System.Windows.Forms.Button btninsS;
        private System.Windows.Forms.Button btnupS;
        private System.Windows.Forms.Button btndelS;
        private System.Windows.Forms.BindingSource siteBindingSource1;
        private porjectDataSet8 porjectDataSet8;
        private porjectDataSet8TableAdapters.SiteTableAdapter siteTableAdapter1;
        private SiteuseDel siteuseDel2;
        private SiteuseSrch siteuseSrch2;
        private SiteuseUp siteuseUp2;
        private SiteuseIns siteuseIns2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
