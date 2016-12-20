using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Interfaces;
using DndConsole.Models;

namespace DndConsole.Generators
{
    public class DiceRollGenerator
    {
        public int RollDie(Die die)
        {
            return die.Roll();
        }

        public int RollDice(List<Die> dice)
        {
            int value = 0;
            foreach (Die die in dice)
            {
                value += die.Roll();
            }

            return value;
        }
    }
}
