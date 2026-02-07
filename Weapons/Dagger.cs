using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Dice_o_Clash
{
    public class Dagger : Weapons
    {
        public Dagger()
        {
            Name = "Dolch";
            DiceType = 4;
            DiceAmount = 3;

        }
    }
}