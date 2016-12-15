using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Enums;
using DndConsole.Interfaces;

namespace DndConsole.Models
{
    public class Monster : IMonster
    {
        public string Name { get; set; }
        public Attributes Attributes { get; set; }
        public SpellList SpellList { get; set; }
        public LootTable Loot { get; set; }
    }
}
