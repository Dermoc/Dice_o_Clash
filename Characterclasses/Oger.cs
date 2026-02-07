using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dice_o_Clash
{
    public class Oger : Character
    {
        public Oger()

        {
            Name = "Der Oger";
            Hitpoints = 150;
            Strength = 5;
            Blockskill = 5;
            Luck = 2;
            Weaponskill = 30;
            Attacks = 1;
        }

        public override void Attack() { }
        public override void Block() { }
    }
}