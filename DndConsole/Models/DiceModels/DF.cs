using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Interfaces;

namespace DndConsole.Models.DiceModels
{
    public class DF : IRollable
    {
        public int NumberOfSides => 3;
        public int Roll()
        { // This is for fate games. Normally one will roll 4 of these and add them together for an outcome between -4 and +4
            Random roller = new Random();
            return (roller.Next(1, NumberOfSides)-2);
        }
    }
}
