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
            this.signOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.signOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signOutButton.Location = new System.Drawing.Point(128, 132);
            this.signOutButton.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(246, 46);
            this.signOutButton.TabIndex = 0;
            this.signOutButton.Text = " Sign out";
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // joinRoomButton
            // 
            this.joinRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.joinRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.joinRoomButton.Location = new System.Drawing.Point(128, 188);
            this.joinRoomButton.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.joinRoomButton.Name = "joinRoomButton";
            this.joinRoomButton.Size = new System.Drawing.Size(246, 46);
            this.joinRoomButton.TabIndex = 1;
            this.joinRoomButton.Text = "Join room";
            this.joinRoomButton.UseVisualStyleBackColor = false;
            this.joinRoomButton.Click += new System.EventHandler(this.joinRoomButton_Click);
            // 
            // createRoomButton
            // 
            this.createRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.createRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createRoomButton.Location = new System.Drawing.Point(128, 244);
            this.createRoomButton.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.createRoomButton.Name = "createRoomButton";
            this.createRoomButton.Size = new System.Drawing.Size(246, 46);
            this.createRoomButton.TabIndex = 2;
            this.createRoomButton.Text = "Create room";
            this.createRoomButton.UseVisualStyleBackColor = false;
            this.createRoomButton.Click += new System.EventHandler(this.createRoomButton_Click);
            // 
            // myStatusButton
            // 
            this.myStatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.myStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myStatusButton.Location = new System.Drawing.Point(128, 300);
            this.myStatusButton.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.myStatusButton.Name = "myStatusButton";
            this.myStatusButton.Size = new System.Drawing.Size(246, 46);
            this.myStatusButton.TabIndex = 3;
            this.myStatusButton.Text = "My status";
            this.myStatusButton.UseVisualStyleBackColor = false;
            this.myStatusButton.Click += new System.EventHandler(this.myStatusButton_Click);
            // 
            // bestScoresButton
            // 
            this.bestScoresButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bestScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestScoresButton.Location = new System.Drawing.Point(128, 356);
            this.bestScoresButton.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.bestScoresButton.Name = "bestScoresButton";
            this.bestScoresButton.Size = new System.Drawing.Size(246, 46);
            this.bestScoresButton.TabIndex = 4;
            this.bestScoresButton.Text = "Best scores";
            this.bestScoresButton.UseVisualStyleBackColor = false;
            this.bestScoresButton.Click += new System.EventHandler(this.bestScoresButton_Click);
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