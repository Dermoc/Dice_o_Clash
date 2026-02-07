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
            WeaponSelect waffenAuswahl = new WeaponSelect();

            Console.WriteLine("Dice_o_Clash");
            Console.WriteLine("written by Rainer Kleinmaier\n");

            Console.WriteLine("Drücke eine Taste zum Starten!\n");

            Console.ReadKey();

            //Player

            Character playerSelect = auswahl.AuswahlPlayer();

            Console.WriteLine("Deine Auswahl " + playerSelect.Name + " wurde erstellt!");

            playerSelect.SetWeapon = waffenAuswahl.WeaponPlayer();

            Console.WriteLine(playerSelect.Name + " führt nun die Waffe: " + playerSelect.SetWeapon.Name);


            // NPC



            Character npcSelect = auswahl.AuswahlNpc();

            Console.WriteLine("\nDein Gegner " + npcSelect.Name + " wurde erstellt!");
            npcSelect.SetWeapon = waffenAuswahl.WeaponNpc();
            Console.WriteLine(npcSelect.Name + " führt die Waffe: " + npcSelect.SetWeapon.Name);




            Console.ReadKey();
        }
    }
}
