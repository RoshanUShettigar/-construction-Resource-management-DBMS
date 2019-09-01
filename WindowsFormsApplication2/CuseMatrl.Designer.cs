namespace WindowsFormsApplication2
{
    partial class CuseMatrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuseMatrl));
            this.label1 = new System.Windows.Forms.Label();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porjectDataSet7 = new WindowsFormsApplication2.porjectDataSet7();
            this.materialsTableAdapter = new WindowsFormsApplication2.porjectDataSet7TableAdapters.MaterialsTableAdapter();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnsrch = new System.Windows.Forms.Button();
            this.matuseIn1 = new WindowsFormsApplication2.MatuseIn();
            this.matuseSrch1 = new WindowsFormsApplication2.MatuseSrch();
            this.matuseDel1 = new WindowsFormsApplication2.MatuseDel();
            this.matuseUp1 = new WindowsFormsApplication2.MatuseUp();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet7)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materials Status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.porjectDataSet7;
            // 
            // porjectDataSet7
            // 
            this.porjectDataSet7.DataSetName = "porjectDataSet7";
            this.porjectDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(485, 53);
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
            this.btnUp.Location = new System.Drawing.Point(337, 51);
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
            this.btnIns.Location = new System.Drawing.Point(177, 51);
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
            this.btnsrch.Location = new System.Drawing.Point(21, 51);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(84, 31);
            this.btnsrch.TabIndex = 11;
            this.btnsrch.Text = "Search";
            this.btnsrch.UseVisualStyleBackColor = true;
            this.btnsrch.Click += new System.EventHandler(this.btnsrch_Click);
            // 
            // matuseIn1
            // 
            this.matuseIn1.BackColor = System.Drawing.Color.Khaki;
            this.matuseIn1.Location = new System.Drawing.Point(0, 88);
            this.matuseIn1.Name = "matuseIn1";
            this.matuseIn1.Size = new System.Drawing.Size(633, 245);
            this.matuseIn1.TabIndex = 15;
            this.matuseIn1.Load += new System.EventHandler(this.matuseIn1_Load);
            // 
            // matuseSrch1
            // 
            this.matuseSrch1.BackColor = System.Drawing.Color.Coral;
            this.matuseSrch1.Location = new System.Drawing.Point(3, 88);
            this.matuseSrch1.Name = "matuseSrch1";
            this.matuseSrch1.Size = new System.Drawing.Size(630, 245);
            this.matuseSrch1.TabIndex = 13;
            // 
            // matuseDel1
            // 
            this.matuseDel1.BackColor = System.Drawing.Color.MediumPurple;
            this.matuseDel1.Location = new System.Drawing.Point(3, 90);
            this.matuseDel1.Name = "matuseDel1";
            this.matuseDel1.Size = new System.Drawing.Size(630, 243);
            this.matuseDel1.TabIndex = 12;
            // 
            // matuseUp1
            // 
            this.matuseUp1.BackColor = System.Drawing.Color.LightCyan;
            this.matuseUp1.Location = new System.Drawing.Point(3, 88);
            this.matuseUp1.Name = "matuseUp1";
            this.matuseUp1.Size = new System.Drawing.Size(630, 245);
            this.matuseUp1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 256);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 259);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CuseMatrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsrch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matuseIn1);
            this.Controls.Add(this.matuseSrch1);
            this.Controls.Add(this.matuseDel1);
            this.Controls.Add(this.matuseUp1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CuseMatrl";
            this.Size = new System.Drawing.Size(636, 347);
            this.Load += new System.EventHandler(this.CuseMatrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet7)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private porjectDataSet7 porjectDataSet7;
        private porjectDataSet7TableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnsrch;
        private MatuseDel matuseDel1;
        private MatuseSrch matuseSrch1;
        private MatuseUp matuseUp1;
        private MatuseIn matuseIn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
