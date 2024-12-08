using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422127_Audry
{
    public partial class FormGame : Form
    {
        public Player myPlayer;
        public Pet myPet;

        int detik;
        public string selectedToy;

        Toy toy;

        public List<Player> listPlayer = new List<Player>();
        public List<Pet> listPet = new List<Pet>();

        public FormGame()
        {
            InitializeComponent();
        }
        //method untuk memulai game
        public void StartGame()
        {
            try
            {
                //tampilkan panel data dan panel activity
                panelActivity.Visible = true;
                panelData.Visible = true;

                //tampilkan data player dan pet dimlabet formGame
                labelPlayerData.Text = myPlayer.DisplayData();
                labelPetData.Text = myPet.DisplayData();
                labelDateTime.Text = DateTime.Now.ToString();

                //tampilkan gambar pet di picturebox di FORMGAME
                pictureBoxPet.Image = myPet.Picture;
                pictureBoxPet.SizeMode = PictureBoxSizeMode.StretchImage;

                //cek jenis pet untuk menentukan aktivitas apa saja yang bisa di lakukan
                if (myPet is Cat)
                {
                    buttonPlay.Enabled = true;
                    buttonBath.Enabled = true;
                    buttonSleep.Enabled = true;
                    buttonVaccinate.Enabled = true;
                    buttonClean.Enabled = false;
                    buttonChangeColor.Enabled = false;
                }
                else if (myPet is Fish)
                {
                    buttonPlay.Enabled = false;
                    buttonBath.Enabled = false;
                    buttonSleep.Enabled = false;
                    buttonVaccinate.Enabled = false;
                    buttonClean.Enabled = true;
                    buttonChangeColor.Enabled = false;
                }
                else if (myPet is Chameleon)
                {
                    buttonPlay.Enabled = false;
                    buttonBath.Enabled = false;
                    buttonSleep.Enabled = true;
                    buttonVaccinate.Enabled = false;
                    buttonClean.Enabled = false;
                    buttonChangeColor.Enabled = true;
                }
                else if (myPet is Hamster)
                {
                    buttonPlay.Enabled = true;
                    buttonBath.Enabled = false;
                    buttonSleep.Enabled = true;
                    buttonVaccinate.Enabled = false;
                    buttonClean.Enabled = false;
                    buttonChangeColor.Enabled = false;
                }

                //mulai timer
                timerGame.Interval = 8000;
                timerGame.Start();

                //set timer activity
                timerActivity.Interval = 3000;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectPlayer form = new FormSelectPlayer();
            form.Owner = this;
            form.ShowDialog();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            panelData.Visible = false;
            panelActivity.Visible = false;
            labelDateTime.Enabled = true;

            ReadFromFilePlayer("playerData.gm");
            ReadFromFilePet("petData.gm");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            try
            {
                if (myPet is Cat cat)
                {
                    //panggil method feed
                    cat.Feed(myPlayer);

                    //tampilkan data terbarunya
                    labelPetData.Text = myPet.DisplayData();
                    labelPlayerData.Text = myPlayer.DisplayData();
                }
                else if (myPet is Fish fish)
                {
                    //panggil method feed
                    fish.Feed(myPlayer);

                    //tampilkan data terbarunya
                    labelPetData.Text = myPet.DisplayData();
                    labelPlayerData.Text = myPlayer.DisplayData();
                }
                else if (myPet is Chameleon chameleon)
                {
                    //panggil method feed
                    chameleon.Feed(myPlayer);

                    //tampilkan data terbarunya
                    labelPetData.Text = myPet.DisplayData();
                    labelPlayerData.Text = myPlayer.DisplayData();
                }
                else if (myPet is Hamster hamster)
                {
                    //panggil method feed
                    hamster.Feed(myPlayer);

                    //tampilkan data terbarunya
                    labelPetData.Text = myPet.DisplayData();
                    labelPlayerData.Text = myPlayer.DisplayData();
                }


                ChangePIctureActivity("Feed");

                //reset detik
                detik = 0;
                //aktifkan timer activity
                timerActivity.Start();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                FormSelectToys form = new FormSelectToys();
                form.Owner = this;
                form.ShowDialog();

                ChangePIctureActivity("Play");

                //reset detik
                detik = 0;
                //aktifkan timer activity
                timerActivity.Start();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

            

        }

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            try
            {
                if (myPet is Cat cat)
                {
                    //panggil method feed
                    cat.Sleep(myPlayer);

                    //tampilkan data terbarunya
                    labelPetData.Text = myPet.DisplayData();
                    labelPlayerData.Text = myPlayer.DisplayData();
                }
                else if (myPet is Chameleon chameleon)
                {
                    //panggil method feed
                    chameleon.Sleep(myPlayer);

                    //tampilkan data terbarunya
                    labelPetData.Text = myPet.DisplayData();
                    labelPlayerData.Text = myPlayer.DisplayData();
                }

                ChangePIctureActivity("Sleep");

                //reset detik
                detik = 0;
                //aktifkan timer activity
                timerActivity.Start();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void buttonBath_Click(object sender, EventArgs e)
        {
            try
            {
                if (myPet is Cat cat)
                {
                    cat.Bath(myPlayer);
                    labelPetData.Text = myPet.DisplayData();
                    labelPlayerData.Text = myPlayer.DisplayData();

                    ChangePIctureActivity("Bath");

                    //reset detik
                    detik = 0;
                    //aktifkan timer activity
                    timerActivity.Start();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonVaccinate_Click(object sender, EventArgs e)
        {
            try
            {
                if(myPet is Cat cat)
                {
                    //panggil method Vaccinate
                    cat.Vaccinate(myPlayer);
                    labelPetData.Text = myPet.DisplayData();
                    //tampilkan data Player terbaru
                    labelPlayerData.Text = myPlayer.DisplayData();

                    ChangePIctureActivity("Vaccinate");

                    //reset detik
                    detik = 0;
                    //aktifkan timer activity
                    timerActivity.Start();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            try
            {
                //gunakan downcasting karena method ini hanya dimiliki oleh fish
                if(myPet is Fish)
                {
                    ((Fish)myPet).Clean(myPlayer);
                    labelPetData.Text = myPet.DisplayData();
                    labelPlayerData.Text = myPlayer.DisplayData();

                    ChangePIctureActivity("Clean");

                    //reset detik
                    detik = 0;
                    //aktifkan timer activity
                    timerActivity.Start();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            //untuk mengurangi nilai indikator
            //nilai masing-masing indikator akan berkurang 5% setiap 1 detik
            myPet.Health -= 5;
            myPet.Energy -= 5;
            myPet.Happiness -= 5;

            //tampilkan data pet terbaru
            labelPetData.Text = myPet.DisplayData();

            //cek kondisi pet
            if(myPet.CekHealth() =="Very Poor" && 
              myPet.CekEnergy() == "Weak" && 
              myPet.CekHappiness() == "Unhappy")
            {
                //game Over
                //timer stop
                timerGame.Stop();

                MessageBox.Show("Sorry You can continue the game, GAME OVER");

                panelData.Visible = false;
                panelActivity.Visible = false;
                pictureBoxPet.Visible = false;
            }
            
        }
        
        //method untuk mengganti gambar
        private void ChangePIctureActivity(string activity)
        {
            if(myPet is Cat)
            {
                if(activity == "Feed")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_feed;
                }
                else if(activity == "Sleep")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_sleep;
                }
                else if (activity == "Bath")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_bath;
                }
                else if(activity == "Vaccinate")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_vaccinate;
                }
                else if(activity == "Play")
                {
                    //cek toy yang dipilih yang mana
                    if(selectedToy == "Ball")
                    {
                        pictureBoxPet.Image = Properties.Resources.cat_play_ball;
                    }
                    else if(selectedToy == "Stick")
                    {
                        pictureBoxPet.Image = Properties.Resources.cat_play_stick;
                    }
                    else if (selectedToy == "Yarn")
                    {
                        pictureBoxPet.Image = Properties.Resources.cat_play_yarn;
                    }
                }
            }
            else if(myPet is Fish)
            {
                if(activity == "Feed")
                {
                    pictureBoxPet.Image = Properties.Resources.fish_feed;
                }
                else if(activity == "Clean")
                {
                    pictureBoxPet.Image = Properties.Resources.fish_clean;
                }
            }
            else if(myPet is Chameleon)
            {
                if (activity == "Feed")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleon_feed;
                }
                else if(activity == "Sleep")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleon_sleep;
                }
            }
            else if (myPet is Hamster)
            {
                if (activity == "Feed")
                {
                    pictureBoxPet.Image = Properties.Resources.hamster_feed;
                }
                else if (activity == "Sleep")
                {
                    pictureBoxPet.Image = Properties.Resources.hamster_sleep;
                }
                else if (activity == "Play")
                {
                    if (selectedToy == "Ball")
                    {
                        pictureBoxPet.Image = Properties.Resources.hamster_play_ball;
                    }
                    else if (selectedToy == "Stick")
                    {
                        pictureBoxPet.Image = Properties.Resources.hamster_play_stick;
                    }
                    else if (selectedToy == "Yarn")
                    {
                        pictureBoxPet.Image = Properties.Resources.hamster_play_yarn;
                    }
                    else if (selectedToy == "Wheel")
                    {
                        pictureBoxPet.Image = Properties.Resources.hamster_play_wheel;
                    }
                }
            }
        }

        private void timerActivity_Tick(object sender, EventArgs e)
        {
            //jalanlan selama 5 detik
            detik++;
            //cek apakah udah 5 detik
            if(detik == 3)
            {
                timerActivity.Stop();

                //gambar pet diubah ke gambar semula
                if(myPet is Cat)
                {
                    pictureBoxPet.Image = Properties.Resources.cat_happy;
                }
                else if(myPet is Fish)
                {
                    pictureBoxPet.Image = Properties.Resources.fish_happy;
                }
                else if(myPet is Chameleon)
                {
                    pictureBoxPet.Image = Properties.Resources.chameleon_happy;
                }
                else if (myPet is Hamster)
                {
                    pictureBoxPet.Image = Properties.Resources.hamster_happy;
                }
            }

        }
        //method untuk save data ke file
        private void SaveToFilePlayer(string fileName)
        {
            FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myFile, listPlayer);
            myFile.Close();
        }
        private void SaveToFilePet(string filename)
        {
            FileStream myFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myFile,listPet);
            myFile.Close();
        }
        //method untuk read data player dari file

        private void ReadFromFilePlayer(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream myFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listPlayer = (List<Player>)formatter.Deserialize(myFile);
                myFile.Close();
            }

        }
        private void ReadFromFilePet(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream myFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listPet = (List<Pet>)formatter.Deserialize(myFile);
                myFile.Close();
            }

        }

        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save ke File
            SaveToFilePlayer("playerData.gm");
            SaveToFilePet("petData.gm");
        }

        private void labelHappyPetgame_Click(object sender, EventArgs e)
        {

        }

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure to delete data?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //hapus data article tsb

                listPlayer.Remove(myPlayer);
                listPet.Remove(myPet);

                MessageBox.Show("Data is deleted");

                panelData.Visible = false;
                panelActivity.Visible = false;
                pictureBoxPet.Visible = false;
            }
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.Yellow;
            if(myPet is Chameleon)
            {
                ((Chameleon)myPet).ChangedColor(randomColor);
                {
                    pictureBoxPet.Image = Properties.Resources.CHAMEL_YELLOW;
                }

            }
            //reset detik
            detik = 0;
            //aktifkan timer activity
            timerActivity.Start();
        }

        private void timerColor_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void changePetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePet form = new FormChangePet();
            form.Owner = this;
            form.ShowDialog();
        }

        private void pictureBoxPet_Click(object sender, EventArgs e)
        {

        }
    }
}
