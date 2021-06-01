namespace GUI.Forms.Menu
{
    partial class GameForm
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
            this.questionNumLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.ans1Button = new System.Windows.Forms.Button();
            this.ans4Button = new System.Windows.Forms.Button();
            this.ans3Button = new System.Windows.Forms.Button();
            this.ans2Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionNumLabel
            // 
            this.questionNumLabel.AutoSize = true;
            this.questionNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNumLabel.Location = new System.Drawing.Point(12, 103);
            this.questionNumLabel.Name = "questionNumLabel";
            this.questionNumLabel.Size = new System.Drawing.Size(184, 36);
            this.questionNumLabel.TabIndex = 1;
            this.questionNumLabel.Text = "Question 1/5";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(682, 66);
            this.label2.TabIndex = 8;
            this.label2.Text = "The Trivia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.Location = new System.Drawing.Point(92, 191);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(278, 32);
            this.questionLabel.TabIndex = 9;
            this.questionLabel.Text = "Where is my money?";
            // 
            // ans1Button
            // 
            this.ans1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans1Button.Location = new System.Drawing.Point(88, 301);
            this.ans1Button.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ans1Button.Name = "ans1Button";
            this.ans1Button.Size = new System.Drawing.Size(515, 50);
            this.ans1Button.TabIndex = 10;
            this.ans1Button.Text = "answer 1";
            this.ans1Button.UseVisualStyleBackColor = true;
            // 
            // ans4Button
            // 
            this.ans4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans4Button.Location = new System.Drawing.Point(88, 490);
            this.ans4Button.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ans4Button.Name = "ans4Button";
            this.ans4Button.Size = new System.Drawing.Size(515, 50);
            this.ans4Button.TabIndex = 11;
            this.ans4Button.Text = "answer 4";
            this.ans4Button.UseVisualStyleBackColor = true;
            // 
            // ans3Button
            // 
            this.ans3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans3Button.Location = new System.Drawing.Point(88, 427);
            this.ans3Button.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ans3Button.Name = "ans3Button";
            this.ans3Button.Size = new System.Drawing.Size(515, 50);
            this.ans3Button.TabIndex = 12;
            this.ans3Button.Text = "answer 3";
            this.ans3Button.UseVisualStyleBackColor = true;
            // 
            // ans2Button
            // 
            this.ans2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans2Button.Location = new System.Drawing.Point(88, 364);
            this.ans2Button.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ans2Button.Name = "ans2Button";
            this.ans2Button.Size = new System.Drawing.Size(515, 50);
            this.ans2Button.TabIndex = 13;
            this.ans2Button.Text = "answer 2";
            this.ans2Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(527, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Score 1/5";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ans2Button);
            this.Controls.Add(this.ans3Button);
            this.Controls.Add(this.ans4Button);
            this.Controls.Add(this.ans1Button);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.questionNumLabel);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionNumLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button ans1Button;
        private System.Windows.Forms.Button ans4Button;
        private System.Windows.Forms.Button ans3Button;
        private System.Windows.Forms.Button ans2Button;
        private System.Windows.Forms.Label label1;
    }
}