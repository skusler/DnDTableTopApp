using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Enums;
using DndConsole.Models;

namespace DndConsole.Interfaces
{
    public interface IMonster
    {
        string Name { get; set; }
        int Level { get; set; }
        Attributes Attributes { get; set; }
        SpellList SpellList { get; set; }
        LootTable Loot { get; set; }
    }
}
