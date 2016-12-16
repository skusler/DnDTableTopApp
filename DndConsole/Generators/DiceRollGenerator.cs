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
        public int RollDice(Dice dice)
        {
            int value = 0;
            foreach (IRollable die in dice.ListOfDice)
            {
                value += die.Roll();
            }

            return value;
        }
    }
}
