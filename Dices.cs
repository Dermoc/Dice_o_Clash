using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dice_o_Clash
{
    public class Dices
    {


        

        Random rnd = new Random();


        public int DiceRollD4()
        {
            

            return rnd.Next(1, 5);

        }

        public int DiceRollD6()
        {
            

            return rnd.Next(1, 7);

        }


        public int DiceRollD20()
        {
            

            return rnd.Next(1, 21);

        }

        public int DiceRollD100()
        {


            return rnd.Next(1, 101);

        }



    }
}