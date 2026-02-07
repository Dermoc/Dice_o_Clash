using Dice_o_Clash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dice_o_Clash
{
    internal class WeaponSelect
    {
        Random rnd = new Random();

        public Weapons WeaponPlayer()
        {
            // Holt alle Klassen aus deiner aktuellen Assembly
            var weaponTypes = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(Weapons)) && !t.IsAbstract)
                    .ToList();

            Console.WriteLine("Wähle deinen Waffe:");



            for (int i = 0; i < weaponTypes.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + weaponTypes[i].Name);
            }

            Console.WriteLine("Welche Waffe erhält dein Held: ");


            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= weaponTypes.Count)
            {
                Type selectedType = weaponTypes[choice - 1];

                // 3. Waffe instanziieren und als 'Weapons' zurückgeben

                Weapons playerWeapon = (Weapons)Activator.CreateInstance(selectedType);

                Console.WriteLine("Waffe " + playerWeapon.Name + " wurde ausgewählt.");
                return playerWeapon;
            }

            return null;

        }

        public Weapons WeaponNpc()
        {
            // Holt alle Klassen aus deiner aktuellen Assembly
            var weaponTypes = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(Weapons)) && !t.IsAbstract)
                    .ToList();


            // Zfallsauswahl der Waffe
            int randomWeapon = rnd.Next(0, weaponTypes.Count);

            // Die zufällige Waffe auswählen
            Type weaponSelect = weaponTypes[randomWeapon];

            Weapons npcWeapon = (Weapons)Activator.CreateInstance (weaponSelect);

            Console.WriteLine("Dein Gegner wählt die Waffe: " + npcWeapon.Name);


            return npcWeapon;

        }

    }
}
