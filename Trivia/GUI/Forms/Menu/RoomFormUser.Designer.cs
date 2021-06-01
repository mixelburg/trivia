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
            this.leaveRoomButton.Location = new System.Drawing.Point(255, 415);
            this.leaveRoomButton.Name = "leaveRoomButton";
            this.leaveRoomButton.Size = new System.Drawing.Size(175, 64);
            this.leaveRoomButton.TabIndex = 29;
            this.leaveRoomButton.Text = "LEAVE ROOM";
            this.leaveRoomButton.UseVisualStyleBackColor = false;
            this.leaveRoomButton.Click += new System.EventHandler(this.leaveRoomButton_Click);
            // 
            // userListBox
            // 
            this.userListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 31;
            this.userListBox.Items.AddRange(new object[] {
            "hello",
            "user1",
            "user2"});
            this.userListBox.Location = new System.Drawing.Point(168, 63);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(347, 283);
            this.userListBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 66);
            this.label1.TabIndex = 30;
            this.label1.Text = "The Trivia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomFormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leaveRoomButton);
            this.Controls.Add(this.userListBox);
            this.Name = "RoomFormUser";
            this.Text = "RoomFormUser";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button leaveRoomButton;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label label1;
    }
}