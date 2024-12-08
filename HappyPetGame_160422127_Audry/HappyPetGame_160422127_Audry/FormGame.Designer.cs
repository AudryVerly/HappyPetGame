
namespace HappyPetGame_160422127_Audry
{
    partial class FormGame
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
            this.pictureBoxPet = new System.Windows.Forms.PictureBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonVaccinate = new System.Windows.Forms.Button();
            this.buttonBath = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.panelActivity = new System.Windows.Forms.Panel();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.labelPetData = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelPlayerData = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHappyPetgame = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerActivity = new System.Windows.Forms.Timer(this.components);
            this.timerColor = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            this.panelActivity.SuspendLayout();
            this.panelData.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPet.Location = new System.Drawing.Point(435, 217);
            this.pictureBoxPet.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(535, 486);
            this.pictureBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPet.TabIndex = 9;
            this.pictureBoxPet.TabStop = false;
            this.pictureBoxPet.Click += new System.EventHandler(this.pictureBoxPet_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.HotPink;
            this.buttonClean.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClean.Location = new System.Drawing.Point(976, 22);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(180, 78);
            this.buttonClean.TabIndex = 7;
            this.buttonClean.Text = "CLEAN";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonVaccinate
            // 
            this.buttonVaccinate.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonVaccinate.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVaccinate.Location = new System.Drawing.Point(764, 24);
            this.buttonVaccinate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVaccinate.Name = "buttonVaccinate";
            this.buttonVaccinate.Size = new System.Drawing.Size(199, 78);
            this.buttonVaccinate.TabIndex = 6;
            this.buttonVaccinate.Text = "VACCINATE";
            this.buttonVaccinate.UseVisualStyleBackColor = false;
            this.buttonVaccinate.Click += new System.EventHandler(this.buttonVaccinate_Click);
            // 
            // buttonBath
            // 
            this.buttonBath.BackColor = System.Drawing.Color.Indigo;
            this.buttonBath.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBath.ForeColor = System.Drawing.Color.White;
            this.buttonBath.Location = new System.Drawing.Point(578, 22);
            this.buttonBath.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBath.Name = "buttonBath";
            this.buttonBath.Size = new System.Drawing.Size(178, 78);
            this.buttonBath.TabIndex = 5;
            this.buttonBath.Text = "BATH";
            this.buttonBath.UseVisualStyleBackColor = false;
            this.buttonBath.Click += new System.EventHandler(this.buttonBath_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonPlay.Location = new System.Drawing.Point(203, 23);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(188, 78);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonFeed
            // 
            this.buttonFeed.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonFeed.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFeed.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonFeed.Location = new System.Drawing.Point(13, 23);
            this.buttonFeed.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(182, 78);
            this.buttonFeed.TabIndex = 3;
            this.buttonFeed.Text = "FEED";
            this.buttonFeed.UseVisualStyleBackColor = false;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // panelActivity
            // 
            this.panelActivity.BackColor = System.Drawing.Color.Transparent;
            this.panelActivity.Controls.Add(this.buttonChangeColor);
            this.panelActivity.Controls.Add(this.buttonSleep);
            this.panelActivity.Controls.Add(this.buttonVaccinate);
            this.panelActivity.Controls.Add(this.buttonBath);
            this.panelActivity.Controls.Add(this.buttonClean);
            this.panelActivity.Controls.Add(this.buttonPlay);
            this.panelActivity.Controls.Add(this.buttonFeed);
            this.panelActivity.Location = new System.Drawing.Point(25, 795);
            this.panelActivity.Margin = new System.Windows.Forms.Padding(4);
            this.panelActivity.Name = "panelActivity";
            this.panelActivity.Size = new System.Drawing.Size(1402, 125);
            this.panelActivity.TabIndex = 7;
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonChangeColor.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeColor.ForeColor = System.Drawing.Color.White;
            this.buttonChangeColor.Location = new System.Drawing.Point(1164, 24);
            this.buttonChangeColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(204, 78);
            this.buttonChangeColor.TabIndex = 9;
            this.buttonChangeColor.Text = "CHANGE COLOR";
            this.buttonChangeColor.UseVisualStyleBackColor = false;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // buttonSleep
            // 
            this.buttonSleep.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSleep.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSleep.ForeColor = System.Drawing.Color.DimGray;
            this.buttonSleep.Location = new System.Drawing.Point(399, 26);
            this.buttonSleep.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(171, 78);
            this.buttonSleep.TabIndex = 8;
            this.buttonSleep.Text = "SLEEP";
            this.buttonSleep.UseVisualStyleBackColor = false;
            this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            // 
            // labelPetData
            // 
            this.labelPetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelPetData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPetData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetData.ForeColor = System.Drawing.Color.Red;
            this.labelPetData.Location = new System.Drawing.Point(339, 15);
            this.labelPetData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPetData.Name = "labelPetData";
            this.labelPetData.Size = new System.Drawing.Size(755, 128);
            this.labelPetData.TabIndex = 2;
            this.labelPetData.Text = "labelPetData";
            this.labelPetData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Enabled = false;
            this.labelDateTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(1143, 44);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(237, 45);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "labelDateTime";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayerData
            // 
            this.labelPlayerData.AutoSize = true;
            this.labelPlayerData.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerData.Location = new System.Drawing.Point(26, 39);
            this.labelPlayerData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayerData.Name = "labelPlayerData";
            this.labelPlayerData.Size = new System.Drawing.Size(290, 52);
            this.labelPlayerData.TabIndex = 0;
            this.labelPlayerData.Text = "labelPlayerData";
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.labelPetData);
            this.panelData.Controls.Add(this.labelDateTime);
            this.panelData.Controls.Add(this.labelPlayerData);
            this.panelData.Location = new System.Drawing.Point(0, 50);
            this.panelData.Margin = new System.Windows.Forms.Padding(4);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1445, 159);
            this.panelData.TabIndex = 6;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(91, 42);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // changePetToolStripMenuItem
            // 
            this.changePetToolStripMenuItem.Name = "changePetToolStripMenuItem";
            this.changePetToolStripMenuItem.Size = new System.Drawing.Size(359, 46);
            this.changePetToolStripMenuItem.Text = "Change Pet";
            this.changePetToolStripMenuItem.Click += new System.EventHandler(this.changePetToolStripMenuItem_Click);
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(359, 46);
            this.resetGameToolStripMenuItem.Text = "Reset Game";
            this.resetGameToolStripMenuItem.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(359, 46);
            this.playGameToolStripMenuItem.Text = "Play Game";
            this.playGameToolStripMenuItem.Click += new System.EventHandler(this.playGameToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playGameToolStripMenuItem,
            this.resetGameToolStripMenuItem,
            this.changePetToolStripMenuItem});
            this.gameToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(106, 42);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // labelHappyPetgame
            // 
            this.labelHappyPetgame.BackColor = System.Drawing.Color.Transparent;
            this.labelHappyPetgame.Font = new System.Drawing.Font("Comic Sans MS", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHappyPetgame.Location = new System.Drawing.Point(191, 764);
            this.labelHappyPetgame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHappyPetgame.Name = "labelHappyPetgame";
            this.labelHappyPetgame.Size = new System.Drawing.Size(1045, 114);
            this.labelHappyPetgame.TabIndex = 8;
            this.labelHappyPetgame.Text = "Happy Pet Game";
            this.labelHappyPetgame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHappyPetgame.Click += new System.EventHandler(this.labelHappyPetgame_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1441, 46);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timerGame
            // 
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerActivity
            // 
            this.timerActivity.Tick += new System.EventHandler(this.timerActivity_Tick);
            // 
            // timerColor
            // 
            this.timerColor.Tick += new System.EventHandler(this.timerColor_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyPetGame_160422127_Audry.Properties.Resources.oop_room_utama;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1441, 958);
            this.Controls.Add(this.pictureBoxPet);
            this.Controls.Add(this.panelActivity);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.labelHappyPetgame);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyPetGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).EndInit();
            this.panelActivity.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxPet;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonVaccinate;
        private System.Windows.Forms.Button buttonBath;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonFeed;
        public System.Windows.Forms.Panel panelActivity;
        public System.Windows.Forms.Label labelPetData;
        public System.Windows.Forms.Label labelDateTime;
        public System.Windows.Forms.Label labelPlayerData;
        public System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.Label labelHappyPetgame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerActivity;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.Timer timerColor;
    }
}

