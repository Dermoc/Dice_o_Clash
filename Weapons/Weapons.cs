using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dice_o_Clash
{
    public abstract class Weapons : IWeapons    
    {

        public string Name { get; set; }
        public int DiceType { get; set; }

        public int DiceAmount { get; set; }


    }
}