using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422127_Audry
{
    [Serializable]
    public class Fish : Pet
    {
        private string environment;

        #region Cosntructor
        public Fish(string name, Image picture, Player owner,string environment):base(name,picture,owner)
        {
            this.Environment = environment;
        }
        #endregion

        #region Propertie
        public string Environment { get => environment; set => environment = value; }
        #endregion

        #region Method
        public override string DisplayData()
        {
            string data = base.DisplayPet() +
                         "\nEnvironment : " + this.Environment;

            return data;
        }
        public override void Feed(Player player)
        {
            base.Health += 20;
            base.Energy += 40;

            double coinPlus = 60 * 100 * 0.5;
            player.Coins += (int)coinPlus;
        }
        public void Clean (Player player)
        {
            //cek koin yang dimiliki player mencukupi atau tidak
            if(base.Owner.Coins >= 500)
            {
                base.Health += 60;
                base.Happiness += 50;
                double coinPlus = 30 * 100 * 0.5;
                player.Coins += (int)coinPlus - 500;
            }
            else
            {
                throw new Exception("You don't have enough Coins");
            }
        }

        #endregion
    }
}