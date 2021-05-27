namespace GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.textBoxUname = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.pictureBoxUname = new System.Windows.Forms.PictureBox();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.loginStatusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.AccessibleName = "";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(182, 369);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(141, 50);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // textBoxUname
            // 
            this.textBoxUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUname.Location = new System.Drawing.Point(131, 170);
            this.textBoxUname.Name = "textBoxUname";
            this.textBoxUname.Size = new System.Drawing.Size(298, 64);
            this.textBoxUname.TabIndex = 1;
            this.textBoxUname.TextChanged += new System.EventHandler(this.textBoxUname_TextChanged);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(131, 271);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(298, 64);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.UseSystemPasswordChar = true;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // pictureBoxUname
            // 
            this.pictureBoxUname.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUname.Image")));
            this.pictureBoxUname.Location = new System.Drawing.Point(61, 170);
            this.pictureBoxUname.Name = "pictureBoxUname";
            this.pictureBoxUname.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxUname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUname.TabIndex = 3;
            this.pictureBoxUname.TabStop = false;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPass.Image")));
            this.pictureBoxPass.Location = new System.Drawing.Point(61, 271);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPass.TabIndex = 4;
            this.pictureBoxPass.TabStop = false;
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthorizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationLabel.Location = new System.Drawing.Point(0, 0);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(506, 97);
            this.AuthorizationLabel.TabIndex = 5;
            this.AuthorizationLabel.Text = "Authorization";
            this.AuthorizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AuthorizationLabel.UseMnemonic = false;
            // 
            // loginStatusLabel
            // 
            this.loginStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.loginStatusLabel.Name = "loginStatusLabel";
            this.loginStatusLabel.Size = new System.Drawing.Size(506, 122);
            this.loginStatusLabel.TabIndex = 6;
            this.loginStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginStatusLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 122);
            this.panel1.TabIndex = 7;
            // 
            // signupButton
            // 
            this.signupButton.AccessibleName = "";
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signupButton.Location = new System.Drawing.Point(389, 369);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(105, 50);
            this.signupButton.TabIndex = 8;
            this.signupButton.Text = "signup";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 609);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AuthorizationLabel);
            this.Controls.Add(this.pictureBoxPass);
            this.Controls.Add(this.pictureBoxUname);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUname);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox textBoxUname;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.PictureBox pictureBoxUname;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.Label AuthorizationLabel;
        private System.Windows.Forms.Label loginStatusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signupButton;
    }
}