using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dice_o_Clash
{
    public class Halfling : Character
    {

        public Halfling()

        {
            Name = "Der Halbling";
            Hitpoints = 90;
            Strength = 1;
            Blockskill = 20;
            Luck = 35;
            Weaponskill = 30;
            Attacks = 3;

        }

        public override void Attack() { }
        public override void Block() { }
    }
}