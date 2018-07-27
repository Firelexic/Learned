using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class TVRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
