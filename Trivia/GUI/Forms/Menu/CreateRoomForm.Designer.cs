namespace GUI.Forms.Menu
{
    partial class CreateRoomForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.numPlayersLabel = new System.Windows.Forms.Label();
            this.numQuestionsLabel = new System.Windows.Forms.Label();
            this.timeQuestionLabes = new System.Windows.Forms.Label();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.numPlayersTextBox = new System.Windows.Forms.TextBox();
            this.numQuestionsTextBox = new System.Windows.Forms.TextBox();
            this.questionTimeTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 7;
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
            this.backMenuButton.TabIndex = 26;
            this.backMenuButton.Text = "back";
            this.backMenuButton.UseVisualStyleBackColor = false;
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.33739F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.66261F));
            this.tableLayoutPanel1.Controls.Add(this.questionTimeTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numQuestionsTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numPlayersTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.roomNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numPlayersLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numQuestionsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.timeQuestionLabes, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.roomNameTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 165);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 355);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomNameLabel.Location = new System.Drawing.Point(3, 0);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(202, 36);
            this.roomNameLabel.TabIndex = 0;
            this.roomNameLabel.Text = "ROOM NAME";
            // 
            // numPlayersLabel
            // 
            this.numPlayersLabel.AutoSize = true;
            this.numPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPlayersLabel.Location = new System.Drawing.Point(3, 76);
            this.numPlayersLabel.Name = "numPlayersLabel";
            this.numPlayersLabel.Size = new System.Drawing.Size(232, 36);
            this.numPlayersLabel.TabIndex = 1;
            this.numPlayersLabel.Text = "NUM PLAYERS";
            // 
            // numQuestionsLabel
            // 
            this.numQuestionsLabel.AutoSize = true;
            this.numQuestionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numQuestionsLabel.Location = new System.Drawing.Point(3, 152);
            this.numQuestionsLabel.Name = "numQuestionsLabel";
            this.numQuestionsLabel.Size = new System.Drawing.Size(266, 36);
            this.numQuestionsLabel.TabIndex = 2;
            this.numQuestionsLabel.Text = "NUM QUESTIONS";
            // 
            // timeQuestionLabes
            // 
            this.timeQuestionLabes.AutoSize = true;
            this.timeQuestionLabes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeQuestionLabes.Location = new System.Drawing.Point(3, 245);
            this.timeQuestionLabes.Name = "timeQuestionLabes";
            this.timeQuestionLabes.Size = new System.Drawing.Size(248, 36);
            this.timeQuestionLabes.TabIndex = 3;
            this.timeQuestionLabes.Text = "QUESTION TIME";
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roomNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomNameTextBox.Location = new System.Drawing.Point(296, 3);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(359, 41);
            this.roomNameTextBox.TabIndex = 4;
            // 
            // numPlayersTextBox
            // 
            this.numPlayersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPlayersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPlayersTextBox.Location = new System.Drawing.Point(296, 79);
            this.numPlayersTextBox.Name = "numPlayersTextBox";
            this.numPlayersTextBox.Size = new System.Drawing.Size(359, 41);
            this.numPlayersTextBox.TabIndex = 5;
            // 
            // numQuestionsTextBox
            // 
            this.numQuestionsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numQuestionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numQuestionsTextBox.Location = new System.Drawing.Point(296, 155);
            this.numQuestionsTextBox.Name = "numQuestionsTextBox";
            this.numQuestionsTextBox.Size = new System.Drawing.Size(359, 41);
            this.numQuestionsTextBox.TabIndex = 6;
            // 
            // questionTimeTextBox
            // 
            this.questionTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.questionTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTimeTextBox.Location = new System.Drawing.Point(296, 248);
            this.questionTimeTextBox.Name = "questionTimeTextBox";
            this.questionTimeTextBox.Size = new System.Drawing.Size(359, 41);
            this.questionTimeTextBox.TabIndex = 7;
            // 
            // createButton
            // 
            this.createButton.AccessibleName = "";
            this.createButton.BackColor = System.Drawing.SystemColors.Control;
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(239, 537);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(194, 76);
            this.createButton.TabIndex = 28;
            this.createButton.Text = "CREATE";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // CreateRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.label1);
            this.Name = "CreateRoomForm";
            this.Text = "CreateRoomForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox questionTimeTextBox;
        private System.Windows.Forms.TextBox numQuestionsTextBox;
        private System.Windows.Forms.TextBox numPlayersTextBox;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Label numPlayersLabel;
        private System.Windows.Forms.Label numQuestionsLabel;
        private System.Windows.Forms.Label timeQuestionLabes;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Button createButton;
    }
}