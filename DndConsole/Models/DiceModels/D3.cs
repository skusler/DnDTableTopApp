using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Interfaces;

namespace DndConsole.Models.DiceModels
{
    public class D3: IRollable
    {
        public int NumberOfSides => 3;
        public int Roll()
        {
            Random roller = new Random();
            return roller.Next(1, NumberOfSides);
        }
    }
}
