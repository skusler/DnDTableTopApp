using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndConsole.Enums;
using DndConsole.Models;

namespace DndConsole.Generators
{
    static class LandscapeGenerator
    {
        //Will generate some kinds of landscapes.  Currently thinking using two overloads.
        public static Landscape Generate(LandscapeType type)
        {
            return new Landscape();
        }
        public static Landscape Generate(LandscapeType type1, LandscapeType type2)
        {
            return new Landscape();
        }
    }
}
