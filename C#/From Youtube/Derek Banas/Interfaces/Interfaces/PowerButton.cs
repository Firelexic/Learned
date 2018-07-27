using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class PowerButton : ICommand
    {
        IElectronicDevice device;

        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
}
