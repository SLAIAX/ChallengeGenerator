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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.contentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbxFontSize = new System.Windows.Forms.TextBox();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChallenge1
            // 
            this.lblChallenge1.AutoSize = true;
            this.lblChallenge1.BackColor = System.Drawing.SystemColors.Control;
            this.lblChallenge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblChallenge1.Location = new System.Drawing.Point(4, 202);
            this.lblChallenge1.Name = "lblChallenge1";
            this.lblChallenge1.Size = new System.Drawing.Size(243, 46);
            this.lblChallenge1.TabIndex = 1;
            this.lblChallenge1.Text = "Challenge 1:";
            // 
            // lblChallenge2
            // 
            this.lblChallenge2.AutoSize = true;
            this.lblChallenge2.BackColor = System.Drawing.SystemColors.Control;
            this.lblChallenge2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChallenge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblChallenge2.Location = new System.Drawing.Point(4, 249);
            this.lblChallenge2.Name = "lblChallenge2";
            this.lblChallenge2.Size = new System.Drawing.Size(1050, 46);
            this.lblChallenge2.TabIndex = 2;
            this.lblChallenge2.Text = "Challenge 2:";
            // 
            // lblChallenge3
            // 
            this.lblChallenge3.AutoSize = true;
            this.lblChallenge3.BackColor = System.Drawing.SystemColors.Control;
            this.lblChallenge3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChallenge3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblChallenge3.Location = new System.Drawing.Point(4, 296);
            this.lblChallenge3.Name = "lblChallenge3";
            this.lblChallenge3.Size = new System.Drawing.Size(1050, 46);
            this.lblChallenge3.TabIndex = 3;
            this.lblChallenge3.Text = "Challenge 3: ";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(3, 256);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(188, 79);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Challenges!";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cmbLevel
            // 
            this.cmbLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "Level 1",
            "Level 2 (Sensors)"});
            this.cmbLevel.Location = new System.Drawing.Point(3, 203);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(188, 21);
            this.cmbLevel.TabIndex = 8;
            // 
            // contentPanel
            // 
            this.contentPanel.AutoSize = true;
            this.contentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.contentPanel.ColumnCount = 1;
            this.contentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentPanel.Controls.Add(this.lblChallenge1, 0, 1);
            this.contentPanel.Controls.Add(this.lblChallenge2, 0, 2);
            this.contentPanel.Controls.Add(this.lblChallenge3, 0, 3);
            this.contentPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.contentPanel.Location = new System.Drawing.Point(3, 3);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.RowCount = 4;
            this.contentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.contentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentPanel.Size = new System.Drawing.Size(1058, 343);
            this.contentPanel.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(0, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1050, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.contentPanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1264, 349);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.cmbLevel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnGenerate, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbxFontSize, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1067, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(194, 338);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // tbxFontSize
            // 
            this.tbxFontSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFontSize.Location = new System.Drawing.Point(3, 230);
            this.tbxFontSize.Name = "tbxFontSize";
            this.tbxFontSize.Size = new System.Drawing.Size(188, 20);
            this.tbxFontSize.TabIndex = 10;
            this.tbxFontSize.TextChanged += new System.EventHandler(this.tbxFontSize_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "B4K Challenge Generator V1.03";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChallenge1;
        private System.Windows.Forms.Label lblChallenge2;
        private System.Windows.Forms.Label lblChallenge3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.TableLayoutPanel contentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbxFontSize;
    }
}

