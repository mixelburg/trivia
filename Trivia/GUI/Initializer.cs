using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
namespace GUI
{
    class Initializer
    {
        /// <summary>
        /// Function initial the back to menu button
        /// </summary>
        /// <param ref to the button to init="backButton"></param>
        public static void initialBackButton(ref Button backButton) {
            backButton.AccessibleName = "";
            backButton.BackColor = System.Drawing.SystemColors.Control;
            backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            backButton.Location = new System.Drawing.Point(558, 0);
            backButton.Name = "backMenuButton";
            backButton.Size = new System.Drawing.Size(124, 46);
            backButton.TabIndex = 26;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = false;
        }
        public static void initialUnamePic(ref PictureBox pictureBox, ref ComponentResourceManager resources) {
            pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUname.Image")));
            pictureBox.Location = new System.Drawing.Point(49, 110);
            pictureBox.Margin = new System.Windows.Forms.Padding(2);
            pictureBox.Name = "pictureBoxUname";
            pictureBox.Size = new System.Drawing.Size(48, 52);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 17;
            pictureBox.TabStop = false;
        }
        public static void initialPassPic(ref PictureBox pictureBox, ref ComponentResourceManager resources) {
            pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPass.Image")));
            pictureBox.Location = new System.Drawing.Point(49, 173);
            pictureBox.Margin = new System.Windows.Forms.Padding(2);
            pictureBox.Name = "pictureBoxPass";
            pictureBox.Size = new System.Drawing.Size(48, 52);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 18;
            pictureBox.TabStop = false;
        }
        public static void initialUnameTextBox(ref TextBox textBox) {
            textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox.Location = new System.Drawing.Point(101, 110);
            textBox.Margin = new System.Windows.Forms.Padding(2);
            textBox.Name = "textBoxUname";
            textBox.Size = new System.Drawing.Size(224, 53);
            textBox.TabIndex = 15;
            textBox.Text = "Ivan";
        }
        public static void initialPassTextBox(ref TextBox textBox) {
            textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox.Location = new System.Drawing.Point(101, 173);
            textBox.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            textBox.Name = "textBoxPass";
            textBox.Size = new System.Drawing.Size(224, 53);
            textBox.TabIndex = 16;
            textBox.Text = "1111";
            textBox.UseSystemPasswordChar = true;
        }
        public static void initialTriviaLabel(ref Label label) {
            label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            label.Dock = System.Windows.Forms.DockStyle.Top;
            label.Font = new System.Drawing.Font("Mongolian Baiti", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); label.Location = new System.Drawing.Point(0, 0);
            label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label.Name = "label1";
            label.Size = new System.Drawing.Size(512, 54);
            label.TabIndex = 5;
            label.Text = "The Trivia";
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        
    }
}
