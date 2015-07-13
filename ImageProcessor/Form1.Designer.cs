namespace ImageProcessor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripDropDownButton();
            this.imagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wholeFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.pnl = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brighterImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkerImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectEdgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.btnAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(496, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagToolStripMenuItem,
            this.wholeFolderToolStripMenuItem});
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(77, 31);
            this.btnOpen.Text = "Open";
            // 
            // imagToolStripMenuItem
            // 
            this.imagToolStripMenuItem.Name = "imagToolStripMenuItem";
            this.imagToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.imagToolStripMenuItem.Text = "Image File ";
            this.imagToolStripMenuItem.Click += new System.EventHandler(this.imagToolStripMenuItem_Click);
            // 
            // wholeFolderToolStripMenuItem
            // 
            this.wholeFolderToolStripMenuItem.Name = "wholeFolderToolStripMenuItem";
            this.wholeFolderToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.wholeFolderToolStripMenuItem.Text = "Whole Folder";
            this.wholeFolderToolStripMenuItem.Click += new System.EventHandler(this.wholeFolderToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Margin = new System.Windows.Forms.Padding(3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 31);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(73, 31);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnl
            // 
            this.pnl.AutoScroll = true;
            this.pnl.BackColor = System.Drawing.Color.Transparent;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl.Location = new System.Drawing.Point(327, 37);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(169, 327);
            this.pnl.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.ContextMenuStrip = this.contextMenuStrip1;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 37);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(327, 327);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayScaleToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.sepiaToneToolStripMenuItem,
            this.brighterImageToolStripMenuItem,
            this.darkerImageToolStripMenuItem,
            this.detectEdgesToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.grayScaleToolStripMenuItem.Text = "Gray Scale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // sepiaToneToolStripMenuItem
            // 
            this.sepiaToneToolStripMenuItem.Name = "sepiaToneToolStripMenuItem";
            this.sepiaToneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sepiaToneToolStripMenuItem.Text = "Sepia Tone";
            this.sepiaToneToolStripMenuItem.Click += new System.EventHandler(this.sepiaToneToolStripMenuItem_Click);
            // 
            // brighterImageToolStripMenuItem
            // 
            this.brighterImageToolStripMenuItem.Name = "brighterImageToolStripMenuItem";
            this.brighterImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.brighterImageToolStripMenuItem.Text = "Brighter Image";
            this.brighterImageToolStripMenuItem.Click += new System.EventHandler(this.brighterImageToolStripMenuItem_Click);
            // 
            // darkerImageToolStripMenuItem
            // 
            this.darkerImageToolStripMenuItem.Name = "darkerImageToolStripMenuItem";
            this.darkerImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.darkerImageToolStripMenuItem.Text = "Darker Image";
            this.darkerImageToolStripMenuItem.Click += new System.EventHandler(this.darkerImageToolStripMenuItem_Click);
            // 
            // detectEdgesToolStripMenuItem
            // 
            this.detectEdgesToolStripMenuItem.Name = "detectEdgesToolStripMenuItem";
            this.detectEdgesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detectEdgesToolStripMenuItem.Text = "Detect Edges";
            this.detectEdgesToolStripMenuItem.Click += new System.EventHandler(this.detectEdgesToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 364);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Easy Pixler ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnOpen;
        private System.Windows.Forms.ToolStripMenuItem imagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wholeFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brighterImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkerImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectEdgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;




    }
}

