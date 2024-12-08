using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422127_Audry
{
    [Serializable]
    public class Hamster : Pet
    {
        #region Data Member
        private string cage;
        #endregion

        #region Constructor
        public Hamster(string name, Image picture, Player owner,string cage):base(name,picture,owner)
        {
            this.Cage = cage;
        }
        #endregion

        #region Properties
        public string Cage { get => cage; set => cage = value; }
        #endregion

        public override string DisplayData()
        {
            string data = base.DisplayPet() +
                         "\nCage : " + this.Cage;

            return data;
        }

        public override void Feed(Player player)
        {
            base.Health += 30;
            base.Energy += 40;

            double coinPlus = 30 * 100 * 0.5;
            player.Coins += (int)coinPlus;
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
    }
}