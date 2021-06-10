namespace GUI.Forms.Menu
{
    partial class MyStatus
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
            this.triviaLabel = new System.Windows.Forms.Label();
            this.backMenuButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.avgTimeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numTotalLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numRightLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numGamesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // triviaLabel
            // 
            Initializer.initialTriviaLabel(ref triviaLabel);
            // 
            // backMenuButton
            // 
            Initializer.initialBackButton(ref this.backMenuButton);
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.51122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.48877F));
            this.tableLayoutPanel1.Controls.Add(this.avgTimeLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numTotalLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numRightLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numGamesLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 220);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 285);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // avgTimeLabel
            // 
            this.avgTimeLabel.AutoSize = true;
            this.avgTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avgTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgTimeLabel.Location = new System.Drawing.Point(446, 213);
            this.avgTimeLabel.Name = "avgTimeLabel";
            this.avgTimeLabel.Size = new System.Drawing.Size(130, 72);
            this.avgTimeLabel.TabIndex = 7;
            this.avgTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(437, 72);
            this.label8.TabIndex = 6;
            this.label8.Text = "AVARAGE ANSWER TIME";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numTotalLabel
            // 
            this.numTotalLabel.AutoSize = true;
            this.numTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numTotalLabel.Location = new System.Drawing.Point(446, 142);
            this.numTotalLabel.Name = "numTotalLabel";
            this.numTotalLabel.Size = new System.Drawing.Size(130, 71);
            this.numTotalLabel.TabIndex = 5;
            this.numTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(437, 71);
            this.label6.TabIndex = 4;
            this.label6.Text = "TOTAL GAMES";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numRightLabel
            // 
            this.numRightLabel.AutoSize = true;
            this.numRightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numRightLabel.Location = new System.Drawing.Point(446, 71);
            this.numRightLabel.Name = "numRightLabel";
            this.numRightLabel.Size = new System.Drawing.Size(130, 71);
            this.numRightLabel.TabIndex = 3;
            this.numRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 71);
            this.label4.TabIndex = 2;
            this.label4.Text = "RIGHT ANSWERS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 71);
            this.label3.TabIndex = 1;
            this.label3.Text = "PLAYED GAMES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numGamesLabel
            // 
            this.numGamesLabel.AutoSize = true;
            this.numGamesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numGamesLabel.Location = new System.Drawing.Point(446, 0);
            this.numGamesLabel.Name = "numGamesLabel";
            this.numGamesLabel.Size = new System.Drawing.Size(130, 71);
            this.numGamesLabel.TabIndex = 0;
            this.numGamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.triviaLabel);
            this.Name = "MyStatus";
            this.Text = "MyStatus";
            this.Load += new System.EventHandler(this.MyStatus_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label triviaLabel;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label avgTimeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label numTotalLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label numRightLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numGamesLabel;
    }
}