using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Factory_Method
{
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature)
            => new WarmingManager(temperature);
    }
}
