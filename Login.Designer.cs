namespace GUI_Login
{
    partial class Login
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
            this.tbUser = new System.Windows.Forms.TextBox();
            this.pnUser = new System.Windows.Forms.Panel();
            this.pnPass = new System.Windows.Forms.Panel();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbForgotPass = new System.Windows.Forms.Label();
            this.lbCreateACC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbUser.HideSelection = false;
            this.tbUser.Location = new System.Drawing.Point(55, 131);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(220, 18);
            this.tbUser.TabIndex = 1;
            this.tbUser.TabStop = false;
            this.tbUser.Text = "Username or email address";
            this.tbUser.Click += new System.EventHandler(this.tbUser_Click);
            // 
            // pnUser
            // 
            this.pnUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnUser.ForeColor = System.Drawing.SystemColors.Control;
            this.pnUser.Location = new System.Drawing.Point(25, 157);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(250, 1);
            this.pnUser.TabIndex = 2;
            // 
            // pnPass
            // 
            this.pnPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnPass.Location = new System.Drawing.Point(26, 203);
            this.pnPass.Name = "pnPass";
            this.pnPass.Size = new System.Drawing.Size(250, 1);
            this.pnPass.TabIndex = 5;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbPass.HideSelection = false;
            this.tbPass.Location = new System.Drawing.Point(56, 177);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(190, 18);
            this.tbPass.TabIndex = 4;
            this.tbPass.TabStop = false;
            this.tbPass.Text = "Password";
            this.tbPass.Click += new System.EventHandler(this.tbPass_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSignIn.Location = new System.Drawing.Point(58, 260);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(196, 35);
            this.btnSignIn.TabIndex = 6;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sign in to Cinema";
            // 
            // lbForgotPass
            // 
            this.lbForgotPass.AutoSize = true;
            this.lbForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgotPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPass.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbForgotPass.Location = new System.Drawing.Point(23, 223);
            this.lbForgotPass.Name = "lbForgotPass";
            this.lbForgotPass.Size = new System.Drawing.Size(103, 16);
            this.lbForgotPass.TabIndex = 7;
            this.lbForgotPass.Text = "Forgot pasword?";
            this.lbForgotPass.Click += new System.EventHandler(this.lbForgotPass_Click);
            // 
            // lbCreateACC
            // 
            this.lbCreateACC.AutoSize = true;
            this.lbCreateACC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCreateACC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateACC.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbCreateACC.Location = new System.Drawing.Point(148, 329);
            this.lbCreateACC.Name = "lbCreateACC";
            this.lbCreateACC.Size = new System.Drawing.Size(117, 16);
            this.lbCreateACC.TabIndex = 7;
            this.lbCreateACC.Text = "Create an account.";
            this.lbCreateACC.Click += new System.EventHandler(this.lbCreateACC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(46, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "New to Cinema?";
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImage = global::GUI_Login.Properties.Resources.cancel;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Location = new System.Drawing.Point(293, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(16, 16);
            this.pbClose.TabIndex = 8;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbPass
            // 
            this.pbPass.BackgroundImage = global::GUI_Login.Properties.Resources.lock__1_;
            this.pbPass.Location = new System.Drawing.Point(26, 173);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(24, 24);
            this.pbPass.TabIndex = 3;
            this.pbPass.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pbUser.BackgroundImage = global::GUI_Login.Properties.Resources.login__1_;
            this.pbUser.Location = new System.Drawing.Point(25, 127);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(24, 24);
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            // 
            // pbHome
            // 
            this.pbHome.BackgroundImage = global::GUI_Login.Properties.Resources.film_reel;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Location = new System.Drawing.Point(116, 12);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(64, 64);
            this.pbHome.TabIndex = 0;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(310, 389);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCreateACC);
            this.Controls.Add(this.lbForgotPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.pnPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.pbPass);
            this.Controls.Add(this.pnUser);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.pbHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.Panel pnPass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbForgotPass;
        private System.Windows.Forms.Label lbCreateACC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbClose;
    }
}

