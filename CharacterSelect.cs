using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Reflection; // Brauche ich um automatisch die Klasse Character nach unterklassen zu scannen

namespace Dice_o_Clash
{
    public class CharacterSelect
    {

        public Character AuswahlPlayer()
        {
            // Holt alle Klassen aus deiner aktuellen Assembly
            var characterTypes = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(Character)) && !t.IsAbstract)
                    .ToList();

            Console.WriteLine("Wähle deinen Helden:");



            for (int i = 0; i < characterTypes.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + characterTypes[i].Name);
            }

            Console.WriteLine("Mit wem möchtest du Spielen: ");


            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= characterTypes.Count)
            {
                Type selectedType = characterTypes[choice - 1];

                // Erstellt die Instanz (z.B. den Elf) zur Laufzeit
                return (Character)Activator.CreateInstance(selectedType);
            }

            return null;

        }


        public Character AuswahlNpc()
        {
            // Holt alle Klassen aus deiner aktuellen Assembly
            var characterTypes = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(Character)) && !t.IsAbstract)
                    .ToList();

            Console.WriteLine("Wähle deinen Gegner:");



            for (int i = 0; i < characterTypes.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + characterTypes[i].Name);
            }

            Console.WriteLine("Gegen wen möchtest du kämpfen: ");


            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= characterTypes.Count)
            {
                Type selectedType = characterTypes[choice - 1];

                // Erstellt die Instanz (z.B. den Elf) zur Laufzeit
                return (Character)Activator.CreateInstance(selectedType);
            }

            return null;

        }




    }
}
    