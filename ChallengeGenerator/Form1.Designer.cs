namespace ChallengeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblChallenge1 = new System.Windows.Forms.Label();
            this.lblChallenge2 = new System.Windows.Forms.Label();
            this.lblChallenge3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChallenge1
            // 
            this.lblChallenge1.AutoSize = true;
            this.lblChallenge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblChallenge1.Location = new System.Drawing.Point(12, 152);
            this.lblChallenge1.MaximumSize = new System.Drawing.Size(1250, 1000);
            this.lblChallenge1.Name = "lblChallenge1";
            this.lblChallenge1.Size = new System.Drawing.Size(243, 46);
            this.lblChallenge1.TabIndex = 1;
            this.lblChallenge1.Text = "Challenge 1:";
            // 
            // lblChallenge2
            // 
            this.lblChallenge2.AutoSize = true;
            this.lblChallenge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblChallenge2.Location = new System.Drawing.Point(12, 285);
            this.lblChallenge2.MaximumSize = new System.Drawing.Size(1250, 1000);
            this.lblChallenge2.Name = "lblChallenge2";
            this.lblChallenge2.Size = new System.Drawing.Size(243, 46);
            this.lblChallenge2.TabIndex = 2;
            this.lblChallenge2.Text = "Challenge 2:";
            // 
            // lblChallenge3
            // 
            this.lblChallenge3.AutoSize = true;
            this.lblChallenge3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblChallenge3.Location = new System.Drawing.Point(12, 439);
            this.lblChallenge3.MaximumSize = new System.Drawing.Size(1250, 1000);
            this.lblChallenge3.Name = "lblChallenge3";
            this.lblChallenge3.Size = new System.Drawing.Size(254, 46);
            this.lblChallenge3.TabIndex = 3;
            this.lblChallenge3.Text = "Challenge 3: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1277, 200);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(1101, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(137, 81);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Challenges!";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(940, 580);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 103);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblChallenge3);
            this.Controls.Add(this.lblChallenge2);
            this.Controls.Add(this.lblChallenge1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "B4K Challenge Generator V1.01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChallenge1;
        private System.Windows.Forms.Label lblChallenge2;
        private System.Windows.Forms.Label lblChallenge3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

