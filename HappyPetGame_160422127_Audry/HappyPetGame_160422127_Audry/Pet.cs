using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422127_Audry
{
    [Serializable]
    public abstract class Pet
    {
        private string name;
        private int health;
        private int energy;
        private int happiness;
        private Image picture;
        private Player owner;// 1 pet hanya punya 1 owner
        private List<Toy> listToys; //1 pet bisa banyak toy

        #region Constructor
        protected Pet(string name, Image picture, Player owner)
        {
            this.Name = name;
            this.Health = 100;
            this.Energy = 100;
            this.Happiness = 100;
            this.Picture = picture;
            this.Owner = owner;
            this.ListToys =new List<Toy>();//toy akan ditambahkan waktu BUY
        }
        #endregion

        #region Properties
        public string Name 
        { 
            get => name;
            set
            {
                if(value != "")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name Cannot be Empty");
                }
            }
               
        }
        public int Health 
        {
            get => health;
            set
            {
                if(value >= 10 && value  <= 100)
                {
                    health = value;
                }
                else if( value < 10)
                {
                    health = 10;
                }
                else
                {
                    health = 100;
                }
            }    
        }
        public int Energy 
        { 
            get => energy;
            set
            {

                if (value >= 10 && value <= 100)
                {
                    energy = value;
                }
                else if (value < 10)
                {
                    energy = 10;
                }
                else 
                {
                    energy = 100;
                }
            }
        }
        public int Happiness 
        { 
            get => happiness;
            set
            {

                if (value >= 10 && value <= 100)
                {
                    happiness= value;
                }
                else if (value < 10)
                {
                    happiness = 10;
                }
                else
                {
                    happiness = 100;
                }
            }
        }
        public Image Picture { get => picture; set => picture = value; }
        public Player Owner { get => owner; set => owner = value; }
        public List<Toy> ListToys { get => listToys; set => listToys = value; }
        #endregion

        #region Method
        //misal : semua child harus memiliki method DisplayData
        public abstract string DisplayData();

        protected string DisplayPet()
        {
            string data = this.Name +
                          "\nHelath : " + this.Health + " % " +
                          "Energy : " + this.Energy + " % " +
                          "Happiness : " + this.Happiness + " % ";
            return data;
        }

        //Method harus dimeliki oleh semua pet
        public abstract void Feed(Player player);

        public virtual void Sleep(Player player)
        {

        }
        //method untuk membeli toys
        //asusmi : bisa ada beberapa jenis pet yang memiliki toy
        public void Buy(Toy toy)
        {
            //cek apakah koin mencukupi untuk membeli toy
            if (this.Owner.Coins >= toy.Price)
            {
                //cek apakah pemilik pet sudah memiliki toy tsb
                bool sudahPunya = false;
                foreach(Toy t in this.ListToys)
                {
                    if(t.Name == toy.Name)
                    {
                        sudahPunya = true;
                    }
                }

                if(sudahPunya == false)//jika belum punya toy tsb
                {
                    //simpan ke listToys
                    this.ListToys.Add(toy);

                    //kurangi koin pemain
                    this.Owner.Coins -= toy.Price;
                }
                else
                {
                    throw new Exception("Your Pet has already bought this toy");
                }
            }
            else
            {
                throw new Exception("Not enough Coin to Buy this toy");
            }
        }
        //asumsi : method play bisa digunakan oleh beberapa jenis pet
        public virtual void Play(Toy toy, Player player)
        { }

        //method untuk cek kondisi Health
        public string CekHealth()
        {
            string Condition = "";
            if(this.Health >= 10 && this.Happiness <=25)
            {
                Condition = "Very Poor";
            }
            else if(this.Health >= 26 && this.Health <=60)
            {
                Condition = "Poor";
            }
            else if(this.Health >=61 && this.Health <=80)
            {
                Condition = "Good";
            }
            else
            {
                Condition = "Very Good";
            }
            return Condition;
        }

        //Method Untuk cek kondisi EnergyPet
        public string CekEnergy()
        {
            string Condition = "";
            if (this.Energy >= 10 && this.Energy <= 50)
            {
                Condition = "Weak";
            }
            else if (this.Energy >= 51 && this.Energy <= 75)
            {
                Condition = "Moderate";
            }
            else 
            {
                Condition = "Strong;";
            }
           
            return Condition;
        }
        //Method Untuk cek kondisi Happines Pet
        public string CekHappiness()
        {
            string Condition = "";
            if (this.Happiness >= 10 && this.Happiness <= 60)
            {
                Condition = "Unhappy";
            }
            else 
            {
                Condition = "Happy";
            }
            return Condition;
        }

        #endregion
    }

}