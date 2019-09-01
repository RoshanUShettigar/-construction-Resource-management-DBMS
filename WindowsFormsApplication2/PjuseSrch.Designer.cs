namespace WindowsFormsApplication2
{
    partial class PjuseSrch
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
            this.btnscrh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.srchtextBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewProjSRCH = new System.Windows.Forms.DataGridView();
            this.Prj_Ct = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjSRCH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnscrh
            // 
            this.btnscrh.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnscrh.Location = new System.Drawing.Point(287, 82);
            this.btnscrh.Name = "btnscrh";
            this.btnscrh.Size = new System.Drawing.Size(75, 35);
            this.btnscrh.TabIndex = 7;
            this.btnscrh.Text = "Search";
            this.btnscrh.UseVisualStyleBackColor = true;
            this.btnscrh.Click += new System.EventHandler(this.btnscrh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search for Entry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Project_id :";
            // 
            // srchtextBox1
            // 
            this.srchtextBox1.Location = new System.Drawing.Point(262, 56);
            this.srchtextBox1.Name = "srchtextBox1";
            this.srchtextBox1.Size = new System.Drawing.Size(150, 20);
            this.srchtextBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewProjSRCH);
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 100);
            this.panel1.TabIndex = 8;
            // 
            // dataGridViewProjSRCH
            // 
            this.dataGridViewProjSRCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjSRCH.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProjSRCH.Name = "dataGridViewProjSRCH";
            this.dataGridViewProjSRCH.Size = new System.Drawing.Size(635, 100);
            this.dataGridViewProjSRCH.TabIndex = 0;
            // 
            // Prj_Ct
            // 
            this.Prj_Ct.AutoSize = true;
            this.Prj_Ct.Location = new System.Drawing.Point(515, 56);
            this.Prj_Ct.Name = "Prj_Ct";
            this.Prj_Ct.Size = new System.Drawing.Size(74, 13);
            this.Prj_Ct.TabIndex = 9;
            this.Prj_Ct.Text = "Project_Count";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(532, 82);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(0, 13);
            this.count.TabIndex = 10;
            // 
            // PjuseSrch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.count);
            this.Controls.Add(this.Prj_Ct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnscrh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srchtextBox1);
            this.Name = "PjuseSrch";
            this.Size = new System.Drawing.Size(638, 236);
            this.Load += new System.EventHandler(this.PjuseSrch_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjSRCH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnscrh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox srchtextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProjSRCH;
        private System.Windows.Forms.Label Prj_Ct;
        private System.Windows.Forms.Label count;
    }
}
