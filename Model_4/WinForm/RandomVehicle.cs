using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace WinForm
{
    class RandomVehicle
    {
        #region Random Vehicle
        private Random _rand = new Random();
        private Random _getData = new Random();
        public IVehicle GetRandomVehicle()
        {
            Random rand = new Random();
            int value = rand.Next(3);
            IVehicle newVehicle = null;
            switch (value)
            {
                case 0:
                    {
                        newVehicle = GetRandomCar();
                        break;
                    }
                case 1:
                    {
                        newVehicle = GetRandomBoat();
                        break;
                    }
                case 2:
                    {
                        newVehicle = GetRandomHelicopter();
                        break;
                    }
            }
            return newVehicle;
        }

        private Car GetRandomCar()
        {
            Car newCar = new Car();
            newCar.TypeVehicle = "Car";
            newCar.Name = RandomName(4);
            newCar.SerialNumber = RandomSerialNumber(newCar);
            newCar.Consumption = _rand.Next(20);
            newCar.Power = _rand.NextDouble() * 600;
            newCar.Type = "Null";
            newCar.Cost = _rand.Next(2000);
            newCar.ManufacturesYear = RandomDay();
            return newCar;
        }

        private Boat GetRandomBoat()
        {
            Boat newBoat = new Boat();
            newBoat.TypeVehicle = "Boat";
            newBoat.Name = RandomName(4);
            newBoat.SerialNumber = RandomSerialNumber(newBoat);
            newBoat.ManufacturesYear = RandomDay();
            newBoat.Cost = _rand.Next(2000);
            newBoat.Draft = _rand.NextDouble() * 80;
            newBoat.Speed = _rand.NextDouble() * 80;
            newBoat.BoatCapacity = Convert.ToUInt32(_rand.Next(1, 18));
            return newBoat;
        }

        private Helicopter GetRandomHelicopter()
        {
            Helicopter newHelicopter = new Helicopter();
            newHelicopter.TypeVehicle = "Helicopter";
            newHelicopter.Name = RandomName(6);
            newHelicopter.SerialNumber = RandomSerialNumber(newHelicopter);
            newHelicopter.ManufacturesYear = RandomDay();
            newHelicopter.Cost = _rand.Next(500000);
            newHelicopter.Range = Convert.ToUInt32(_rand.Next(1200));
            newHelicopter.Speed = _rand.Next(200);
            newHelicopter.Capacity = Convert.ToUInt32(_rand.Next(7000));
            return newHelicopter;
        }

        private DateTime RandomDay()
        {
            DateTime start = new DateTime(1950, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(_getData.Next(range));
        }

        private string RandomName(int length)
        {
            string name = null;
            for (int i = 0; i < length; i++)
            {
                int value = _rand.Next(65, 90);
                name += (char)value;
            }
            return name;
        }

        private string RandomSerialNumber(IVehicle vehicle)
        {
            string number = null;
            if (vehicle is Car)
            {
                number = GetSymbol(17);
            }
            else if (vehicle is Boat)
            {
                number = GetSymbol(8);
            }
            else
            {
                number = RandomName(4);
                number += GetSymbol(6);
            }
            return number;
        }

        private string GetSymbol(int length)
        {
            int value = 0;
            string text = null;
            for (int i = 0; i < length; i++)
            {
                value = _rand.Next(1, 10);
                text += Convert.ToString(value);
            }
            return text;
        }
        #endregion Random Vehicle
    }
}
