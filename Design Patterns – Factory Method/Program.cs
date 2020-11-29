using System;

namespace Design_Patterns___Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            AirConditioner
                .InitializeFactories()
                .ExecuteCreation(Actions.Cooling, 22).Operate();
        }
    }
}
