using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dice_o_Clash
{
    public abstract class Character : ICharAttributes
    {

        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public int Strength { get; set; }
        public int Blockskill { get; set; }
        public int Luck { get; set; }
        public int Weaponskill { get; set; }

        public int Attacks { get; set; }



        // Methoden

        public abstract void Attack();

        public abstract void Block();



    }
}