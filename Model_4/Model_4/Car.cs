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
        public Car() {}

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
        private double _power = 0.0;

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
                const double maxValue = 600.0;
                const double minValue = 0.0;
                if (value > maxValue || value < minValue)
                {
                    throw new ArgumentException("Engine power must be less than 600 !");
                }
                _power = value;              
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
                const double maxValue = 20.0;
                const double minValue = 0.0;
                _consumption = value;
                if (value > maxValue || value < minValue)
                {
                    throw new ArgumentException("Fuel consumption more than 20 (liters / 100 km) !");                    
                }
            }
        }

        /// <summary>
        /// Type of car
        /// [ Mini / Sub / Compact / MidSize / Large / Null ]
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
        /// The serial number of the transport.
        /// The number consists of 17 digits and symbols of the English alphabet
        /// </summary>
        public override string SerialNumber
        {
            get => _serialNumber;
            set
            {
                value = value.Trim();
                value = value.ToUpper();
                if (!IsSerialNumber(value))
                {
                    throw new FormatException("Serial code 'Car' entered incorrectly");
                }

                _serialNumber = value;
            }
        }

        /// <summary>
        /// Checking the serial number
        /// </summary>   
        protected override bool IsSerialNumber(string source)
        {
            if (source.Length != 17 && !string.IsNullOrWhiteSpace(source))
            {
                return false;
            }            
            if (source.Length == 17)
            {
                return source.All(t => IsEnglisLetter(t) || IsNumber(t));
            }
            return string.IsNullOrWhiteSpace(source);
        }
        #endregion Method
    }

}
 