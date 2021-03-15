using System;


namespace GaryGarage
{
    public class Cessna : Vehicle, IGasVehicles
    {
        public double FuelCapacity { get; set; }

        public double CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Cessna zooms by you, Zoooooom!");
        }

        public override void Turn()
        {
            Console.WriteLine($"The cessna turns elegantly.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The cessna comes to a safe stop");
        }
    }

}