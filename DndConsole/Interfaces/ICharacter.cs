using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Enums;
using DndConsole.Models;

namespace DndConsole.Interfaces
{
    interface ICharacter
    {
        string Name { get; set; }
        Race Race { get; set; }
        Job Job { get; set; }
        Attributes Attributes { get; set; }
        SpellList SpellList { get; set; }
        Inventory Inventory { get; set; }
    }
}
