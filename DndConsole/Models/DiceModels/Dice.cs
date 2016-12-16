using System.Collections.Generic;
using DndConsole.Interfaces;

namespace DndConsole.Models
{
    public class Dice
    {
        public List<IRollable> ListOfDice { get; private set; }

        public Dice(List<IRollable> listOfDice)
        {
            ListOfDice = listOfDice;
        }
    }
}