using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dice_o_Clash
{
    public interface ICharAttributes
    {
        // Standartwerte
        
        string Name { get; set; }

        int Hitpoints { get; set; }
        int Strength { get; set; }



        // Prozentwerte

        int Weaponskill { get; set; }

        int Blockskill {  get; set; } 

        int Luck { get; set; }

        int Attacks { get; set; }


        // Waffe

        void Attack();
        void Block();



    }
}