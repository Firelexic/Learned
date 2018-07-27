using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
