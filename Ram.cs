using System;

namespace GaryGarage
{
    public class Ram : Vehicle, IGasVehicles
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Ram growls by you, RRrrrrrummbbble!");
        }
    }
}