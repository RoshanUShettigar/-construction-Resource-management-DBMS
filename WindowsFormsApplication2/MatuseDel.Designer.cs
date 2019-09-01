namespace WindowsFormsApplication2
{
    partial class MatuseDel
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
            this.btndel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deltextBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMatDEL = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatDEL)).BeginInit();
            this.SuspendLayout();
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(272, 71);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 37);
            this.btndel.TabIndex = 9;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delete Entry";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vendor :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // deltextBox1
            // 
            this.deltextBox1.Location = new System.Drawing.Point(234, 36);
            this.deltextBox1.Name = "deltextBox1";
            this.deltextBox1.Size = new System.Drawing.Size(150, 20);
            this.deltextBox1.TabIndex = 6;
            this.deltextBox1.TextChanged += new System.EventHandler(this.deltextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewMatDEL);
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 89);
            this.panel1.TabIndex = 10;
            // 
            // dataGridViewMatDEL
            // 
            this.dataGridViewMatDEL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatDEL.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMatDEL.Name = "dataGridViewMatDEL";
            this.dataGridViewMatDEL.Size = new System.Drawing.Size(638, 89);
            this.dataGridViewMatDEL.TabIndex = 1;
            // 
            // MatuseDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deltextBox1);
            this.Name = "MatuseDel";
            this.Size = new System.Drawing.Size(638, 203);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatDEL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deltextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMatDEL;
    }
}
