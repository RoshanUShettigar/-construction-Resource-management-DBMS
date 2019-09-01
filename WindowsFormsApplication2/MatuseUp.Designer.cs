namespace WindowsFormsApplication2
{
    partial class MatuseUp
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
            this.btnup = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.uptextBox5 = new System.Windows.Forms.TextBox();
            this.uptextBox4 = new System.Windows.Forms.TextBox();
            this.uptextBox2 = new System.Windows.Forms.TextBox();
            this.uptextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMatUP = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatUP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnup
            // 
            this.btnup.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.Location = new System.Drawing.Point(261, 100);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(87, 31);
            this.btnup.TabIndex = 39;
            this.btnup.Text = "Update";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Update Entry";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uptextBox5
            // 
            this.uptextBox5.Location = new System.Drawing.Point(510, 71);
            this.uptextBox5.Name = "uptextBox5";
            this.uptextBox5.Size = new System.Drawing.Size(100, 20);
            this.uptextBox5.TabIndex = 30;
            // 
            // uptextBox4
            // 
            this.uptextBox4.Location = new System.Drawing.Point(384, 71);
            this.uptextBox4.Name = "uptextBox4";
            this.uptextBox4.Size = new System.Drawing.Size(100, 20);
            this.uptextBox4.TabIndex = 29;
            // 
            // uptextBox2
            // 
            this.uptextBox2.Location = new System.Drawing.Point(133, 71);
            this.uptextBox2.Name = "uptextBox2";
            this.uptextBox2.Size = new System.Drawing.Size(100, 20);
            this.uptextBox2.TabIndex = 27;
            // 
            // uptextBox1
            // 
            this.uptextBox1.Location = new System.Drawing.Point(3, 71);
            this.uptextBox1.Name = "uptextBox1";
            this.uptextBox1.Size = new System.Drawing.Size(100, 20);
            this.uptextBox1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Vendor name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Delivery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 39);
            this.label1.TabIndex = 40;
            this.label1.Text = "Materials\r\nrequired\r\n\r\n";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewMatUP);
            this.panel1.Location = new System.Drawing.Point(3, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 100);
            this.panel1.TabIndex = 46;
            // 
            // dataGridViewMatUP
            // 
            this.dataGridViewMatUP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatUP.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewMatUP.Name = "dataGridViewMatUP";
            this.dataGridViewMatUP.Size = new System.Drawing.Size(604, 97);
            this.dataGridViewMatUP.TabIndex = 0;
            // 
            // MatuseUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uptextBox5);
            this.Controls.Add(this.uptextBox4);
            this.Controls.Add(this.uptextBox2);
            this.Controls.Add(this.uptextBox1);
            this.Name = "MatuseUp";
            this.Size = new System.Drawing.Size(617, 242);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uptextBox5;
        private System.Windows.Forms.TextBox uptextBox4;
        private System.Windows.Forms.TextBox uptextBox2;
        private System.Windows.Forms.TextBox uptextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMatUP;
    }
}
