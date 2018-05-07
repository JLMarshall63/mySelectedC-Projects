namespace CircleLinePictureTask
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxV2 = new System.Windows.Forms.TextBox();
            this.textBoxV1 = new System.Windows.Forms.TextBox();
            this.bttnStartLineCircle = new System.Windows.Forms.Button();
            this.richTextBoxCircles = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLines = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxCircles = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircles)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(71, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "V2 - Number of Circles ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(71, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "V1 - Number of Lines";
            // 
            // textBoxV2
            // 
            this.textBoxV2.Location = new System.Drawing.Point(276, 518);
            this.textBoxV2.Name = "textBoxV2";
            this.textBoxV2.Size = new System.Drawing.Size(137, 20);
            this.textBoxV2.TabIndex = 17;
            // 
            // textBoxV1
            // 
            this.textBoxV1.Location = new System.Drawing.Point(276, 457);
            this.textBoxV1.Name = "textBoxV1";
            this.textBoxV1.Size = new System.Drawing.Size(137, 20);
            this.textBoxV1.TabIndex = 16;
            // 
            // bttnStartLineCircle
            // 
            this.bttnStartLineCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bttnStartLineCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnStartLineCircle.ForeColor = System.Drawing.Color.White;
            this.bttnStartLineCircle.Location = new System.Drawing.Point(276, 368);
            this.bttnStartLineCircle.Name = "bttnStartLineCircle";
            this.bttnStartLineCircle.Size = new System.Drawing.Size(137, 83);
            this.bttnStartLineCircle.TabIndex = 18;
            this.bttnStartLineCircle.Text = "Start Line and Circle Tasks";
            this.bttnStartLineCircle.UseVisualStyleBackColor = false;
            this.bttnStartLineCircle.Click += new System.EventHandler(this.bttnStartLineCircle_Click_1);
            // 
            // richTextBoxCircles
            // 
            this.richTextBoxCircles.Location = new System.Drawing.Point(447, 317);
            this.richTextBoxCircles.Name = "richTextBoxCircles";
            this.richTextBoxCircles.Size = new System.Drawing.Size(226, 134);
            this.richTextBoxCircles.TabIndex = 20;
            this.richTextBoxCircles.Text = "";
            // 
            // richTextBoxLines
            // 
            this.richTextBoxLines.Location = new System.Drawing.Point(13, 317);
            this.richTextBoxLines.Name = "richTextBoxLines";
            this.richTextBoxLines.Size = new System.Drawing.Size(226, 134);
            this.richTextBoxLines.TabIndex = 19;
            this.richTextBoxLines.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(94, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Lines";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(525, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Circles";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxCircles
            // 
            this.pictureBoxCircles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxCircles.Image = global::CircleLinePictureTask.Properties.Resources.Circle1;
            this.pictureBoxCircles.InitialImage = null;
            this.pictureBoxCircles.Location = new System.Drawing.Point(417, 14);
            this.pictureBoxCircles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxCircles.Name = "pictureBoxCircles";
            this.pictureBoxCircles.Size = new System.Drawing.Size(256, 242);
            this.pictureBoxCircles.TabIndex = 7;
            this.pictureBoxCircles.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 242);
            this.panel1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(700, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxCircles);
            this.Controls.Add(this.richTextBoxLines);
            this.Controls.Add(this.bttnStartLineCircle);
            this.Controls.Add(this.textBoxV2);
            this.Controls.Add(this.textBoxV1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCircles);
            this.Name = "Form1";
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCircles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxV2;
        private System.Windows.Forms.TextBox textBoxV1;
        private System.Windows.Forms.Button bttnStartLineCircle;
        private System.Windows.Forms.RichTextBox richTextBoxCircles;
        private System.Windows.Forms.RichTextBox richTextBoxLines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}

