namespace GUI.Forms.Menu
{
    partial class JoinRoomForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.backMenuButton = new System.Windows.Forms.Button();
            this.joinButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.roomsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 66);
            this.label1.TabIndex = 6;
            this.label1.Text = "The Trivia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backMenuButton
            // 
            this.backMenuButton.AccessibleName = "";
            this.backMenuButton.BackColor = System.Drawing.SystemColors.Control;
            this.backMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backMenuButton.Location = new System.Drawing.Point(558, 0);
            this.backMenuButton.Name = "backMenuButton";
            this.backMenuButton.Size = new System.Drawing.Size(124, 46);
            this.backMenuButton.TabIndex = 25;
            this.backMenuButton.Text = "back";
            this.backMenuButton.UseVisualStyleBackColor = false;
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.AccessibleName = "";
            this.joinButton.BackColor = System.Drawing.SystemColors.Control;
            this.joinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.joinButton.Location = new System.Drawing.Point(247, 531);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(177, 78);
            this.joinButton.TabIndex = 26;
            this.joinButton.Text = "JOIN";
            this.joinButton.UseVisualStyleBackColor = false;
            // 
            // refreshButton
            // 
            this.refreshButton.AccessibleName = "";
            this.refreshButton.BackColor = System.Drawing.SystemColors.Control;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.Location = new System.Drawing.Point(284, 480);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(113, 45);
            this.refreshButton.TabIndex = 27;
            this.refreshButton.Text = "REFRESH";
            this.refreshButton.UseVisualStyleBackColor = false;
            // 
            // roomsPanel
            // 
            this.roomsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.roomsPanel.AutoScroll = true;
            this.roomsPanel.AutoSize = true;
            this.roomsPanel.Location = new System.Drawing.Point(181, 3);
            this.roomsPanel.MinimumSize = new System.Drawing.Size(100, 100);
            this.roomsPanel.Name = "roomsPanel";
            this.roomsPanel.Size = new System.Drawing.Size(100, 337);
            this.roomsPanel.TabIndex = 28;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.roomsPanel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(113, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 343);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // JoinRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.label1);
            this.Name = "JoinRoomForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.FlowLayoutPanel roomsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}