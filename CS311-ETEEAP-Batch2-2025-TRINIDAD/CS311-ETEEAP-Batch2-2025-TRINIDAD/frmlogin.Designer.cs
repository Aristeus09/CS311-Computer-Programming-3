namespace CS311_ETEEAP_Batch2_2025_TRINIDAD
{
    partial class frmlogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lgnclosebtn = new FontAwesome.Sharp.IconPictureBox();
            this.lgnminizebtn = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbshow = new System.Windows.Forms.CheckBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closetip = new System.Windows.Forms.ToolTip(this.components);
            this.minimizetip = new System.Windows.Forms.ToolTip(this.components);
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgnclosebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgnminizebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Panel1.Controls.Add(this.lgnclosebtn);
            this.Panel1.Controls.Add(this.lgnminizebtn);
            this.Panel1.Controls.Add(this.pictureBox1);
            this.Panel1.Controls.Add(this.cbshow);
            this.Panel1.Controls.Add(this.btnclear);
            this.Panel1.Controls.Add(this.btnlogin);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.txtpassword);
            this.Panel1.Controls.Add(this.txtusername);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(547, 256);
            this.Panel1.TabIndex = 0;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // lgnclosebtn
            // 
            this.lgnclosebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lgnclosebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lgnclosebtn.ForeColor = System.Drawing.Color.MediumPurple;
            this.lgnclosebtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.lgnclosebtn.IconColor = System.Drawing.Color.MediumPurple;
            this.lgnclosebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lgnclosebtn.IconSize = 21;
            this.lgnclosebtn.Location = new System.Drawing.Point(521, 3);
            this.lgnclosebtn.Name = "lgnclosebtn";
            this.lgnclosebtn.Size = new System.Drawing.Size(23, 33);
            this.lgnclosebtn.TabIndex = 10;
            this.lgnclosebtn.TabStop = false;
            this.lgnclosebtn.Click += new System.EventHandler(this.lgnclosebtn_Click);
            // 
            // lgnminizebtn
            // 
            this.lgnminizebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lgnminizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lgnminizebtn.ForeColor = System.Drawing.Color.MediumPurple;
            this.lgnminizebtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.lgnminizebtn.IconColor = System.Drawing.Color.MediumPurple;
            this.lgnminizebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lgnminizebtn.IconSize = 21;
            this.lgnminizebtn.Location = new System.Drawing.Point(492, 0);
            this.lgnminizebtn.Name = "lgnminizebtn";
            this.lgnminizebtn.Size = new System.Drawing.Size(23, 33);
            this.lgnminizebtn.TabIndex = 9;
            this.lgnminizebtn.TabStop = false;
            this.lgnminizebtn.Click += new System.EventHandler(this.lgnminizebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbshow
            // 
            this.cbshow.AutoSize = true;
            this.cbshow.ForeColor = System.Drawing.Color.MediumPurple;
            this.cbshow.Location = new System.Drawing.Point(387, 163);
            this.cbshow.Name = "cbshow";
            this.cbshow.Size = new System.Drawing.Size(102, 17);
            this.cbshow.TabIndex = 8;
            this.cbshow.Text = "Show Password";
            this.cbshow.UseVisualStyleBackColor = true;
            this.cbshow.CheckedChanged += new System.EventHandler(this.cbshow_CheckedChanged);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnclear.Location = new System.Drawing.Point(305, 189);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(76, 27);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlogin.Location = new System.Drawing.Point(202, 189);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(76, 27);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(94, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(90, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(202, 161);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(179, 20);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(202, 129);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(179, 20);
            this.txtusername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(224, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 245);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CS311 - Computer Programming 3";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgnclosebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgnminizebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip closetip;
        private System.Windows.Forms.ToolTip minimizetip;
        private FontAwesome.Sharp.IconPictureBox lgnminizebtn;
        private FontAwesome.Sharp.IconPictureBox lgnclosebtn;
    }
}

