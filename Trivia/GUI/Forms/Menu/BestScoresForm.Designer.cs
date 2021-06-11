namespace GUI.Forms.Menu
{
    partial class BestScoresForm
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
            this.bestScoresListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            Initializer.initialTriviaLabel(ref label1);
            // 
            // backMenuButton
            // 
            Initializer.initialBackButton(ref this.backMenuButton);
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // bestScoresListBox
            // 
            this.bestScoresListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestScoresListBox.FormattingEnabled = true;
            this.bestScoresListBox.ItemHeight = 46;
            this.bestScoresListBox.Location = new System.Drawing.Point(95, 154);
            this.bestScoresListBox.Name = "bestScoresListBox";
            this.bestScoresListBox.Size = new System.Drawing.Size(451, 280);
            this.bestScoresListBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(134, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "username: correct_answers";
            // 
            // BestScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bestScoresListBox);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.label1);
            this.Name = "BestScoresForm";
            this.Text = "BestScoresForm";
            this.Load += new System.EventHandler(this.BestScoresForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.ListBox bestScoresListBox;
        private System.Windows.Forms.Label label2;
    }
}