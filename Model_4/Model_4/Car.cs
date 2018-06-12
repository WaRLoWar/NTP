using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public sealed class Car : VehicleBase
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Car()
        {

        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="typeVehicle"></param>
        /// <param name="name"></param>
        /// <param name="serialNumber"></param>
        /// <param name="cost"></param>
        /// <param name="data"></param>
        /// <param name="power"></param>
        /// <param name="consumption"></param>
        /// <param name="type"></param>
        public Car(string typeVehicle, string name, string serialNumber, double cost, DateTime data, double power,
            double consumption, string type)
            : base(typeVehicle, name, cost, data)
        {
            this.Power = power;
            this.Consumption = consumption;
            this.Type = type;
            this.SerialNumber = serialNumber;
        }

        #region Field

        /// <summary>
        /// Types of car interior
        /// </summary>
        private enum InteriorTypes
        {
            Mini,
            Sub,
            Compact,
            MidSize,
            Large,
            Null
        }

        /// <summary>
        /// Type of car interior
        /// </summary>
        private InteriorTypes _type = InteriorTypes.Null;

        /// <summary>
        /// The engine power of the car (up to 600 hp)
        /// </summary>
        private double _power = 0;

        /// <summary>
        /// The fuel consumption of a vehicle per 100 km (up to 20 L/ 100 km)
        /// </summary>
        private double _consumption = 0;

        #endregion Field

        #region Method

        /// <summary>
        /// The engine power of the car (up to 600 hp)
        /// </summary>
        public double Power
        {
            get => _power;
            set
            {
                // The maximum power of the car
                const uint maxValue = 600;
                _power = value;
                if (value > maxValue)
                {
                    throw new ArgumentException("Engine power must be less than 600 !");
                }
            }
        }

        /// <summary>
        /// The fuel consumption of a vehicle per 100 km (up to 20 L/ 100 km)
        /// </summary>
        public double Consumption
        {
            get => _consumption;
            set
            {
                const uint maxValue = 20;
                _consumption = value;
                if (value > maxValue)
                {
                    throw new ArgumentException("Fuel consumption more than 20 (liters / 100 km) !");                    
                }
            }
        }

        /// <summary>
        /// Type of car
        /// </summary>
        public string Type
        {
            get => Convert.ToString(_type);
            set
            {
                bool isCurrectionValue = false;
                InteriorTypes current;
                for (current = InteriorTypes.Mini; current != InteriorTypes.Null+1; current++)
                {
                    if (value == Convert.ToString(current))
                    {
                        _type = current;
                        isCurrectionValue = true;
                        break;
                    }
                }

                if (!isCurrectionValue)
                {
                    throw new ArgumentException("Type - Invalid character");
                }
            }
        }

        /// <summary>
        /// The serial number of the transport    
        /// </summary>
        public override string SerialNumber
        {
            get => _serialNumber;
            set
            {
                if (!(IsSerialNumber(value.ToUpper())))
                {
                    throw new FormatException("Serial code entered incorrectly");
                }
                else
                {
                    value = value.Trim();
                    _serialNumber = value.ToUpper();
                }
            }
        }

        /// <summary>
        /// Checking the serial number
        /// </summary>   
        protected override bool IsSerialNumber(string source)
        {
            source = source.Trim();
            if (source.Length != 17 || (string.IsNullOrWhiteSpace(source)))
            {
                return false;
            }
            else
            {
                return source.All(t => IsEnglisLetter(t) || IsNumber(t));
            }
        }
        #endregion Method
    }

}
 