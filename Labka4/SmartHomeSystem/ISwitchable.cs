using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSystem
{
    public interface ISwitchable
    {
        void TurnOn();
        void TurnOff();
        bool IsOn { get; }
    }
}
