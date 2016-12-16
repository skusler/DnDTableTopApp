using DndConsole.Enums;
using DndConsole.Exceptions;
using DndConsole.Interfaces;
using DndConsole.Models.DiceModels;

namespace DndConsole.Factories
{
    public static class DiceFactory
    {
        public static IRollable CreateDie(TypeOfDie type)
        {
            if (type == TypeOfDie.D2)
                return new D2();
            if (type == TypeOfDie.D3)
                return new D3();
            if (type == TypeOfDie.D6)
                return new D6();
            if (type == TypeOfDie.D10)
                return new D10();
            if (type == TypeOfDie.D20)
                return new D20();

            throw new DieTypeNotImplementedException();
        }   
    }
}
