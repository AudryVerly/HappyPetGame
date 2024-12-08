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
    public partial class FormSelectToys : Form
    {
        FormGame frmGame;
        Toy selectedToy;
        public FormSelectToys()
        {
            InitializeComponent();
        }

        private void FormSelectToys_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;
            //isikan semua toys yang dimiliki pet ke ComboBox
            //gunakan data binding
            comboBoxToys.DataSource = frmGame.myPet.ListToys;
            comboBoxToys.DisplayMember ="Name";
        }

        private void linkLabelBuyHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormToysShop form = new FormToysShop();
            form.Owner = this;
            form.ShowDialog();
           
        }

        private void buttonUse_Click(object sender, EventArgs e)
        {
            //panggil method play
            frmGame.myPet.Play(selectedToy, frmGame.myPlayer);
            //tampilkan data pet terbaru di label
            frmGame.labelPetData.Text = frmGame.myPet.DisplayData();
            if (comboBoxToys.Text == "Ball")
            {
                frmGame.selectedToy = "Ball";
            }
            else if (comboBoxToys.Text == "Stick")
            {
                frmGame.selectedToy = "Stick";
            }
            else if (comboBoxToys.Text == "Yarn")
            {
                frmGame.selectedToy = "Yarn";
            }
            else if(comboBoxToys.Text == "Wheel")
            {
                frmGame.selectedToy = "Wheel";
            }

            if (frmGame.myPet is Cat cat)
            {
                //panggil method feed
                cat.Play(selectedToy, frmGame.myPlayer);

                //tampilkan data terbarunya
                frmGame.labelPetData.Text = frmGame.myPet.DisplayData();
                frmGame.labelPlayerData.Text = frmGame.myPlayer.DisplayData();
            }
            else if (frmGame.myPet is Hamster hamster)
            {
                //panggil method feed
                hamster.Play(selectedToy, frmGame.myPlayer);

                //tampilkan data terbarunya
                frmGame.labelPetData.Text = frmGame.myPet.DisplayData();
                frmGame.labelPlayerData.Text = frmGame.myPlayer.DisplayData();
            }

            this.Close();
        }

        private void comboBoxToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxToys.SelectedIndex != -1)
            {
                //Dapatkan objek tot yang dipilih user di ComboBox
                selectedToy = (Toy)comboBoxToys.SelectedItem;

                //tampilkan gamvar toy yang dipilih user di comboBox
                pictureBoxToy.Image = selectedToy.Picture;

                //agar gambar menyesuailkan dengan ukuran pictureBox
                pictureBoxToy.SizeMode = PictureBoxSizeMode.StretchImage;

                //tampilkan data tot yang dipilih
                labelToysData.Text = selectedToy.DisplayData();
            }
        }
    }
}
