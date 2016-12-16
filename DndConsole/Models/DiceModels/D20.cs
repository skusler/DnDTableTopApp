using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Interfaces;

namespace DndConsole.Models.DiceModels
{
    public class D20 : IRollable
    {
        public int NumberOfSides => 20;
        public int Roll()
        {
            Random roller = new Random();
            return roller.Next(1, NumberOfSides);
        }
    }
}
