using System;
using System.Collections.Generic;

namespace Task1_Gas_tank
{
    class Program
    {
        static void Main(string[] args)
        {
            var tank1 = new FuelTank(10, 20, 30);
            tank1.PrintInfo();
            tank1.FillTank("Gas");
            tank1.PrintInfo();
            Console.WriteLine("Full load will cost ₽" + tank1.FullTankCost);
            var tank2 = new FuelTank(10, 20);
            tank2.FillTank("Kerosene");
            tank2.PrintInfo();
            Console.WriteLine("Full load will cost ₽" + tank2.FullTankCost);
            var tank3 = new FuelTank(10);
            tank3.FillTank("Petrol");
            tank3.PrintInfo();
            Console.WriteLine("Full load will cost ₽" + tank3.FullTankCost);
            var tank4 = new FuelTank(20);
            tank4.FillTank("Bio-fuel");
            tank4.PrintInfo();
            Console.WriteLine("Full load will cost ₽" + tank4.FullTankCost);

        }
    }

    class FuelTank
    {
        private static readonly double gasPrice = 0.05;
        private static readonly double kerosenePrice = 0.08;
        private static readonly double petrolPrice = 0.1;

        private double length;
        private double height;
        private double width;

        public bool IsEmpty;

        public string FuelType;

        public double FullTankCost
        {
            get
            {
                double price;
                switch (FuelType)
                {
                    case "Gas": price = gasPrice; break;
                    case "Kerosene": price = kerosenePrice; break;
                    case "Petrol": price = petrolPrice; break;

                    default:
                        price = 0.2;
                        break;
                }

                return width * height * length * price;
            }
        }

        public void FillTank(string fuelType)
        {
            FuelType = fuelType;
            IsEmpty = false;
        }

        public FuelTank(double val)
        {
            height = val;
            width = val;
            length = val;
            IsEmpty = true;
            FuelType = null;
        }

        public FuelTank(double height, double width)
        {
            this.height = height;
            this.width = width;
            length = width;
            IsEmpty = true;
            FuelType = null;
        }

        public FuelTank(double height, double width, double length) : this(height, width)
        {
            this.length = length;
            IsEmpty = true;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{3} cm³ = {0} cm * {1} cm * {2} cm : {4}",
                length, width, height, length * width * height, IsEmpty ? "empty" : FuelType);
        }
    }

}
