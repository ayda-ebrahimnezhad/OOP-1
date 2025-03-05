using System;

namespace OOP_1
{
    internal class Program
    {
        public class Benz
        {
            public bool IsEngineStarted { get; private set; }
            public bool AreElectronicServicesStarted { get; private set; }
            public bool IsLightSystemStarted { get; private set; }

            public void SetEngineStatus(bool status) => IsEngineStarted = status;
            public void SetElectronicServicesStatus(bool status) => AreElectronicServicesStarted = status;
            public void SetLightSystemStatus(bool status) => IsLightSystemStarted = status;

            public bool Start()
            {
                return IsEngineStarted && AreElectronicServicesStarted && IsLightSystemStarted;
            }
        }

        static void Main(string[] args)
        {
            var myCar = new Benz();
            
            myCar.SetEngineStatus(true);
            myCar.SetElectronicServicesStatus(true);
            myCar.SetLightSystemStatus(true);

            bool isCarStarted = myCar.Start();
            Console.WriteLine($"Is car started? {isCarStarted}");
        }
    }
}
