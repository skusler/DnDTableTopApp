using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Enums;
using DndConsole.Models;

namespace DndConsole.Generators
{
    public static class NpcGenerator
    {
        public static NonPlayerCharacter Generate(NpcType type)
        {
            return new NonPlayerCharacter();
        }
    }
}
