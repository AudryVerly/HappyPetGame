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
    public partial class FormChangePet : Form
    {
        FormGame frmGame;
        public FormChangePet()
        {
            InitializeComponent();
        }

        private void FormChangePet_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;

            //isi comboboxenvironment
            comboBoxEnvironment.Items.Add("Sea");
            comboBoxEnvironment.Items.Add("River");
            comboBoxEnvironment.Items.Add("Pond");

            //isi comboboxcage
            comboBoxCage.Items.Add("Plastic");
            comboBoxCage.Items.Add("Stainless Steel");

            comboBoxEnvironment.Visible = false;
            labelEnvironment.Visible = false;
            radioButtonCat.Checked = true;
            comboBoxCage.Visible = false;
            labelCage.Visible = false;
        }

        private void buttonLetsPlay_Click(object sender, EventArgs e)
        {
            if (radioButtonCat.Checked)
            {
                frmGame.myPet = new Cat(textBoxPetName.Text, radioButtonCat.BackgroundImage, frmGame.myPlayer);
            }
            else if (radioButtonFish.Checked)
            {
                frmGame.myPet = new Fish(textBoxPetName.Text, radioButtonFish.BackgroundImage,
                                    frmGame.myPlayer, comboBoxEnvironment.Text);
            }
            else if (radioButtonChameleon.Checked)
            {
                frmGame.myPet = new Chameleon(textBoxPetName.Text, radioButtonChameleon.BackgroundImage,
                                       frmGame.myPlayer, Color.Green);
            }
            else if (radioButtonHamster.Checked)
            {
                frmGame.myPet = new Hamster(textBoxPetName.Text, radioButtonHamster.BackgroundImage,
                                            frmGame.myPlayer, comboBoxCage.Text);
            }
            frmGame.listPlayer.Add(frmGame.myPlayer);

            //simpan pet tsb di dalam listPet
            frmGame.listPet.Add(frmGame.myPet);

            //panggil method StartGame di formGame
            frmGame.StartGame();

            //tutup form selec pet dan form select player
            this.Close();
        }

        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEnvironment.Visible = false;
            labelEnvironment.Visible = false;
            comboBoxCage.Visible = false;
            labelCage.Visible = false;
        }

        private void radioButtonFish_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEnvironment.Visible = true;
            labelEnvironment.Visible = true;
            comboBoxCage.Visible = false;
            labelCage.Visible = false;
        }

        private void radioButtonChameleon_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEnvironment.Visible = false;
            labelEnvironment.Visible = false;
            comboBoxCage.Visible = false;
            labelCage.Visible = false;
        }

        private void radioButtonHamster_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEnvironment.Visible = false;
            labelEnvironment.Visible = false;
            comboBoxCage.Visible = true;
            labelCage.Visible = true;
        }
    }
}
