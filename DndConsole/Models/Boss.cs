﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Enums;
using DndConsole.Interfaces;

namespace DndConsole.Models
{
    public class Boss : IMonster
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Attributes Attributes { get; set; }
        public SpellList SpellList { get; set; }
        public LootTable Loot { get; set; }
    }
}
