using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_4
{
    sealed public class Car : VehicleBase
    {
        /// <summary>
        /// Types of car interior
        /// </summary>
        private enum InteriorTypes
        {
            Mini,
            Sub,
            Compact,
            MidSize,
            Large
        }

        /// <summary>
        /// Type of car interior
        /// </summary>
        private InteriorTypes _type;
        
        /// <summary>
        /// The engine power of the car (up to 600 hp)
        /// </summary>
        private double _power;

        /// <summary>
        /// The fuel consumption of a vehicle per 100 km (up to 20 L/ 100 km)
        /// </summary>
        private double _consumption;

        public double Power
        {
            get
            {
                return _power;
            }
            set
            {
                try
                {
                    _power = Convert.ToDouble(value);
                    if (Convert.ToDouble(value) > 600)
                    {
                        throw new Exception("Engine power must be less than 600 !");
                    }
                   
                }
                catch (FormatException)
                {
                    throw new FormatException("Incorrect power value of the car was entered !");
                }
            }
        }
        public double Consumption
        {
            get
            {
                return _consumption;
            }
            set
            {
                try
                {
                    _consumption = Convert.ToDouble(value);
                    if (Convert.ToDouble(value) > 20)
                    {
                        throw new FormatException("Fuel consumption more than 20 (liters / 100 km) !");
                    }
                }
                catch (FormatException)
                {
                    throw new FormatException("Format Exception");
                }
                
            }
        }

        public int Type
        {
            set
            {
                if (Convert.ToInt32(value) < 0 || Convert.ToInt32(value) > 4)
                {
                    throw new FormatException("Input error");
                }
                _type = (InteriorTypes)Convert.ToInt32(value);
                
            }
        }


        protected override bool IsSerialNumber(string source)
        {
            source = source.Trim();
            if (source.Length != 17 || (string.IsNullOrWhiteSpace(source)))
            {
                return false;
            }
            else
            {
                source = source.ToUpper();
                for (int i = 0; i < source.Length; i++) 
                {
                    if (!(IsEnglisLetter(source[i])) && !(IsNumber(source[i])))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public override string PrintTransportsFeatures()
        {
            return Convert.ToString(Power + " " + Consumption + " " + _type);
        }

        public override string SerialNumber
        {
            get
            {
                return _serialNumber;
            }
            set
            {
                if (!(IsSerialNumber(value)))
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
    }

}
 