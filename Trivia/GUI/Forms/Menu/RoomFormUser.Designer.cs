namespace GUI.Forms.Menu
{
    partial class RoomFormUser
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
            this.leaveRoomButton = new System.Windows.Forms.Button();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leaveRoomButton
            // 
            this.leaveRoomButton.AccessibleName = "";
            this.leaveRoomButton.BackColor = System.Drawing.SystemColors.Control;
            this.leaveRoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leaveRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaveRoomButton.Location = new System.Drawing.Point(191, 337);
            this.leaveRoomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leaveRoomButton.Name = "leaveRoomButton";
            this.leaveRoomButton.Size = new System.Drawing.Size(131, 52);
            this.leaveRoomButton.TabIndex = 29;
            this.leaveRoomButton.Text = "LEAVE ROOM";
            this.leaveRoomButton.UseVisualStyleBackColor = false;
            this.leaveRoomButton.Click += new System.EventHandler(this.leaveRoomButton_Click);
            // 
            // userListBox
            // 
            this.userListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 26;
            this.userListBox.Location = new System.Drawing.Point(126, 51);
            this.userListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(261, 212);
            this.userListBox.TabIndex = 28;
            // 
            // label1
            // 
            Initializer.initialTriviaLabel(ref label1);
            // 
            // RoomFormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leaveRoomButton);
            this.Controls.Add(this.userListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RoomFormUser";
            this.Text = "RoomFormUser";
            this.Load += new System.EventHandler(this.RoomFormUser_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button leaveRoomButton;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label label1;
    }
}