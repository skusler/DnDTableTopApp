using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Enums;
using DndConsole.Factories;
using DndConsole.Interfaces;
using DndConsole.Models;

namespace DndConsole.Generators
{
    public static class DiceListGenerator
    {
        public static Dice Generate(TypeOfDie type, int numberOfDie)
        {
            List<IRollable> dice = new List<IRollable>();

            for (int i = 0; i < numberOfDie; i++)
            {
                dice.Add(DiceFactory.CreateDie(type));
            }

            return new Dice(dice);
        }
    }
}
