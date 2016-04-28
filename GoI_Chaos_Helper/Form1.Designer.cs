namespace GoI_Chaos_Helper
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contTab = new System.Windows.Forms.TabPage();
            this.finalTab = new System.Windows.Forms.TabPage();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.contImage = new System.Windows.Forms.PictureBox();
            this.finalImage = new System.Windows.Forms.PictureBox();
            this.leftSwapPicture = new System.Windows.Forms.PictureBox();
            this.arrowPicture = new System.Windows.Forms.PictureBox();
            this.rightSwapPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contTab.SuspendLayout();
            this.finalTab.SuspendLayout();
            this.historyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSwapPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSwapPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(971, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.cropToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowOpenFile);
            // 
            // cropToolStripMenuItem
            // 
            this.cropToolStripMenuItem.Name = "cropToolStripMenuItem";
            this.cropToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.cropToolStripMenuItem.Text = "Crop";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitApp);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG|*.jpg|All files|*.*";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.leftSwapPicture);
            this.panel1.Controls.Add(this.arrowPicture);
            this.panel1.Controls.Add(this.rightSwapPicture);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 32);
            this.panel1.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.AutoSize = true;
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(0, 0);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 32);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.contTab);
            this.tabControl1.Controls.Add(this.finalTab);
            this.tabControl1.Controls.Add(this.historyTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 374);
            this.tabControl1.TabIndex = 2;
            // 
            // contTab
            // 
            this.contTab.Controls.Add(this.contImage);
            this.contTab.Location = new System.Drawing.Point(26, 4);
            this.contTab.Name = "contTab";
            this.contTab.Padding = new System.Windows.Forms.Padding(3);
            this.contTab.Size = new System.Drawing.Size(941, 366);
            this.contTab.TabIndex = 0;
            this.contTab.Text = "Continuous";
            this.contTab.UseVisualStyleBackColor = true;
            // 
            // finalTab
            // 
            this.finalTab.Controls.Add(this.finalImage);
            this.finalTab.Location = new System.Drawing.Point(26, 4);
            this.finalTab.Name = "finalTab";
            this.finalTab.Padding = new System.Windows.Forms.Padding(3);
            this.finalTab.Size = new System.Drawing.Size(941, 366);
            this.finalTab.TabIndex = 1;
            this.finalTab.Text = "Final";
            this.finalTab.UseVisualStyleBackColor = true;
            // 
            // historyTab
            // 
            this.historyTab.Controls.Add(this.tableLayoutPanel1);
            this.historyTab.Location = new System.Drawing.Point(26, 4);
            this.historyTab.Name = "historyTab";
            this.historyTab.Size = new System.Drawing.Size(941, 366);
            this.historyTab.TabIndex = 2;
            this.historyTab.Text = "History";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // contImage
            // 
            this.contImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contImage.Location = new System.Drawing.Point(3, 3);
            this.contImage.Name = "contImage";
            this.contImage.Size = new System.Drawing.Size(935, 360);
            this.contImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.contImage.TabIndex = 0;
            this.contImage.TabStop = false;
            // 
            // finalImage
            // 
            this.finalImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalImage.Location = new System.Drawing.Point(3, 3);
            this.finalImage.Name = "finalImage";
            this.finalImage.Size = new System.Drawing.Size(935, 360);
            this.finalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.finalImage.TabIndex = 0;
            this.finalImage.TabStop = false;
            // 
            // leftSwapPicture
            // 
            this.leftSwapPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.leftSwapPicture.Location = new System.Drawing.Point(381, 0);
            this.leftSwapPicture.Name = "leftSwapPicture";
            this.leftSwapPicture.Size = new System.Drawing.Size(247, 32);
            this.leftSwapPicture.TabIndex = 3;
            this.leftSwapPicture.TabStop = false;
            // 
            // arrowPicture
            // 
            this.arrowPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.arrowPicture.Image = global::GoI_Chaos_Helper.Properties.Resources.Arrow;
            this.arrowPicture.Location = new System.Drawing.Point(628, 0);
            this.arrowPicture.Name = "arrowPicture";
            this.arrowPicture.Size = new System.Drawing.Size(96, 32);
            this.arrowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowPicture.TabIndex = 2;
            this.arrowPicture.TabStop = false;
            // 
            // rightSwapPicture
            // 
            this.rightSwapPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightSwapPicture.Location = new System.Drawing.Point(724, 0);
            this.rightSwapPicture.Name = "rightSwapPicture";
            this.rightSwapPicture.Size = new System.Drawing.Size(247, 32);
            this.rightSwapPicture.TabIndex = 1;
            this.rightSwapPicture.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(81, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(413, 32);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(41, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1st";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoI_Chaos_Helper.Properties.Resources.WheelIcon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 419F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(500, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(438, 32);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 430);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.contTab.ResumeLayout(false);
            this.contTab.PerformLayout();
            this.finalTab.ResumeLayout(false);
            this.finalTab.PerformLayout();
            this.historyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSwapPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSwapPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem cropToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox leftSwapPicture;
        private System.Windows.Forms.PictureBox arrowPicture;
        private System.Windows.Forms.PictureBox rightSwapPicture;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage contTab;
        private System.Windows.Forms.TabPage finalTab;
        private System.Windows.Forms.PictureBox contImage;
        private System.Windows.Forms.PictureBox finalImage;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

