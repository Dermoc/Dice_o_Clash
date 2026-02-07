using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_o_Clash
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CharacterSelect auswahl = new CharacterSelect();

            Character playerSelect = auswahl.AuswahlPlayer();

            Console.WriteLine("Deine Auswahl " + playerSelect.Name + " wurde erstellt!");

            Character npcSelect = auswahl.AuswahlNpc();

            Console.WriteLine("Dein Gegner " + npcSelect.Name + " wurde erstellt!");


            Console.ReadKey();
        }
    }
}
