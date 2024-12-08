
namespace HappyPetGame_160422127_Audry
{
    partial class FormSelectPlayer
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
            this.linkLabelClickHere = new System.Windows.Forms.LinkLabel();
            this.labelNewPlayer = new System.Windows.Forms.Label();
            this.buttonLetsPlay = new System.Windows.Forms.Button();
            this.comboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.labelSelectPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabelClickHere
            // 
            this.linkLabelClickHere.AutoSize = true;
            this.linkLabelClickHere.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelClickHere.Location = new System.Drawing.Point(132, 144);
            this.linkLabelClickHere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelClickHere.Name = "linkLabelClickHere";
            this.linkLabelClickHere.Size = new System.Drawing.Size(78, 19);
            this.linkLabelClickHere.TabIndex = 9;
            this.linkLabelClickHere.TabStop = true;
            this.linkLabelClickHere.Text = "Click Here";
            this.linkLabelClickHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClickHere_LinkClicked);
            // 
            // labelNewPlayer
            // 
            this.labelNewPlayer.AutoSize = true;
            this.labelNewPlayer.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPlayer.Location = new System.Drawing.Point(43, 144);
            this.labelNewPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewPlayer.Name = "labelNewPlayer";
            this.labelNewPlayer.Size = new System.Drawing.Size(93, 19);
            this.labelNewPlayer.TabIndex = 8;
            this.labelNewPlayer.Text = "New Player ?";
            // 
            // buttonLetsPlay
            // 
            this.buttonLetsPlay.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetsPlay.Location = new System.Drawing.Point(68, 96);
            this.buttonLetsPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLetsPlay.Name = "buttonLetsPlay";
            this.buttonLetsPlay.Size = new System.Drawing.Size(114, 25);
            this.buttonLetsPlay.TabIndex = 7;
            this.buttonLetsPlay.Text = "Lets Play";
            this.buttonLetsPlay.UseVisualStyleBackColor = true;
            this.buttonLetsPlay.Click += new System.EventHandler(this.buttonLetsPlay_Click);
            // 
            // comboBoxPlayer
            // 
            this.comboBoxPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlayer.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlayer.FormattingEnabled = true;
            this.comboBoxPlayer.Location = new System.Drawing.Point(32, 56);
            this.comboBoxPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPlayer.Name = "comboBoxPlayer";
            this.comboBoxPlayer.Size = new System.Drawing.Size(184, 26);
            this.comboBoxPlayer.TabIndex = 6;
            this.comboBoxPlayer.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlayer_SelectedIndexChanged);
            // 
            // labelSelectPlayer
            // 
            this.labelSelectPlayer.AutoSize = true;
            this.labelSelectPlayer.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectPlayer.Location = new System.Drawing.Point(80, 27);
            this.labelSelectPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectPlayer.Name = "labelSelectPlayer";
            this.labelSelectPlayer.Size = new System.Drawing.Size(97, 19);
            this.labelSelectPlayer.TabIndex = 5;
            this.labelSelectPlayer.Text = "Select Player";
            // 
            // FormSelectPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(244, 227);
            this.Controls.Add(this.linkLabelClickHere);
            this.Controls.Add(this.labelNewPlayer);
            this.Controls.Add(this.buttonLetsPlay);
            this.Controls.Add(this.comboBoxPlayer);
            this.Controls.Add(this.labelSelectPlayer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSelectPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelectPlayer";
            this.Load += new System.EventHandler(this.FormSelectPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelClickHere;
        private System.Windows.Forms.Label labelNewPlayer;
        private System.Windows.Forms.Button buttonLetsPlay;
        private System.Windows.Forms.ComboBox comboBoxPlayer;
        private System.Windows.Forms.Label labelSelectPlayer;
    }
}