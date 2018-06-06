using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    sealed public class Car : VehicleBase
    {
        public Car()
        {

        }
        public Car(char typeVehicle,string name, string serialNumber, double cost, DateTime data, double power, double consumption, string type) 
            : base(typeVehicle, name, cost, data)
        {
            
            this.Power = power;
            this.Consumption = consumption;
            this.Type = type;
            this.SerialNumber = serialNumber;
        }
        #region Private

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
            NULL
        }

        /// <summary>
        /// Type of car interior
        /// </summary>
        private InteriorTypes _type = InteriorTypes.NULL;
        
        /// <summary>
        /// The engine power of the car (up to 600 hp)
        /// </summary>
        private double _power = 0;

        /// <summary>
        /// The fuel consumption of a vehicle per 100 km (up to 20 L/ 100 km)
        /// </summary>
        private double _consumption = 0;

        #endregion Private

        #region Public and Protected

        /// <summary>
        /// The engine power of the car (up to 600 hp)
        /// </summary>
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
        
        /// <summary>
        /// The fuel consumption of a vehicle per 100 km (up to 20 L/ 100 km)
        /// </summary>
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

        /// <summary>
        /// Type of car interior
        /// { Mini = 0, Sub = 1, Compact = 2, MidSize = 3, Large = 4, NULL = 5 }
        /// </summary>
        //public int Type
        //{
        //    set
        //    {               
        //        if (Convert.ToInt32(value) < 0 || Convert.ToInt32(value) > 4)
        //        {
        //            throw new FormatException("Input error");
        //        }
        //        _type = (InteriorTypes)Convert.ToInt32(value);                
        //    }
        //}

        public string Type
        {
            get
            {
                return Convert.ToString(_type);
            }
            set
            {
                InteriorTypes c=InteriorTypes.Mini;
                for (int i = 0; i < 6; i++)
                {
                    if (value == Convert.ToString(c))
                    {
                        _type = c;
                        break;
                    }
                    c++;
                }
            }
        }
        /// <summary>
        /// Features of transport
        /// </summary>
        public override string PrintTransportsFeatures()
        {
            return Convert.ToString(Power + " " + Consumption + " " + Type);
        }

        /// <summary>
        /// The serial number of the transport    
        /// </summary>
        public override string SerialNumber
        {
            get
            {
                return _serialNumber;
            }
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

        /// <summary>
        /// Changing personal characteristics 
        /// | C - Consumption, P - Power, T - Type |
        /// </summary>
        public override void ChangePersonCharacteristics(string value, char symbol)
        {
            switch (symbol)
            {
                case 'P':
                    {
                        Power = Convert.ToDouble(value);
                        break;
                    }
                case 'C':
                    {
                        Consumption = Convert.ToDouble(value);
                        break;
                    }
                case 'T':
                    {
                        Type = Convert.ToString(value);
                        break;
                    }
                default:
                    {
                        throw new FormatException("You entered an incorrect character");                       
                    }
            }
        }

        #endregion Public and Protected
    }

}
 