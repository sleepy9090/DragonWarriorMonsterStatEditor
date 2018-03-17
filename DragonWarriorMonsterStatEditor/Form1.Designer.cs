namespace DragonWarriorMonsterStatEditor
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOpenRom = new System.Windows.Forms.Button();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.labelFilename = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMonsters = new System.Windows.Forms.ComboBox();
            this.comboBoxStrength = new System.Windows.Forms.ComboBox();
            this.comboBoxAgility = new System.Windows.Forms.ComboBox();
            this.comboBoxMaxHP = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecial1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecial2 = new System.Windows.Forms.ComboBox();
            this.comboBoxSleepResistance = new System.Windows.Forms.ComboBox();
            this.comboBoxStopResistance = new System.Windows.Forms.ComboBox();
            this.comboBoxHurtResistance = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxEvasion = new System.Windows.Forms.ComboBox();
            this.comboBoxExperience = new System.Windows.Forms.ComboBox();
            this.comboBoxMaxGold = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonUpdateMonsterStats = new System.Windows.Forms.Button();
            this.updateMonsterStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openROMToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openROMToolStripMenuItem
            // 
            this.openROMToolStripMenuItem.Name = "openROMToolStripMenuItem";
            this.openROMToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openROMToolStripMenuItem.Text = "&Open ROM";
            this.openROMToolStripMenuItem.Click += new System.EventHandler(this.openROMToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateMonsterStatsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOpenRom);
            this.groupBox2.Controls.Add(this.textBoxFilename);
            this.groupBox2.Controls.Add(this.labelFilename);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 44);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // buttonOpenRom
            // 
            this.buttonOpenRom.Location = new System.Drawing.Point(519, 11);
            this.buttonOpenRom.Name = "buttonOpenRom";
            this.buttonOpenRom.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenRom.TabIndex = 1;
            this.buttonOpenRom.Text = "&Open ROM";
            this.buttonOpenRom.UseVisualStyleBackColor = true;
            this.buttonOpenRom.Click += new System.EventHandler(this.buttonOpenRom_Click);
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(64, 13);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.ReadOnly = true;
            this.textBoxFilename.Size = new System.Drawing.Size(449, 20);
            this.textBoxFilename.TabIndex = 1;
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(6, 16);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(52, 13);
            this.labelFilename.TabIndex = 0;
            this.labelFilename.Text = "Filename:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBoxMaxGold);
            this.groupBox1.Controls.Add(this.comboBoxExperience);
            this.groupBox1.Controls.Add(this.comboBoxEvasion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxHurtResistance);
            this.groupBox1.Controls.Add(this.comboBoxStopResistance);
            this.groupBox1.Controls.Add(this.comboBoxSleepResistance);
            this.groupBox1.Controls.Add(this.comboBoxSpecial2);
            this.groupBox1.Controls.Add(this.comboBoxSpecial1);
            this.groupBox1.Controls.Add(this.comboBoxMaxHP);
            this.groupBox1.Controls.Add(this.comboBoxAgility);
            this.groupBox1.Controls.Add(this.comboBoxStrength);
            this.groupBox1.Controls.Add(this.comboBoxMonsters);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 352);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxMonsters
            // 
            this.comboBoxMonsters.FormattingEnabled = true;
            this.comboBoxMonsters.Location = new System.Drawing.Point(106, 19);
            this.comboBoxMonsters.Name = "comboBoxMonsters";
            this.comboBoxMonsters.Size = new System.Drawing.Size(150, 21);
            this.comboBoxMonsters.TabIndex = 0;
            this.comboBoxMonsters.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonsters_SelectedIndexChanged);
            // 
            // comboBoxStrength
            // 
            this.comboBoxStrength.FormattingEnabled = true;
            this.comboBoxStrength.Location = new System.Drawing.Point(106, 46);
            this.comboBoxStrength.Name = "comboBoxStrength";
            this.comboBoxStrength.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStrength.TabIndex = 1;
            // 
            // comboBoxAgility
            // 
            this.comboBoxAgility.FormattingEnabled = true;
            this.comboBoxAgility.Location = new System.Drawing.Point(106, 73);
            this.comboBoxAgility.Name = "comboBoxAgility";
            this.comboBoxAgility.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAgility.TabIndex = 2;
            // 
            // comboBoxMaxHP
            // 
            this.comboBoxMaxHP.FormattingEnabled = true;
            this.comboBoxMaxHP.Location = new System.Drawing.Point(106, 100);
            this.comboBoxMaxHP.Name = "comboBoxMaxHP";
            this.comboBoxMaxHP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaxHP.TabIndex = 3;
            // 
            // comboBoxSpecial1
            // 
            this.comboBoxSpecial1.FormattingEnabled = true;
            this.comboBoxSpecial1.Location = new System.Drawing.Point(106, 127);
            this.comboBoxSpecial1.Name = "comboBoxSpecial1";
            this.comboBoxSpecial1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecial1.TabIndex = 4;
            // 
            // comboBoxSpecial2
            // 
            this.comboBoxSpecial2.FormattingEnabled = true;
            this.comboBoxSpecial2.Location = new System.Drawing.Point(106, 154);
            this.comboBoxSpecial2.Name = "comboBoxSpecial2";
            this.comboBoxSpecial2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecial2.TabIndex = 5;
            // 
            // comboBoxSleepResistance
            // 
            this.comboBoxSleepResistance.FormattingEnabled = true;
            this.comboBoxSleepResistance.Location = new System.Drawing.Point(106, 181);
            this.comboBoxSleepResistance.Name = "comboBoxSleepResistance";
            this.comboBoxSleepResistance.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSleepResistance.TabIndex = 6;
            // 
            // comboBoxStopResistance
            // 
            this.comboBoxStopResistance.FormattingEnabled = true;
            this.comboBoxStopResistance.Location = new System.Drawing.Point(106, 208);
            this.comboBoxStopResistance.Name = "comboBoxStopResistance";
            this.comboBoxStopResistance.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStopResistance.TabIndex = 7;
            // 
            // comboBoxHurtResistance
            // 
            this.comboBoxHurtResistance.FormattingEnabled = true;
            this.comboBoxHurtResistance.Location = new System.Drawing.Point(106, 235);
            this.comboBoxHurtResistance.Name = "comboBoxHurtResistance";
            this.comboBoxHurtResistance.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHurtResistance.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Monster:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Strength:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Agility:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Max HP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Special 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Special 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sleep Resistance:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Stop Resistance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Hurt Resistance:";
            // 
            // comboBoxEvasion
            // 
            this.comboBoxEvasion.FormattingEnabled = true;
            this.comboBoxEvasion.Location = new System.Drawing.Point(106, 262);
            this.comboBoxEvasion.Name = "comboBoxEvasion";
            this.comboBoxEvasion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEvasion.TabIndex = 18;
            // 
            // comboBoxExperience
            // 
            this.comboBoxExperience.FormattingEnabled = true;
            this.comboBoxExperience.Location = new System.Drawing.Point(106, 289);
            this.comboBoxExperience.Name = "comboBoxExperience";
            this.comboBoxExperience.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExperience.TabIndex = 19;
            // 
            // comboBoxMaxGold
            // 
            this.comboBoxMaxGold.FormattingEnabled = true;
            this.comboBoxMaxGold.Location = new System.Drawing.Point(106, 316);
            this.comboBoxMaxGold.Name = "comboBoxMaxGold";
            this.comboBoxMaxGold.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaxGold.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Evasion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Experience:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Max Gold:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(286, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 301);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DragonWarriorMonsterStatEditor.Properties.Resources.dl;
            this.pictureBox2.Location = new System.Drawing.Point(296, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(306, 264);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // buttonUpdateMonsterStats
            // 
            this.buttonUpdateMonsterStats.Location = new System.Drawing.Point(286, 391);
            this.buttonUpdateMonsterStats.Name = "buttonUpdateMonsterStats";
            this.buttonUpdateMonsterStats.Size = new System.Drawing.Size(326, 23);
            this.buttonUpdateMonsterStats.TabIndex = 8;
            this.buttonUpdateMonsterStats.Text = "Update Monster Stats";
            this.buttonUpdateMonsterStats.UseVisualStyleBackColor = true;
            this.buttonUpdateMonsterStats.Click += new System.EventHandler(this.buttonUpdateMonsterStats_Click);
            // 
            // updateMonsterStatsToolStripMenuItem
            // 
            this.updateMonsterStatsToolStripMenuItem.Name = "updateMonsterStatsToolStripMenuItem";
            this.updateMonsterStatsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.updateMonsterStatsToolStripMenuItem.Text = "&Update Monster Stats";
            this.updateMonsterStatsToolStripMenuItem.Click += new System.EventHandler(this.updateMonsterStatsToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.buttonUpdateMonsterStats);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Dragon Warrior Monster Stat Editor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openROMToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOpenRom;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxMaxGold;
        private System.Windows.Forms.ComboBox comboBoxExperience;
        private System.Windows.Forms.ComboBox comboBoxEvasion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHurtResistance;
        private System.Windows.Forms.ComboBox comboBoxStopResistance;
        private System.Windows.Forms.ComboBox comboBoxSleepResistance;
        private System.Windows.Forms.ComboBox comboBoxSpecial2;
        private System.Windows.Forms.ComboBox comboBoxSpecial1;
        private System.Windows.Forms.ComboBox comboBoxMaxHP;
        private System.Windows.Forms.ComboBox comboBoxAgility;
        private System.Windows.Forms.ComboBox comboBoxStrength;
        private System.Windows.Forms.ComboBox comboBoxMonsters;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonUpdateMonsterStats;
        private System.Windows.Forms.ToolStripMenuItem updateMonsterStatsToolStripMenuItem;
    }
}

