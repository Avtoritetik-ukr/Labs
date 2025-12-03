using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        public List<ISwitchable> _switchables = new List<ISwitchable>();
        public List<IEnergyConsumer> _energyConsumers = new List<IEnergyConsumer>();
        public void AddDevice(ISwitchable device)
        {
               _switchables.Add(device);
        }
        public void AddEnergyDevice(IEnergyConsumer device)
        {
            _energyConsumers.Add(device);
        }
        public void TurnAllOn()
        {
            foreach (var device in _switchables)
            {
                device.TurnOn();
            }
        }
        public void TurnAllOff()
        {
            foreach (var device in _switchables)
            {
                device.TurnOff();
            }
        }
        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"Звіт про споживання енергії за {hours} год:");
            double totalEnergy = 0;
            foreach (var device in _energyConsumers)
            {
                double usage = device.GetEnergyUsage(hours);
                totalEnergy += usage;
                Console.WriteLine($"{device.DeviceName}: {usage:F2} кВт·год (потужність: {device.PowerConsumption} Вт)");
            }
            Console.WriteLine($"Загальне споживання: {totalEnergy:F2} кВт·год");
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {totalEnergy * 4:F2} грн");
        }
    }
}
