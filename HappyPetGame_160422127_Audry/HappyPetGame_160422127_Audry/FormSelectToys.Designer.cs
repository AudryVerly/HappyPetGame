
namespace HappyPetGame_160422127_Audry
{
    partial class FormSelectToys
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
            this.linkLabelBuyHere = new System.Windows.Forms.LinkLabel();
            this.labelNewPlayer = new System.Windows.Forms.Label();
            this.buttonUse = new System.Windows.Forms.Button();
            this.comboBoxToys = new System.Windows.Forms.ComboBox();
            this.labelSelectPlayer = new System.Windows.Forms.Label();
            this.labelToysData = new System.Windows.Forms.Label();
            this.pictureBoxToy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToy)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelBuyHere
            // 
            this.linkLabelBuyHere.AutoSize = true;
            this.linkLabelBuyHere.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuyHere.Location = new System.Drawing.Point(332, 652);
            this.linkLabelBuyHere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelBuyHere.Name = "linkLabelBuyHere";
            this.linkLabelBuyHere.Size = new System.Drawing.Size(134, 38);
            this.linkLabelBuyHere.TabIndex = 14;
            this.linkLabelBuyHere.TabStop = true;
            this.linkLabelBuyHere.Text = "Buy Here";
            this.linkLabelBuyHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuyHere_LinkClicked);
            // 
            // labelNewPlayer
            // 
            this.labelNewPlayer.AutoSize = true;
            this.labelNewPlayer.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPlayer.Location = new System.Drawing.Point(65, 652);
            this.labelNewPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewPlayer.Name = "labelNewPlayer";
            this.labelNewPlayer.Size = new System.Drawing.Size(271, 38);
            this.labelNewPlayer.TabIndex = 13;
            this.labelNewPlayer.Text = "don\'t have any toy ?";
            // 
            // buttonUse
            // 
            this.buttonUse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonUse.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUse.Location = new System.Drawing.Point(116, 556);
            this.buttonUse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(264, 72);
            this.buttonUse.TabIndex = 12;
            this.buttonUse.Text = "Use";
            this.buttonUse.UseVisualStyleBackColor = false;
            this.buttonUse.Click += new System.EventHandler(this.buttonUse_Click);
            // 
            // comboBoxToys
            // 
            this.comboBoxToys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxToys.FormattingEnabled = true;
            this.comboBoxToys.Location = new System.Drawing.Point(68, 91);
            this.comboBoxToys.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxToys.Name = "comboBoxToys";
            this.comboBoxToys.Size = new System.Drawing.Size(378, 39);
            this.comboBoxToys.TabIndex = 11;
            this.comboBoxToys.SelectedIndexChanged += new System.EventHandler(this.comboBoxToys_SelectedIndexChanged);
            // 
            // labelSelectPlayer
            // 
            this.labelSelectPlayer.AutoSize = true;
            this.labelSelectPlayer.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectPlayer.Location = new System.Drawing.Point(176, 35);
            this.labelSelectPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectPlayer.Name = "labelSelectPlayer";
            this.labelSelectPlayer.Size = new System.Drawing.Size(183, 38);
            this.labelSelectPlayer.TabIndex = 10;
            this.labelSelectPlayer.Text = "Select Toys :";
            // 
            // labelToysData
            // 
            this.labelToysData.BackColor = System.Drawing.Color.Transparent;
            this.labelToysData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToysData.Location = new System.Drawing.Point(129, 416);
            this.labelToysData.Name = "labelToysData";
            this.labelToysData.Size = new System.Drawing.Size(251, 136);
            this.labelToysData.TabIndex = 16;
            this.labelToysData.Text = "Toys Data";
            this.labelToysData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxToy
            // 
            this.pictureBoxToy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxToy.Location = new System.Drawing.Point(68, 154);
            this.pictureBoxToy.Name = "pictureBoxToy";
            this.pictureBoxToy.Size = new System.Drawing.Size(376, 249);
            this.pictureBoxToy.TabIndex = 15;
            this.pictureBoxToy.TabStop = false;
            // 
            // FormSelectToys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(515, 755);
            this.Controls.Add(this.labelToysData);
            this.Controls.Add(this.pictureBoxToy);
            this.Controls.Add(this.linkLabelBuyHere);
            this.Controls.Add(this.labelNewPlayer);
            this.Controls.Add(this.buttonUse);
            this.Controls.Add(this.comboBoxToys);
            this.Controls.Add(this.labelSelectPlayer);
            this.Name = "FormSelectToys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelectToys";
            this.Load += new System.EventHandler(this.FormSelectToys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelBuyHere;
        private System.Windows.Forms.Label labelNewPlayer;
        private System.Windows.Forms.Button buttonUse;
        private System.Windows.Forms.ComboBox comboBoxToys;
        private System.Windows.Forms.Label labelSelectPlayer;
        private System.Windows.Forms.PictureBox pictureBoxToy;
        private System.Windows.Forms.Label labelToysData;
    }
}