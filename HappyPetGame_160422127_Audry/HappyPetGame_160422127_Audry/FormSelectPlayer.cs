using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422127_Audry
{
    public partial class FormSelectPlayer : Form
    {
        FormGame frmGame;
        Player selectedPlayer;
        public FormSelectPlayer()
        {
            InitializeComponent();
        }

        private void linkLabelClickHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSelectPet form = new FormSelectPet();
            form.Owner = this;
            form.ShowDialog();
        }

        private void FormSelectPlayer_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;

            comboBoxPlayer.DataSource = frmGame.listPlayer;
            comboBoxPlayer.DisplayMember = "Name";
        }

        private void buttonLetsPlay_Click(object sender, EventArgs e)
        {
            //mendapatkan player yang dipilih oleh user
            selectedPlayer = (Player)comboBoxPlayer.SelectedItem;

            frmGame.myPlayer = selectedPlayer;
            
            //mendapatkan pet yang dipilih oleh user
            //asumsi tidak ada nama player yang sama
            foreach(Pet p in frmGame.listPet)
            {
                if(p.Owner.Name == selectedPlayer.Name)
                {
                    frmGame.myPet = p;
                }
           
            }
            this.Close();
            frmGame.StartGame();

        }

        private void comboBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
