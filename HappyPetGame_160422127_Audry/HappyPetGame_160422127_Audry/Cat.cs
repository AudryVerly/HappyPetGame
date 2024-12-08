using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422127_Audry
{
    [Serializable]
    public class Cat : Pet
    {

        private bool vaccinationStatus;

        #region Constructor
        public Cat(string name, Image picture, Player owner):base(name,picture,owner)
        {
            //pertama kali main,status vaksinasi bernilai false
            this.VaccinationStatus = false;
        }
        #endregion

        #region Properties
        public bool VaccinationStatus { get => vaccinationStatus; set => vaccinationStatus = value; }
        #endregion

        #region Method
        public override string DisplayData()
        {
            string status = "No";
            if(this.VaccinationStatus == true)
            {
                status = "Yes";
            }
            string data = base.DisplayPet() +
                         "\nVaccination Status : " + status;

            return data;
        
        }
        public override void Feed(Player player)
        {
            base.Health += 30;
            base.Energy += 50;

            double coinPlus = 80 * 100 * 0.5;
            player.Coins += (int)coinPlus;
        }
       
        public override void Sleep(Player player)
        {
            base.Health += 20;
            base.Energy += 70;

            double coinPlus = 90 * 100 * 0.5;
            player.Coins += (int)coinPlus;
        }
        public void Bath(Player player)
        {
            base.Health += 30;

            double coinPlus = 30 * 100 * 0.5;
            player.Coins += (int)coinPlus;
        }
        public void Vaccinate(Player player)
        {
            //cek apakah koin player mencukupi dan cat belum pernah di Vaksin
            if(this.Owner.Coins >= 100 && this.VaccinationStatus == false)
            {
                this.VaccinationStatus = true;
                player.Coins -= 1000;
                //mengupdate nilai indikator
                base.Health += 40;
                base.Happiness -= 10;

                double coinPlus = 30 * 100 * 0.5;
                player.Coins += (int)coinPlus;
            }
            else if(this.VaccinationStatus == true)
            {
                throw new Exception("Your Cat has Already Vaccinated");
            }
            else
            {
                throw new Exception("Not Enough coins to vacinnate your pet");
            }
        }
       
        public override void Play(Toy toy, Player player)
        {
            base.Happiness += 50;
            base.Energy -= 30;

            double coinPlus = 20 * 100 * 0.5;
            player.Coins += (int)coinPlus;


            if (toy != null)
            {
                //tambah sesuai happiness
                base.Happiness += toy.Benefit;
            }
        }
        #endregion
    }
}