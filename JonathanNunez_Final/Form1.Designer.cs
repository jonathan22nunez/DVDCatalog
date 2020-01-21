namespace JonathanNunez_Final
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvdsGroup = new System.Windows.Forms.GroupBox();
            this.dvdLV = new System.Windows.Forms.ListView();
            this.largeIcons = new System.Windows.Forms.ImageList(this.components);
            this.smallIcons = new System.Windows.Forms.ImageList(this.components);
            this.dvdDetailsGroup = new System.Windows.Forms.GroupBox();
            this.saveToSQLBtn = new System.Windows.Forms.Button();
            this.yearOfReleaseNum = new System.Windows.Forms.NumericUpDown();
            this.priceNum = new System.Windows.Forms.NumericUpDown();
            this.priceLbl = new System.Windows.Forms.Label();
            this.releaseDateLbl = new System.Windows.Forms.Label();
            this.ratingLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.ratingTxtBx = new System.Windows.Forms.TextBox();
            this.titleTxtBx = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.dvdsGroup.SuspendLayout();
            this.dvdDetailsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearOfReleaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitFileMenuOption});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitFileMenuOption
            // 
            this.exitFileMenuOption.Name = "exitFileMenuOption";
            this.exitFileMenuOption.ShortcutKeyDisplayString = "CTRL+Q";
            this.exitFileMenuOption.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitFileMenuOption.Size = new System.Drawing.Size(268, 38);
            this.exitFileMenuOption.Text = "Exit";
            this.exitFileMenuOption.Click += new System.EventHandler(this.exitFileMenuOption_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconsToolStripMenuItem,
            this.smallIconsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(78, 38);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // largeIconsToolStripMenuItem
            // 
            this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            this.largeIconsToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.largeIconsToolStripMenuItem.Text = "Large Icons";
            this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.largeIconsToolStripMenuItem_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.smallIconsToolStripMenuItem.Text = "Small Icons";
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.smallIconsToolStripMenuItem_Click);
            // 
            // dvdsGroup
            // 
            this.dvdsGroup.Controls.Add(this.dvdLV);
            this.dvdsGroup.Location = new System.Drawing.Point(0, 43);
            this.dvdsGroup.Name = "dvdsGroup";
            this.dvdsGroup.Size = new System.Drawing.Size(864, 633);
            this.dvdsGroup.TabIndex = 1;
            this.dvdsGroup.TabStop = false;
            this.dvdsGroup.Text = "DVDs ";
            // 
            // dvdLV
            // 
            this.dvdLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvdLV.LargeImageList = this.largeIcons;
            this.dvdLV.Location = new System.Drawing.Point(3, 27);
            this.dvdLV.MultiSelect = false;
            this.dvdLV.Name = "dvdLV";
            this.dvdLV.Size = new System.Drawing.Size(858, 603);
            this.dvdLV.SmallImageList = this.smallIcons;
            this.dvdLV.TabIndex = 0;
            this.dvdLV.UseCompatibleStateImageBehavior = false;
            this.dvdLV.DoubleClick += new System.EventHandler(this.dvdLV_DoubleClick);
            // 
            // largeIcons
            // 
            this.largeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeIcons.ImageStream")));
            this.largeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.largeIcons.Images.SetKeyName(0, "dvd.png");
            // 
            // smallIcons
            // 
            this.smallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallIcons.ImageStream")));
            this.smallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.smallIcons.Images.SetKeyName(0, "smDVD.png");
            // 
            // dvdDetailsGroup
            // 
            this.dvdDetailsGroup.Controls.Add(this.saveToSQLBtn);
            this.dvdDetailsGroup.Controls.Add(this.yearOfReleaseNum);
            this.dvdDetailsGroup.Controls.Add(this.priceNum);
            this.dvdDetailsGroup.Controls.Add(this.priceLbl);
            this.dvdDetailsGroup.Controls.Add(this.releaseDateLbl);
            this.dvdDetailsGroup.Controls.Add(this.ratingLbl);
            this.dvdDetailsGroup.Controls.Add(this.titleLbl);
            this.dvdDetailsGroup.Controls.Add(this.ratingTxtBx);
            this.dvdDetailsGroup.Controls.Add(this.titleTxtBx);
            this.dvdDetailsGroup.Location = new System.Drawing.Point(12, 682);
            this.dvdDetailsGroup.Name = "dvdDetailsGroup";
            this.dvdDetailsGroup.Size = new System.Drawing.Size(840, 229);
            this.dvdDetailsGroup.TabIndex = 2;
            this.dvdDetailsGroup.TabStop = false;
            this.dvdDetailsGroup.Text = "DVD Details";
            // 
            // saveToSQLBtn
            // 
            this.saveToSQLBtn.AutoSize = true;
            this.saveToSQLBtn.Location = new System.Drawing.Point(671, 61);
            this.saveToSQLBtn.Name = "saveToSQLBtn";
            this.saveToSQLBtn.Size = new System.Drawing.Size(133, 129);
            this.saveToSQLBtn.TabIndex = 10;
            this.saveToSQLBtn.Text = "Save\r\nto\r\nSQL Server\r\n";
            this.saveToSQLBtn.UseVisualStyleBackColor = true;
            this.saveToSQLBtn.Click += new System.EventHandler(this.saveToSQLBtn_Click);
            // 
            // yearOfReleaseNum
            // 
            this.yearOfReleaseNum.Location = new System.Drawing.Point(487, 61);
            this.yearOfReleaseNum.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearOfReleaseNum.Name = "yearOfReleaseNum";
            this.yearOfReleaseNum.Size = new System.Drawing.Size(120, 31);
            this.yearOfReleaseNum.TabIndex = 9;
            // 
            // priceNum
            // 
            this.priceNum.DecimalPlaces = 2;
            this.priceNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceNum.Location = new System.Drawing.Point(487, 170);
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(120, 31);
            this.priceNum.TabIndex = 8;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(329, 170);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(61, 25);
            this.priceLbl.TabIndex = 7;
            this.priceLbl.Text = "Price";
            // 
            // releaseDateLbl
            // 
            this.releaseDateLbl.AutoSize = true;
            this.releaseDateLbl.Location = new System.Drawing.Point(329, 67);
            this.releaseDateLbl.Name = "releaseDateLbl";
            this.releaseDateLbl.Size = new System.Drawing.Size(142, 25);
            this.releaseDateLbl.TabIndex = 6;
            this.releaseDateLbl.Text = "Release Date";
            // 
            // ratingLbl
            // 
            this.ratingLbl.AutoSize = true;
            this.ratingLbl.Location = new System.Drawing.Point(67, 170);
            this.ratingLbl.Name = "ratingLbl";
            this.ratingLbl.Size = new System.Drawing.Size(74, 25);
            this.ratingLbl.TabIndex = 5;
            this.ratingLbl.Text = "Rating";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(67, 70);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(53, 25);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "Title";
            // 
            // ratingTxtBx
            // 
            this.ratingTxtBx.Location = new System.Drawing.Point(175, 167);
            this.ratingTxtBx.Name = "ratingTxtBx";
            this.ratingTxtBx.Size = new System.Drawing.Size(100, 31);
            this.ratingTxtBx.TabIndex = 1;
            // 
            // titleTxtBx
            // 
            this.titleTxtBx.Location = new System.Drawing.Point(175, 67);
            this.titleTxtBx.Name = "titleTxtBx";
            this.titleTxtBx.Size = new System.Drawing.Size(100, 31);
            this.titleTxtBx.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 923);
            this.Controls.Add(this.dvdDetailsGroup);
            this.Controls.Add(this.dvdsGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.dvdsGroup.ResumeLayout(false);
            this.dvdDetailsGroup.ResumeLayout(false);
            this.dvdDetailsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearOfReleaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem;
        private System.Windows.Forms.GroupBox dvdsGroup;
        private System.Windows.Forms.ListView dvdLV;
        private System.Windows.Forms.ImageList largeIcons;
        private System.Windows.Forms.ImageList smallIcons;
        private System.Windows.Forms.GroupBox dvdDetailsGroup;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label releaseDateLbl;
        private System.Windows.Forms.Label ratingLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox ratingTxtBx;
        private System.Windows.Forms.TextBox titleTxtBx;
        private System.Windows.Forms.NumericUpDown priceNum;
        private System.Windows.Forms.NumericUpDown yearOfReleaseNum;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenuOption;
        private System.Windows.Forms.Button saveToSQLBtn;
    }
}

