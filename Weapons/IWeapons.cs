using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dice_o_Clash
{
    public interface IWeapons
    {
        string Name { get; set; }
        int DiceType { get; set; }

        int DiceAmount { get; set; }


        // Jede Waffe hat einen Würfel D4, D6, D20 / 4, 6 ,20
        // Und eine Anzahl an würfeln
        // Es muss noch über´prüft werden was auf privat oder protected gesetzt werden kann.

    }
}