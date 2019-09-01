namespace WindowsFormsApplication2
{
    partial class PUseLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PUseLog));
            this.txtUname = new System.Windows.Forms.TextBox();
            this.llog = new System.Windows.Forms.Label();
            this.lusename = new System.Windows.Forms.Label();
            this.lpass = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.bttsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUname
            // 
            this.txtUname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUname.Location = new System.Drawing.Point(150, 65);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(186, 20);
            this.txtUname.TabIndex = 1;
            this.txtUname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUname_MouseClick);
            this.txtUname.TextChanged += new System.EventHandler(this.txtUname_TextChanged);
            // 
            // llog
            // 
            this.llog.AutoSize = true;
            this.llog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.llog.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llog.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.llog.Location = new System.Drawing.Point(176, 12);
            this.llog.Name = "llog";
            this.llog.Size = new System.Drawing.Size(91, 25);
            this.llog.TabIndex = 2;
            this.llog.Text = "LOGIN";
            this.llog.Click += new System.EventHandler(this.llog_Click);
            // 
            // lusename
            // 
            this.lusename.AutoSize = true;
            this.lusename.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lusename.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lusename.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lusename.Location = new System.Drawing.Point(12, 60);
            this.lusename.Name = "lusename";
            this.lusename.Size = new System.Drawing.Size(134, 23);
            this.lusename.TabIndex = 3;
            this.lusename.Text = "USERNAME :";
            this.lusename.Click += new System.EventHandler(this.lusename_Click);
            // 
            // lpass
            // 
            this.lpass.AutoSize = true;
            this.lpass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lpass.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpass.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lpass.Location = new System.Drawing.Point(10, 123);
            this.lpass.Name = "lpass";
            this.lpass.Size = new System.Drawing.Size(136, 23);
            this.lpass.TabIndex = 4;
            this.lpass.Text = "Password :";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(150, 126);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(186, 20);
            this.txtPasswd.TabIndex = 5;
            this.txtPasswd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPasswd_MouseClick);
            this.txtPasswd.TextChanged += new System.EventHandler(this.txtPasswd_TextChanged);
            // 
            // bttsubmit
            // 
            this.bttsubmit.BackColor = System.Drawing.Color.Thistle;
            this.bttsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttsubmit.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttsubmit.Location = new System.Drawing.Point(150, 173);
            this.bttsubmit.Name = "bttsubmit";
            this.bttsubmit.Size = new System.Drawing.Size(117, 46);
            this.bttsubmit.TabIndex = 6;
            this.bttsubmit.Text = "SUBMIT";
            this.bttsubmit.UseVisualStyleBackColor = false;
            this.bttsubmit.Click += new System.EventHandler(this.button1_Click);
            this.bttsubmit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnsubmit);
            // 
            // PUseLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bttsubmit);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.lpass);
            this.Controls.Add(this.lusename);
            this.Controls.Add(this.llog);
            this.Controls.Add(this.txtUname);
            this.Name = "PUseLog";
            this.Size = new System.Drawing.Size(358, 259);
            this.Load += new System.EventHandler(this.PUseLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label llog;
        private System.Windows.Forms.Label lusename;
        private System.Windows.Forms.Label lpass;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Button bttsubmit;
    }
}
