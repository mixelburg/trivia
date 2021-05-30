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
            this.signOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signOutButton.Location = new System.Drawing.Point(170, 162);
            this.signOutButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(328, 56);
            this.signOutButton.TabIndex = 0;
            this.signOutButton.Text = " Sign out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // joinRoomButton
            // 
            this.joinRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.joinRoomButton.Location = new System.Drawing.Point(170, 231);
            this.joinRoomButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.joinRoomButton.Name = "joinRoomButton";
            this.joinRoomButton.Size = new System.Drawing.Size(328, 56);
            this.joinRoomButton.TabIndex = 1;
            this.joinRoomButton.Text = "Join room";
            this.joinRoomButton.UseVisualStyleBackColor = true;
            this.joinRoomButton.Click += new System.EventHandler(this.joinRoomButton_Click);
            // 
            // createRoomButton
            // 
            this.createRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createRoomButton.Location = new System.Drawing.Point(170, 300);
            this.createRoomButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.createRoomButton.Name = "createRoomButton";
            this.createRoomButton.Size = new System.Drawing.Size(328, 56);
            this.createRoomButton.TabIndex = 2;
            this.createRoomButton.Text = "Create room";
            this.createRoomButton.UseVisualStyleBackColor = true;
            // 
            // myStatusButton
            // 
            this.myStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myStatusButton.Location = new System.Drawing.Point(170, 369);
            this.myStatusButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.myStatusButton.Name = "myStatusButton";
            this.myStatusButton.Size = new System.Drawing.Size(328, 56);
            this.myStatusButton.TabIndex = 3;
            this.myStatusButton.Text = "My status";
            this.myStatusButton.UseVisualStyleBackColor = true;
            // 
            // bestScoresButton
            // 
            this.bestScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestScoresButton.Location = new System.Drawing.Point(170, 438);
            this.bestScoresButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.bestScoresButton.Name = "bestScoresButton";
            this.bestScoresButton.Size = new System.Drawing.Size(328, 56);
            this.bestScoresButton.TabIndex = 4;
            this.bestScoresButton.Text = "Best scores";
            this.bestScoresButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 66);
            this.label1.TabIndex = 5;
            this.label1.Text = "The Trivia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bestScoresButton);
            this.Controls.Add(this.myStatusButton);
            this.Controls.Add(this.createRoomButton);
            this.Controls.Add(this.joinRoomButton);
            this.Controls.Add(this.signOutButton);
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