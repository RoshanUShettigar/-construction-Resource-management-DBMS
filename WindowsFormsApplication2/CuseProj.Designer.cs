namespace WindowsFormsApplication2
{
    partial class CuseProj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuseProj));
            this.label1 = new System.Windows.Forms.Label();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porjectDataSet4 = new WindowsFormsApplication2.porjectDataSet4();
            this.projectTableAdapter = new WindowsFormsApplication2.porjectDataSet4TableAdapters.ProjectTableAdapter();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnsrch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pjuseSrch1 = new WindowsFormsApplication2.PjuseSrch();
            this.pjuseDel1 = new WindowsFormsApplication2.PjuseDel();
            this.pjuseIn1 = new WindowsFormsApplication2.PjuseIn();
            this.pjuseUp1 = new WindowsFormsApplication2.PjuseUp();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project specification";
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.porjectDataSet4;
            // 
            // porjectDataSet4
            // 
            this.porjectDataSet4.DataSetName = "porjectDataSet4";
            this.porjectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(470, 42);
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
            this.btnUp.Location = new System.Drawing.Point(334, 42);
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
            this.btnIns.Location = new System.Drawing.Point(203, 42);
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
            this.btnsrch.Location = new System.Drawing.Point(52, 42);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(84, 31);
            this.btnsrch.TabIndex = 11;
            this.btnsrch.Text = "Search";
            this.btnsrch.UseVisualStyleBackColor = true;
            this.btnsrch.Click += new System.EventHandler(this.btnsrch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 262);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 262);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pjuseSrch1
            // 
            this.pjuseSrch1.BackColor = System.Drawing.Color.SandyBrown;
            this.pjuseSrch1.Location = new System.Drawing.Point(-13, 80);
            this.pjuseSrch1.Name = "pjuseSrch1";
            this.pjuseSrch1.Size = new System.Drawing.Size(644, 261);
            this.pjuseSrch1.TabIndex = 13;
            // 
            // pjuseDel1
            // 
            this.pjuseDel1.BackColor = System.Drawing.Color.Orchid;
            this.pjuseDel1.Location = new System.Drawing.Point(0, 79);
            this.pjuseDel1.Name = "pjuseDel1";
            this.pjuseDel1.Size = new System.Drawing.Size(647, 262);
            this.pjuseDel1.TabIndex = 12;
            // 
            // pjuseIn1
            // 
            this.pjuseIn1.BackColor = System.Drawing.Color.PaleGreen;
            this.pjuseIn1.Location = new System.Drawing.Point(0, 79);
            this.pjuseIn1.Name = "pjuseIn1";
            this.pjuseIn1.Size = new System.Drawing.Size(665, 262);
            this.pjuseIn1.TabIndex = 15;
            // 
            // pjuseUp1
            // 
            this.pjuseUp1.BackColor = System.Drawing.Color.MediumPurple;
            this.pjuseUp1.Location = new System.Drawing.Point(0, 79);
            this.pjuseUp1.Name = "pjuseUp1";
            this.pjuseUp1.Size = new System.Drawing.Size(665, 262);
            this.pjuseUp1.TabIndex = 14;
            // 
            // CuseProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsrch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pjuseSrch1);
            this.Controls.Add(this.pjuseDel1);
            this.Controls.Add(this.pjuseIn1);
            this.Controls.Add(this.pjuseUp1);
            this.Name = "CuseProj";
            this.Size = new System.Drawing.Size(636, 390);
            this.Load += new System.EventHandler(this.CuseProj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjectDataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private porjectDataSet4 porjectDataSet4;
        private porjectDataSet4TableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnsrch;
        private PjuseDel pjuseDel1;
        private PjuseSrch pjuseSrch1;
        private PjuseUp pjuseUp1;
        private PjuseIn pjuseIn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
