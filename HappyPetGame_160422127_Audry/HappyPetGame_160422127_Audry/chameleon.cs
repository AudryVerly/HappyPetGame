using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422127_Audry
{
    [Serializable]
    public class Chameleon : Pet
    {
        private Color currentColor;

        #region Constructor
        public Chameleon(string name, Image picture, Player owner, Color currentColor) : base(name, picture, owner)
        {
            this.CurrentColor = currentColor;
        }
        #endregion

        #region Properties
        public Color CurrentColor { get => currentColor; set => currentColor = value; }
        #endregion

        #region Methods
        public override string DisplayData()
        {
            string data = base.DisplayPet() +
                          "\nCurrent Color : " + this.CurrentColor;
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
            base.Health += 60;
            base.Energy += 60;

            double coinPlus = 120 * 100 * 0.5;
            player.Coins += (int)coinPlus;
        }
        public void ChangedColor(Color newColor)
        {
            this.CurrentColor = newColor;
        }
        #endregion
    }
}