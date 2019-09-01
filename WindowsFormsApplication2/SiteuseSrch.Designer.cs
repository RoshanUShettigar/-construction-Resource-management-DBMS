namespace WindowsFormsApplication2
{
    partial class SiteuseSrch
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
            this.srchtextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnscrh = new System.Windows.Forms.Button();
            this.usepanelsrch = new System.Windows.Forms.Panel();
            this.dataGridViewSiteSRCH = new System.Windows.Forms.DataGridView();
            this.usepanelsrch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiteSRCH)).BeginInit();
            this.SuspendLayout();
            // 
            // srchtextBox1
            // 
            this.srchtextBox1.Location = new System.Drawing.Point(241, 40);
            this.srchtextBox1.Name = "srchtextBox1";
            this.srchtextBox1.Size = new System.Drawing.Size(150, 20);
            this.srchtextBox1.TabIndex = 0;
            this.srchtextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project_id :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search for Entry";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnscrh
            // 
            this.btnscrh.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnscrh.Location = new System.Drawing.Point(286, 80);
            this.btnscrh.Name = "btnscrh";
            this.btnscrh.Size = new System.Drawing.Size(75, 35);
            this.btnscrh.TabIndex = 3;
            this.btnscrh.Text = "Search";
            this.btnscrh.UseVisualStyleBackColor = true;
            this.btnscrh.Click += new System.EventHandler(this.btnscrh_Click);
            // 
            // usepanelsrch
            // 
            this.usepanelsrch.Controls.Add(this.dataGridViewSiteSRCH);
            this.usepanelsrch.Location = new System.Drawing.Point(3, 127);
            this.usepanelsrch.Name = "usepanelsrch";
            this.usepanelsrch.Size = new System.Drawing.Size(635, 178);
            this.usepanelsrch.TabIndex = 4;
            // 
            // dataGridViewSiteSRCH
            // 
            this.dataGridViewSiteSRCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiteSRCH.Location = new System.Drawing.Point(0, 16);
            this.dataGridViewSiteSRCH.Name = "dataGridViewSiteSRCH";
            this.dataGridViewSiteSRCH.Size = new System.Drawing.Size(632, 150);
            this.dataGridViewSiteSRCH.TabIndex = 0;
            this.dataGridViewSiteSRCH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SiteuseSrch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.usepanelsrch);
            this.Controls.Add(this.btnscrh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srchtextBox1);
            this.Name = "SiteuseSrch";
            this.Size = new System.Drawing.Size(638, 328);
            this.Load += new System.EventHandler(this.SiteuseSrch_Load);
            this.usepanelsrch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiteSRCH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srchtextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnscrh;
        private System.Windows.Forms.Panel usepanelsrch;
        private System.Windows.Forms.DataGridView dataGridViewSiteSRCH;
    }
}
