namespace WindowsFormsApplication2
{
    partial class MatuseIn
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.intextBox5 = new System.Windows.Forms.TextBox();
            this.intextBox4 = new System.Windows.Forms.TextBox();
            this.intextBox2 = new System.Windows.Forms.TextBox();
            this.intextBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMatIN = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatIN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(263, 112);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(95, 29);
            this.btnInsert.TabIndex = 27;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Insert Entry";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Vendor name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Delivery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Materials\r\nrequired\r\n\r\n";
            // 
            // intextBox5
            // 
            this.intextBox5.Location = new System.Drawing.Point(507, 86);
            this.intextBox5.Name = "intextBox5";
            this.intextBox5.Size = new System.Drawing.Size(100, 20);
            this.intextBox5.TabIndex = 18;
            // 
            // intextBox4
            // 
            this.intextBox4.Location = new System.Drawing.Point(391, 86);
            this.intextBox4.Name = "intextBox4";
            this.intextBox4.Size = new System.Drawing.Size(100, 20);
            this.intextBox4.TabIndex = 17;
            this.intextBox4.TextChanged += new System.EventHandler(this.intextBox4_TextChanged);
            // 
            // intextBox2
            // 
            this.intextBox2.Location = new System.Drawing.Point(127, 86);
            this.intextBox2.Name = "intextBox2";
            this.intextBox2.Size = new System.Drawing.Size(100, 20);
            this.intextBox2.TabIndex = 15;
            // 
            // intextBox1
            // 
            this.intextBox1.Location = new System.Drawing.Point(5, 86);
            this.intextBox1.Name = "intextBox1";
            this.intextBox1.Size = new System.Drawing.Size(100, 20);
            this.intextBox1.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(253, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewMatIN);
            this.panel1.Location = new System.Drawing.Point(5, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 100);
            this.panel1.TabIndex = 29;
            // 
            // dataGridViewMatIN
            // 
            this.dataGridViewMatIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatIN.Location = new System.Drawing.Point(-2, 0);
            this.dataGridViewMatIN.Name = "dataGridViewMatIN";
            this.dataGridViewMatIN.Size = new System.Drawing.Size(611, 103);
            this.dataGridViewMatIN.TabIndex = 1;
            // 
            // MatuseIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intextBox5);
            this.Controls.Add(this.intextBox4);
            this.Controls.Add(this.intextBox2);
            this.Controls.Add(this.intextBox1);
            this.Name = "MatuseIn";
            this.Size = new System.Drawing.Size(620, 249);
            this.Load += new System.EventHandler(this.MatuseIn_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intextBox5;
        private System.Windows.Forms.TextBox intextBox4;
        private System.Windows.Forms.TextBox intextBox2;
        private System.Windows.Forms.TextBox intextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMatIN;
    }
}
