using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Interfaces;

namespace DndConsole.Models.DiceModels
{
    public class D10 : IRollable
    {
        public int NumberOfSides => 10;
        public int Roll()
        {
            Random roller = new Random();
            return roller.Next(1, NumberOfSides);
        }
    }
}
