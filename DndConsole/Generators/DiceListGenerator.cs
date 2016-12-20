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
        public static List<Die> Generate(int numberOfSides, int numberOfDie)
        {
            List<Die> dice = new List<Die>();

            for (int i = 0; i < numberOfDie; i++)
            {
                dice.Add(DiceFactory.CreateDie(numberOfSides));
            }

            return dice;
        }
    }
}
