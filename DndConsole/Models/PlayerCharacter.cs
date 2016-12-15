﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Enums;
using DndConsole.Interfaces;

namespace DndConsole.Models
{
    class PlayerCharacter : ICharacter
    {
        public string Name { get; set; }
        public Race Race { get; set; }
        public Job Job { get; set; }
        public Attributes Attributes { get; set; }
        public SpellList SpellList { get; set; }
        public Inventory Inventory { get; set; }
    }
}