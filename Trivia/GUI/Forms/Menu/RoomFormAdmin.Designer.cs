namespace GUI.Forms.Menu
{
    partial class RoomFormAdmin
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
            this.userListBox = new System.Windows.Forms.ListBox();
            this.closeRoomButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userListBox
            // 
            this.userListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 26;
            this.userListBox.Location = new System.Drawing.Point(119, 64);
            this.userListBox.Margin = new System.Windows.Forms.Padding(2);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(261, 212);
            this.userListBox.TabIndex = 0;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // closeRoomButton
            // 
            this.closeRoomButton.AccessibleName = "";
            this.closeRoomButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeRoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeRoomButton.Location = new System.Drawing.Point(184, 350);
            this.closeRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeRoomButton.Name = "closeRoomButton";
            this.closeRoomButton.Size = new System.Drawing.Size(131, 52);
            this.closeRoomButton.TabIndex = 26;
            this.closeRoomButton.Text = "CLOSE ROOM";
            this.closeRoomButton.UseVisualStyleBackColor = false;
            this.closeRoomButton.Click += new System.EventHandler(this.closeRoomButton_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.AccessibleName = "";
            this.startGameButton.BackColor = System.Drawing.SystemColors.Control;
            this.startGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGameButton.Location = new System.Drawing.Point(130, 407);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(236, 85);
            this.startGameButton.TabIndex = 27;
            this.startGameButton.Text = "START GAME";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 54);
            this.label1.TabIndex = 28;
            this.label1.Text = "The Trivia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.closeRoomButton);
            this.Controls.Add(this.userListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomFormAdmin";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomFormAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Button closeRoomButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label label1;
    }
}