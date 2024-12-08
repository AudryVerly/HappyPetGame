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
    public partial class FormToysShop : Form
    {
        //buat list yang berisi semua toys yamg dijual di toko
        List<Toy> listToyShop = new List<Toy>();
        Toy toy1 ,toy2, toy3, toy4;
        FormGame frmGame;
        public FormToysShop()
        {
            InitializeComponent();
        }

        

        private void CreateToys()
        {
            //ciptakan semua toys yang dijual di toko
            //Toy1
            toy1 = new Toy("Ball", 300, 10, Properties.Resources.cat_toys_ball);

            //simpan ke list
            listToyShop.Add(toy1);

            //tampilkan ke label data
            labelToy1.Text = toy1.DisplayData();

            //toy2
            toy2 = new Toy("Stick", 200, 5,Properties.Resources.cat_toys_stick);

            //simpan ke list
            listToyShop.Add(toy2);

            //tampilkan ke label data
            labelToy2.Text = toy2.DisplayData();

            //toy3
            toy3 = new Toy("Yarn", 500, 20,Properties.Resources.cat_toys_yarn);

            //simpan ke list
            listToyShop.Add(toy3);

            //tampilkan ke label data
            labelToy3.Text = toy3.DisplayData();

            toy4 = new Toy("Wheel", 600, 60, Properties.Resources.wheel);

            listToyShop.Add(toy4);

            labelWheel.Text = toy4.DisplayData();
        }
        private void FormToysShop_Load(object sender, EventArgs e)
        {
            CreateToys();

            frmGame = (FormGame)this.Owner.Owner;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                //cek toy yang dipilih user
                if (radioButtonBall.Checked)
                {
                    frmGame.myPet.Buy(toy1);
                }
                else if (radioButtonStick.Checked)
                {
                    frmGame.myPet.Buy(toy2);
                }
                else if (radioButtonYarn.Checked)
                {
                    frmGame.myPet.Buy(toy3);
                }
                else if (radioButtonWheel.Checked)
                {
                    frmGame.myPet.Buy(toy4);
                }

                MessageBox.Show("Toy has been add to your pet drawer");
               
                //tampilkan data player terbaru
                frmGame.labelPlayerData.Text = frmGame.myPet.Owner.DisplayData();

                //close form toys shop dan form Select toys
                this.Close();
                this.Owner.Close();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
          
        }
    }
}
