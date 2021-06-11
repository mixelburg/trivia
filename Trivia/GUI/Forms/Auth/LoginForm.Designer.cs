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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.pictureBoxUname = new System.Windows.Forms.PictureBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUname = new System.Windows.Forms.TextBox();
            this.SignupLabes = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUname)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.AccessibleName = "";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(142, 271);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(106, 41);
            this.loginButton.TabIndex = 21;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pictureBoxPass
            // 
            Initializer.initialPassPic(ref this.pictureBoxPass, ref resources);
            // 
            // pictureBoxUname
            // 
            Initializer.initialUnamePic(ref this.pictureBoxUname, ref resources);
            // 
            // textBoxPass
            // 
            Initializer.initialPassTextBox(ref this.textBoxPass);
            // 
            // textBoxUname
            // 
            Initializer.initialUnameTextBox(ref this.textBoxUname);
            // 
            // SignupLabes
            // 
            this.SignupLabes.Dock = System.Windows.Forms.DockStyle.Top;
            this.SignupLabes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignupLabes.Location = new System.Drawing.Point(0, 0);
            this.SignupLabes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignupLabes.Name = "SignupLabes";
            this.SignupLabes.Size = new System.Drawing.Size(380, 79);
            this.SignupLabes.TabIndex = 14;
            this.SignupLabes.Text = "Login";
            this.SignupLabes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignupLabes.UseMnemonic = false;
            this.SignupLabes.Click += new System.EventHandler(this.SignupLabes_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.DarkCyan;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(380, 115);
            this.statusLabel.TabIndex = 22;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 380);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 115);
            this.panel1.TabIndex = 23;
            // 
            // signupButton
            // 
            this.signupButton.AccessibleName = "";
            this.signupButton.BackColor = System.Drawing.SystemColors.Control;
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signupButton.Location = new System.Drawing.Point(286, 0);
            this.signupButton.Margin = new System.Windows.Forms.Padding(2);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(93, 37);
            this.signupButton.TabIndex = 24;
            this.signupButton.Text = "signup";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(380, 495);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pictureBoxPass);
            this.Controls.Add(this.pictureBoxUname);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUname);
            this.Controls.Add(this.SignupLabes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "NewLoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUname)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.PictureBox pictureBoxUname;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUname;
        private System.Windows.Forms.Label SignupLabes;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signupButton;
    }
}