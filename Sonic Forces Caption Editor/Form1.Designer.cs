namespace Sonic_Forces_Caption_Editor
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.talkingBox = new System.Windows.Forms.TextBox();
            this.talkingLabel = new System.Windows.Forms.Label();
            this.delayBox = new System.Windows.Forms.TextBox();
            this.delayLabel = new System.Windows.Forms.Label();
            this.firstCharBox = new System.Windows.Forms.ComboBox();
            this.firstCharLabel = new System.Windows.Forms.Label();
            this.firstCharAnimBox = new System.Windows.Forms.ComboBox();
            this.firstCharAnimLabel = new System.Windows.Forms.Label();
            this.secondCharAnimBox = new System.Windows.Forms.ComboBox();
            this.secondCharAnimLabel = new System.Windows.Forms.Label();
            this.secondCharBox = new System.Windows.Forms.ComboBox();
            this.secondCharLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineInfoLabel = new System.Windows.Forms.Label();
            this.previousLineButton = new System.Windows.Forms.Button();
            this.nextLineButton = new System.Windows.Forms.Button();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.cNVRSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.episodeShadowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(77, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Caption Name:";
            // 
            // nameBox
            // 
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(95, 27);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(198, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 96);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(73, 13);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Caption Type:";
            // 
            // typeBox
            // 
            this.typeBox.Enabled = false;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Subtitle",
            "Radio",
            "SoundEffect"});
            this.typeBox.Location = new System.Drawing.Point(95, 93);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(198, 21);
            this.typeBox.TabIndex = 3;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // talkingBox
            // 
            this.talkingBox.Enabled = false;
            this.talkingBox.Location = new System.Drawing.Point(112, 118);
            this.talkingBox.Name = "talkingBox";
            this.talkingBox.Size = new System.Drawing.Size(181, 20);
            this.talkingBox.TabIndex = 5;
            this.talkingBox.TextChanged += new System.EventHandler(this.TalkingBox_TextChanged);
            // 
            // talkingLabel
            // 
            this.talkingLabel.AutoSize = true;
            this.talkingLabel.Location = new System.Drawing.Point(12, 121);
            this.talkingLabel.Name = "talkingLabel";
            this.talkingLabel.Size = new System.Drawing.Size(94, 13);
            this.talkingLabel.TabIndex = 4;
            this.talkingLabel.Text = "Talking Character:";
            // 
            // delayBox
            // 
            this.delayBox.Enabled = false;
            this.delayBox.Location = new System.Drawing.Point(118, 144);
            this.delayBox.Name = "delayBox";
            this.delayBox.Size = new System.Drawing.Size(175, 20);
            this.delayBox.TabIndex = 7;
            this.delayBox.TextChanged += new System.EventHandler(this.DelayBox_TextChanged);
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(12, 147);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(100, 13);
            this.delayLabel.TabIndex = 6;
            this.delayLabel.Text = "Delay after Caption:";
            // 
            // firstCharBox
            // 
            this.firstCharBox.Enabled = false;
            this.firstCharBox.FormattingEnabled = true;
            this.firstCharBox.Items.AddRange(new object[] {
            "Amy",
            "Charmy",
            "Eggman",
            "Espio",
            "Knuckles",
            "Rouge",
            "Shadow",
            "Silver",
            "Sonic",
            "Tails",
            "Vector",
            "Soldier",
            "MustacheSoldier",
            "CustomHero",
            "ClassicSonic",
            "Infinite",
            "Omega",
            "None"});
            this.firstCharBox.Location = new System.Drawing.Point(96, 170);
            this.firstCharBox.Name = "firstCharBox";
            this.firstCharBox.Size = new System.Drawing.Size(197, 21);
            this.firstCharBox.TabIndex = 9;
            this.firstCharBox.SelectedIndexChanged += new System.EventHandler(this.FirstCharBox_SelectedIndexChanged);
            // 
            // firstCharLabel
            // 
            this.firstCharLabel.AutoSize = true;
            this.firstCharLabel.Location = new System.Drawing.Point(12, 173);
            this.firstCharLabel.Name = "firstCharLabel";
            this.firstCharLabel.Size = new System.Drawing.Size(78, 13);
            this.firstCharLabel.TabIndex = 8;
            this.firstCharLabel.Text = "First Character:";
            // 
            // firstCharAnimBox
            // 
            this.firstCharAnimBox.Enabled = false;
            this.firstCharAnimBox.FormattingEnabled = true;
            this.firstCharAnimBox.Items.AddRange(new object[] {
            "AngryTalk",
            "BaseTalk",
            "SadTalk",
            "HappyTalk",
            "SurpriseTalk",
            "AngryIdle",
            "BaseIdle",
            "SadIdle",
            "HappyIdle",
            "SurpriseIdle"});
            this.firstCharAnimBox.Location = new System.Drawing.Point(145, 197);
            this.firstCharAnimBox.Name = "firstCharAnimBox";
            this.firstCharAnimBox.Size = new System.Drawing.Size(148, 21);
            this.firstCharAnimBox.TabIndex = 11;
            this.firstCharAnimBox.SelectedIndexChanged += new System.EventHandler(this.FirstCharAnimBox_SelectedIndexChanged);
            // 
            // firstCharAnimLabel
            // 
            this.firstCharAnimLabel.AutoSize = true;
            this.firstCharAnimLabel.Location = new System.Drawing.Point(12, 200);
            this.firstCharAnimLabel.Name = "firstCharAnimLabel";
            this.firstCharAnimLabel.Size = new System.Drawing.Size(127, 13);
            this.firstCharAnimLabel.TabIndex = 10;
            this.firstCharAnimLabel.Text = "First Character Animation:";
            // 
            // secondCharAnimBox
            // 
            this.secondCharAnimBox.Enabled = false;
            this.secondCharAnimBox.FormattingEnabled = true;
            this.secondCharAnimBox.Items.AddRange(new object[] {
            "AngryTalk",
            "BaseTalk",
            "SadTalk",
            "HappyTalk",
            "SurpriseTalk",
            "AngryIdle",
            "BaseIdle",
            "SadIdle",
            "HappyIdle",
            "SurpriseIdle"});
            this.secondCharAnimBox.Location = new System.Drawing.Point(163, 251);
            this.secondCharAnimBox.Name = "secondCharAnimBox";
            this.secondCharAnimBox.Size = new System.Drawing.Size(130, 21);
            this.secondCharAnimBox.TabIndex = 15;
            this.secondCharAnimBox.SelectedIndexChanged += new System.EventHandler(this.SecondCharAnimBox_SelectedIndexChanged);
            // 
            // secondCharAnimLabel
            // 
            this.secondCharAnimLabel.AutoSize = true;
            this.secondCharAnimLabel.Location = new System.Drawing.Point(12, 254);
            this.secondCharAnimLabel.Name = "secondCharAnimLabel";
            this.secondCharAnimLabel.Size = new System.Drawing.Size(145, 13);
            this.secondCharAnimLabel.TabIndex = 14;
            this.secondCharAnimLabel.Text = "Second Character Animation:";
            // 
            // secondCharBox
            // 
            this.secondCharBox.Enabled = false;
            this.secondCharBox.FormattingEnabled = true;
            this.secondCharBox.Items.AddRange(new object[] {
            "Amy",
            "Charmy",
            "Eggman",
            "Espio",
            "Knuckles",
            "Rouge",
            "Shadow",
            "Silver",
            "Sonic",
            "Tails",
            "Vector",
            "Soldier",
            "MustacheSoldier",
            "CustomHero",
            "ClassicSonic",
            "Infinite",
            "Omega",
            "None"});
            this.secondCharBox.Location = new System.Drawing.Point(114, 224);
            this.secondCharBox.Name = "secondCharBox";
            this.secondCharBox.Size = new System.Drawing.Size(179, 21);
            this.secondCharBox.TabIndex = 13;
            this.secondCharBox.SelectedIndexChanged += new System.EventHandler(this.SecondCharBox_SelectedIndexChanged);
            // 
            // secondCharLabel
            // 
            this.secondCharLabel.AutoSize = true;
            this.secondCharLabel.Location = new System.Drawing.Point(12, 227);
            this.secondCharLabel.Name = "secondCharLabel";
            this.secondCharLabel.Size = new System.Drawing.Size(96, 13);
            this.secondCharLabel.TabIndex = 12;
            this.secondCharLabel.Text = "Second Character:";
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(196, 387);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(97, 23);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = "Next Caption";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Enabled = false;
            this.previousButton.Location = new System.Drawing.Point(17, 387);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(97, 23);
            this.previousButton.TabIndex = 17;
            this.previousButton.Text = "Previous Caption";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Location = new System.Drawing.Point(17, 344);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(278, 40);
            this.infoLabel.TabIndex = 18;
            this.infoLabel.Text = "No Caption RFL Loaded";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cNVRSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(305, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "RFL";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // lineInfoLabel
            // 
            this.lineInfoLabel.Location = new System.Drawing.Point(15, 275);
            this.lineInfoLabel.Name = "lineInfoLabel";
            this.lineInfoLabel.Size = new System.Drawing.Size(278, 40);
            this.lineInfoLabel.TabIndex = 22;
            this.lineInfoLabel.Text = "No Caption RFL Loaded";
            this.lineInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // previousLineButton
            // 
            this.previousLineButton.Enabled = false;
            this.previousLineButton.Location = new System.Drawing.Point(15, 318);
            this.previousLineButton.Name = "previousLineButton";
            this.previousLineButton.Size = new System.Drawing.Size(97, 23);
            this.previousLineButton.TabIndex = 21;
            this.previousLineButton.Text = "Previous Line";
            this.previousLineButton.UseVisualStyleBackColor = true;
            this.previousLineButton.Click += new System.EventHandler(this.PreviousLineButton_Click);
            // 
            // nextLineButton
            // 
            this.nextLineButton.Enabled = false;
            this.nextLineButton.Location = new System.Drawing.Point(196, 318);
            this.nextLineButton.Name = "nextLineButton";
            this.nextLineButton.Size = new System.Drawing.Size(97, 23);
            this.nextLineButton.TabIndex = 20;
            this.nextLineButton.Text = "Next Line";
            this.nextLineButton.UseVisualStyleBackColor = true;
            this.nextLineButton.Click += new System.EventHandler(this.NextLineButton_Click);
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.Location = new System.Drawing.Point(17, 50);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(278, 40);
            this.subtitleLabel.TabIndex = 23;
            this.subtitleLabel.Text = "No Text CNVRS Loaded";
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cNVRSToolStripMenuItem
            // 
            this.cNVRSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseGameToolStripMenuItem,
            this.episodeShadowToolStripMenuItem});
            this.cNVRSToolStripMenuItem.Name = "cNVRSToolStripMenuItem";
            this.cNVRSToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cNVRSToolStripMenuItem.Text = "CNVRS";
            // 
            // baseGameToolStripMenuItem
            // 
            this.baseGameToolStripMenuItem.Name = "baseGameToolStripMenuItem";
            this.baseGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.baseGameToolStripMenuItem.Text = "Base Game";
            this.baseGameToolStripMenuItem.Click += new System.EventHandler(this.BaseGameToolStripMenuItem_Click);
            // 
            // episodeShadowToolStripMenuItem
            // 
            this.episodeShadowToolStripMenuItem.Name = "episodeShadowToolStripMenuItem";
            this.episodeShadowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.episodeShadowToolStripMenuItem.Text = "Episode Shadow";
            this.episodeShadowToolStripMenuItem.Click += new System.EventHandler(this.EpisodeShadowToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 421);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.lineInfoLabel);
            this.Controls.Add(this.previousLineButton);
            this.Controls.Add(this.nextLineButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.secondCharAnimBox);
            this.Controls.Add(this.secondCharAnimLabel);
            this.Controls.Add(this.secondCharBox);
            this.Controls.Add(this.secondCharLabel);
            this.Controls.Add(this.firstCharAnimBox);
            this.Controls.Add(this.firstCharAnimLabel);
            this.Controls.Add(this.firstCharBox);
            this.Controls.Add(this.firstCharLabel);
            this.Controls.Add(this.delayBox);
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.talkingBox);
            this.Controls.Add(this.talkingLabel);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Caption Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.TextBox talkingBox;
        private System.Windows.Forms.Label talkingLabel;
        private System.Windows.Forms.TextBox delayBox;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.ComboBox firstCharBox;
        private System.Windows.Forms.Label firstCharLabel;
        private System.Windows.Forms.ComboBox firstCharAnimBox;
        private System.Windows.Forms.Label firstCharAnimLabel;
        private System.Windows.Forms.ComboBox secondCharAnimBox;
        private System.Windows.Forms.Label secondCharAnimLabel;
        private System.Windows.Forms.ComboBox secondCharBox;
        private System.Windows.Forms.Label secondCharLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label lineInfoLabel;
        private System.Windows.Forms.Button previousLineButton;
        private System.Windows.Forms.Button nextLineButton;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.ToolStripMenuItem cNVRSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem episodeShadowToolStripMenuItem;
    }
}

