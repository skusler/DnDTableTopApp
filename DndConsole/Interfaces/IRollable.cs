using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndConsole.Interfaces
{
    public interface IRollable
    {
        int NumberOfSides { get; }
        int Roll();
    }
}
