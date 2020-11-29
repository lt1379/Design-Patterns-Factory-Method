using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Factory_Method
{
    public class CoolingManager : IAirConditioner
    {
        private readonly double _temperature;

        public CoolingManager(double temperature)
        {
            _temperature = temperature;
        }
        public void Operate()
        {
            Console.WriteLine($"Cooling the rom to the required temperatur of {_temperature} degrees");
        }
    }
}
