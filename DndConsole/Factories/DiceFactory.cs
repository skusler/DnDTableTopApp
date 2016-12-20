using DndConsole.Enums;
using DndConsole.Exceptions;
using DndConsole.Interfaces;
using DndConsole.Models;

namespace DndConsole.Factories
{
    public static class DiceFactory
    {
        public static Die CreateDie(int numberOfSides)
        {
            Die die = new Die(numberOfSides);
            return die;
        }   
    }
}
