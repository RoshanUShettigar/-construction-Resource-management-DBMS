namespace WindowsFormsApplication2
{
    partial class MatuseSrch
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
            this.dataGridViewMatSRCH = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatSRCH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnscrh
            // 
            this.btnscrh.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnscrh.Location = new System.Drawing.Point(271, 76);
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
            this.label2.Location = new System.Drawing.Point(223, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search for Entry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vendor Name :";
            // 
            // srchtextBox1
            // 
            this.srchtextBox1.Location = new System.Drawing.Point(236, 50);
            this.srchtextBox1.Name = "srchtextBox1";
            this.srchtextBox1.Size = new System.Drawing.Size(150, 20);
            this.srchtextBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewMatSRCH);
            this.panel1.Location = new System.Drawing.Point(3, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 115);
            this.panel1.TabIndex = 8;
            // 
            // dataGridViewMatSRCH
            // 
            this.dataGridViewMatSRCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatSRCH.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMatSRCH.Name = "dataGridViewMatSRCH";
            this.dataGridViewMatSRCH.Size = new System.Drawing.Size(626, 112);
            this.dataGridViewMatSRCH.TabIndex = 0;
            // 
            // MatuseSrch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnscrh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srchtextBox1);
            this.Name = "MatuseSrch";
            this.Size = new System.Drawing.Size(638, 232);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatSRCH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnscrh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox srchtextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMatSRCH;
    }
}
