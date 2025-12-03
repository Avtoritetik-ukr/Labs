using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSystem
{
    public interface IEnergyConsumer
    {
        string DeviceName { get; }
        int PowerConsumption { get; }
        double GetEnergyUsage(int hours);
    }
}
