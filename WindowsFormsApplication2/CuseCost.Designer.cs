namespace WindowsFormsApplication2
{
    partial class CuseCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuseCost));
            this.label1 = new System.Windows.Forms.Label();
            this.costBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porjectDataSet3 = new WindowsFormsApplication2.porjectDataSet3();
            this.porjectDataSet = new WindowsFormsApplication2.porjectDataSet();
            this.porjectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costTableAdapter = new WindowsFormsApplication2.porjectDataSet3TableAdapters.CostTableAdapter();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnsrch = new System.Windows.Forms.Button();
            this.btnSrch2 = new System.Windows.Forms.Button();
            this.btnDel2 = new System.Windows.Forms.Button();
            this.btnUp2 = new System.Windows.Forms.Button();
            this.btnIn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.costuseSrch2 = new WindowsFormsApplication2.CostuseSrch();
            this.costuseUp2 = new WindowsFormsApplication2.CostuseUp();
            this.costuseIn2 = new WindowsFormsApplication2.CostuseIn();
            this.costuseDel2 = new WindowsFormsApplication2.CostuseDel();
            ((System.ComponentModel.ISupportInitialize)(this.costBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cost Analysis";
            // 
            // costBindingSource
            // 
            this.costBindingSource.DataMember = "Cost";
            this.costBindingSource.DataSource = this.porjectDataSet3;
            // 
            // porjectDataSet3
            // 
            this.porjectDataSet3.DataSetName = "porjectDataSet3";
            this.porjectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // porjectDataSet
            // 
            this.porjectDataSet.DataSetName = "porjectDataSet";
            this.porjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // porjectDataSetBindingSource
            // 
            this.porjectDataSetBindingSource.DataSource = this.porjectDataSet;
            this.porjectDataSetBindingSource.Position = 0;
            // 
            // costTableAdapter
            // 
            this.costTableAdapter.ClearBeforeFill = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(448, 49);
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
            this.btnUp.Location = new System.Drawing.Point(321, 49);
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
            this.btnIns.Location = new System.Drawing.Point(183, 48);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(75, 31);
            this.btnIns.TabIndex = 8;
            this.btnIns.Text = "Insert";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnsrch
            // 
            this.btnsrch.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrch.Location = new System.Drawing.Point(38, 48);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(84, 31);
            this.btnsrch.TabIndex = 11;
            this.btnsrch.Text = "Search";
            this.btnsrch.UseVisualStyleBackColor = true;
            this.btnsrch.Click += new System.EventHandler(this.btnsrch_Click);
            // 
            // btnSrch2
            // 
            this.btnSrch2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrch2.Location = new System.Drawing.Point(20, 51);
            this.btnSrch2.Name = "btnSrch2";
            this.btnSrch2.Size = new System.Drawing.Size(84, 31);
            this.btnSrch2.TabIndex = 16;
            this.btnSrch2.Text = "Search";
            this.btnSrch2.UseVisualStyleBackColor = true;
            this.btnSrch2.Click += new System.EventHandler(this.btnSrch2_Click);
            // 
            // btnDel2
            // 
            this.btnDel2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel2.Location = new System.Drawing.Point(484, 53);
            this.btnDel2.Name = "btnDel2";
            this.btnDel2.Size = new System.Drawing.Size(75, 31);
            this.btnDel2.TabIndex = 15;
            this.btnDel2.Text = "Delete";
            this.btnDel2.UseVisualStyleBackColor = true;
            this.btnDel2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUp2
            // 
            this.btnUp2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp2.Location = new System.Drawing.Point(336, 51);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(75, 31);
            this.btnUp2.TabIndex = 14;
            this.btnUp2.Text = "Update";
            this.btnUp2.UseVisualStyleBackColor = true;
            this.btnUp2.Click += new System.EventHandler(this.btnUp2_Click);
            // 
            // btnIn2
            // 
            this.btnIn2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn2.Location = new System.Drawing.Point(176, 51);
            this.btnIn2.Name = "btnIn2";
            this.btnIn2.Size = new System.Drawing.Size(75, 31);
            this.btnIn2.TabIndex = 13;
            this.btnIn2.Text = "Insert";
            this.btnIn2.UseVisualStyleBackColor = true;
            this.btnIn2.Click += new System.EventHandler(this.btnIn2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cost Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 254);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 241);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // costuseSrch2
            // 
            this.costuseSrch2.BackColor = System.Drawing.Color.RosyBrown;
            this.costuseSrch2.Location = new System.Drawing.Point(0, 90);
            this.costuseSrch2.Name = "costuseSrch2";
            this.costuseSrch2.Size = new System.Drawing.Size(638, 252);
            this.costuseSrch2.TabIndex = 20;
            // 
            // costuseUp2
            // 
            this.costuseUp2.BackColor = System.Drawing.Color.Teal;
            this.costuseUp2.Location = new System.Drawing.Point(3, 89);
            this.costuseUp2.Name = "costuseUp2";
            this.costuseUp2.Size = new System.Drawing.Size(635, 233);
            this.costuseUp2.TabIndex = 19;
            // 
            // costuseIn2
            // 
            this.costuseIn2.BackColor = System.Drawing.Color.PapayaWhip;
            this.costuseIn2.Location = new System.Drawing.Point(3, 88);
            this.costuseIn2.Name = "costuseIn2";
            this.costuseIn2.Size = new System.Drawing.Size(635, 254);
            this.costuseIn2.TabIndex = 18;
            // 
            // costuseDel2
            // 
            this.costuseDel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.costuseDel2.Location = new System.Drawing.Point(0, 88);
            this.costuseDel2.Name = "costuseDel2";
            this.costuseDel2.Size = new System.Drawing.Size(641, 254);
            this.costuseDel2.TabIndex = 17;
            // 
            // CuseCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.costuseDel2);
            this.Controls.Add(this.btnSrch2);
            this.Controls.Add(this.btnDel2);
            this.Controls.Add(this.btnUp2);
            this.Controls.Add(this.btnIn2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costuseSrch2);
            this.Controls.Add(this.costuseUp2);
            this.Controls.Add(this.costuseIn2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CuseCost";
            this.Size = new System.Drawing.Size(636, 332);
            this.Load += new System.EventHandler(this.CuseCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource costBindingSource;
        private porjectDataSet3 porjectDataSet3;
        private porjectDataSet porjectDataSet;
        private System.Windows.Forms.BindingSource porjectDataSetBindingSource;
        private porjectDataSet3TableAdapters.CostTableAdapter costTableAdapter;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnsrch;
        private CostuseDel costuseDel1;
        private CostuseSrch costuseSrch1;
        private CostuseIn costuseIn1;
        private CostuseUp costuseUp1;
        private System.Windows.Forms.Button btnSrch2;
        private System.Windows.Forms.Button btnDel2;
        private System.Windows.Forms.Button btnUp2;
        private System.Windows.Forms.Button btnIn2;
        private System.Windows.Forms.Label label2;
        private CostuseDel costuseDel2;
        private CostuseIn costuseIn2;
        private CostuseUp costuseUp2;
        private CostuseSrch costuseSrch2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
