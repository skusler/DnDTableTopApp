using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Enums;
using DndConsole.Interfaces;

namespace DndConsole.Models
{
    public class Die
    {
        public int NumberOfSides { get; }
        public int Roll()
        {
            Random roller = new Random();
            return roller.Next(1, NumberOfSides);
        }

        public Die(int numberOfSides)
        {
            NumberOfSides = numberOfSides;
        }
    }
}
