namespace GUI
{
    partial class MenuForm
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
            this.signOutButton = new System.Windows.Forms.Button();
            this.joinRoomButton = new System.Windows.Forms.Button();
            this.createRoomButton = new System.Windows.Forms.Button();
            this.myStatusButton = new System.Windows.Forms.Button();
            this.bestScoresButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(128, 132);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Text = " Sign out";
            this.signOutButton.TabIndex = 0;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            Initializer.initialMenuButton(ref this.signOutButton);
            // 
            // joinRoomButton
            // 
            this.joinRoomButton.Location = new System.Drawing.Point(128, 188);
            this.joinRoomButton.Name = "joinRoomButton";
            this.joinRoomButton.TabIndex = 1;
            this.joinRoomButton.Text = "Join room";
            this.joinRoomButton.Click += new System.EventHandler(this.joinRoomButton_Click);
            Initializer.initialMenuButton(ref this.joinRoomButton);
            // 
            // createRoomButton
            // 
            this.createRoomButton.Location = new System.Drawing.Point(128, 244);
            this.createRoomButton.Name = "createRoomButton";
            this.createRoomButton.TabIndex = 2;
            this.createRoomButton.Text = "Create room";
            this.createRoomButton.Click += new System.EventHandler(this.createRoomButton_Click);
            Initializer.initialMenuButton(ref this.createRoomButton);

            // 
            // myStatusButton
            // 
            this.myStatusButton.Location = new System.Drawing.Point(128, 300);
            this.myStatusButton.Name = "myStatusButton";
            this.myStatusButton.TabIndex = 3;
            this.myStatusButton.Text = "My status";
            this.myStatusButton.Click += new System.EventHandler(this.myStatusButton_Click);
            Initializer.initialMenuButton(ref this.myStatusButton);

            // 
            // bestScoresButton
            // 
            this.bestScoresButton.Location = new System.Drawing.Point(128, 356);
            this.bestScoresButton.Name = "bestScoresButton";
            this.bestScoresButton.TabIndex = 4;
            this.bestScoresButton.Text = "Best scores";
            this.bestScoresButton.Click += new System.EventHandler(this.bestScoresButton_Click);
            Initializer.initialMenuButton(ref this.bestScoresButton);

            // 
            // label1
            //             
            Initializer.initialTriviaLabel(ref label1);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(512, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bestScoresButton);
            this.Controls.Add(this.myStatusButton);
            this.Controls.Add(this.createRoomButton);
            this.Controls.Add(this.joinRoomButton);
            this.Controls.Add(this.signOutButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Button joinRoomButton;
        private System.Windows.Forms.Button createRoomButton;
        private System.Windows.Forms.Button myStatusButton;
        private System.Windows.Forms.Button bestScoresButton;
        private System.Windows.Forms.Label label1;
    }
}