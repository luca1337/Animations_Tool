namespace WindowsFormsApp1
{
    partial class AnimationsTool
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Show = new System.Windows.Forms.Button();
            this.PanelImage = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Create = new System.Windows.Forms.Button();
            this.FrameWidth = new System.Windows.Forms.Label();
            this.FrameHeight = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.FrameDuration = new System.Windows.Forms.Label();
            this.Indexes = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.AnimationPanel = new System.Windows.Forms.Panel();
            this.TilesPerRaw = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(290, 478);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(170, 26);
            this.Show.TabIndex = 1;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            // 
            // PanelImage
            // 
            this.PanelImage.Location = new System.Drawing.Point(41, 55);
            this.PanelImage.Name = "PanelImage";
            this.PanelImage.Size = new System.Drawing.Size(714, 286);
            this.PanelImage.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(291, 539);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(170, 26);
            this.Create.TabIndex = 5;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // FrameWidth
            // 
            this.FrameWidth.AutoSize = true;
            this.FrameWidth.Location = new System.Drawing.Point(287, 373);
            this.FrameWidth.Name = "FrameWidth";
            this.FrameWidth.Size = new System.Drawing.Size(67, 13);
            this.FrameWidth.TabIndex = 6;
            this.FrameWidth.Text = "Frame Width";
            // 
            // FrameHeight
            // 
            this.FrameHeight.AutoSize = true;
            this.FrameHeight.Location = new System.Drawing.Point(287, 401);
            this.FrameHeight.Name = "FrameHeight";
            this.FrameHeight.Size = new System.Drawing.Size(70, 13);
            this.FrameHeight.TabIndex = 7;
            this.FrameHeight.Text = "Frame Height";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(381, 398);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(381, 425);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 20);
            this.textBox3.TabIndex = 10;
            // 
            // FrameDuration
            // 
            this.FrameDuration.AutoSize = true;
            this.FrameDuration.Location = new System.Drawing.Point(287, 428);
            this.FrameDuration.Name = "FrameDuration";
            this.FrameDuration.Size = new System.Drawing.Size(79, 13);
            this.FrameDuration.TabIndex = 11;
            this.FrameDuration.Text = "Frame Duration";
            // 
            // Indexes
            // 
            this.Indexes.AutoSize = true;
            this.Indexes.Location = new System.Drawing.Point(287, 455);
            this.Indexes.Name = "Indexes";
            this.Indexes.Size = new System.Drawing.Size(44, 13);
            this.Indexes.TabIndex = 12;
            this.Indexes.Text = "Indexes";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(381, 452);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(79, 20);
            this.textBox4.TabIndex = 13;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(291, 510);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(169, 23);
            this.Stop.TabIndex = 14;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // AnimationPanel
            // 
            this.AnimationPanel.Location = new System.Drawing.Point(41, 373);
            this.AnimationPanel.Name = "AnimationPanel";
            this.AnimationPanel.Size = new System.Drawing.Size(229, 192);
            this.AnimationPanel.TabIndex = 15;
            this.AnimationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AnimationPanel_Paint_1);
            // 
            // TilesPerRaw
            // 
            this.TilesPerRaw.AutoSize = true;
            this.TilesPerRaw.Location = new System.Drawing.Point(479, 373);
            this.TilesPerRaw.Name = "TilesPerRaw";
            this.TilesPerRaw.Size = new System.Drawing.Size(41, 13);
            this.TilesPerRaw.TabIndex = 16;
            this.TilesPerRaw.Text = "Frames";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(526, 370);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(80, 20);
            this.textBox5.TabIndex = 17;
            // 
            // AnimationsTool
            // 
            this.AccessibleName = "Form";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 594);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.TilesPerRaw);
            this.Controls.Add(this.AnimationPanel);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Indexes);
            this.Controls.Add(this.FrameDuration);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FrameHeight);
            this.Controls.Add(this.FrameWidth);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.PanelImage);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnimationsTool";
            this.Text = "Animations Tools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Panel PanelImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label FrameWidth;
        private System.Windows.Forms.Label FrameHeight;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label FrameDuration;
        private System.Windows.Forms.Label Indexes;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Panel AnimationPanel;
        private System.Windows.Forms.Label TilesPerRaw;
        private System.Windows.Forms.TextBox textBox5;
    }
}

