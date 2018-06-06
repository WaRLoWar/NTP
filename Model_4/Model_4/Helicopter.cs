    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    sealed public class Helicopter: VehicleBase
    {        
        
        public Helicopter() { }
        public Helicopter(char typeVehicle, string name, string serialNumber, double cost, DateTime data, double speed, double range, short capacity)
            : base(typeVehicle, name, cost, data)
        {
            this.Speed = speed;
            this.Range = range;
            this.Capacity = capacity;
            this.SerialNumber = serialNumber;
        }

        #region Private

        /// <summary>
        /// The practical range (Max. 1200 km)
        /// </summary>
        private int _range = 0;

        /// <summary>
        /// Maximum practical range value
        /// </summary>
        private const int _MaxRange = 1200;

        /// <summary>
        /// Helicopter capacity (up to 8000 kg)
        /// </summary>
        private int _capacity = 0;

        /// <summary>
        /// Maximum helicopter`s capacity value
        /// </summary>
        private const int _MaxHelicopterCapacity = 8000;

        /// <summary>
        /// Helicopter speed ( up to 200 km/h )
        /// </summary>
        private double _speed = 0;
        /// <summary>
        /// Maximum speed of the helicopter
        /// </summary>
        private const double _MaxSpeed = 200;

        #endregion Private

        #region Public and Protected
        /// <summary>
        /// The practical range (Max. 1200 km)
        /// </summary>
        public double Range
        {
            get
            {
                return _range;
            }
            set
            {
                try
                {
                    _range = Convert.ToInt16(value);
                    if (Convert.ToInt16(value) > _MaxRange)
                    {
                        throw new Exception("The entered value is greater than the maximum value (1200 km) !");
                    }
                }
                catch(FormatException)
                {
                    throw new FormatException("Format Exception !");
                }
            }
        }

        /// <summary>
        /// Helicopter capacity (up to 8000 kg)
        /// </summary>
        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                try
                {
                    _capacity = Convert.ToInt16(value);
                    if (Convert.ToInt16(value) > _MaxHelicopterCapacity)
                    {
                        throw new Exception("The entered value is greater than the maximum value(8000 kg) !");
                    }
                }
                catch (FormatException)
                {
                    throw new FormatException("Format Exception");
                }
            }
        }

        /// <summary>
        /// Helicopter speed ( up to 200 km/h )
        /// </summary>
        public double Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                try
                {
                    _speed = Convert.ToDouble(value);
                    if(Convert.ToDouble(value)>_MaxSpeed)
                    {
                        throw new Exception("The entered value is greater than the maximum value (200 km / h ) !");
                    }
                }
                catch (FormatException)
                {
                    throw new FormatException("Format Exception");
                }
            }
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

        /// <summary>
        /// Features of transport
        /// </summary>
        public override string PrintTransportsFeatures()
        {
            return Convert.ToString(Speed + " " + Range + " " + Capacity);
        }

        /// <summary>
        /// Changing personal characteristics 
        /// | S - Speed, R - Range, C- Capacity |
        /// </summary>
        public override void ChangePersonCharacteristics(string value, char symbol)
        {
            switch (symbol)
            {
                case 'S':
                    {
                        Speed = Convert.ToDouble(value);
                        break;
                    }
                case 'R':
                    {
                        Range = Convert.ToDouble(value);
                        break;
                    }
                case 'C':
                    {
                        Capacity = Convert.ToInt16(value);
                        break;
                    }
                default:
                    {
                        throw new FormatException("You entered an incorrect character");
                    }
            }
        }

        /// <summary>
        /// Checking the serial number
        /// </summary>   
        protected override bool IsSerialNumber(string source)
        {
            source = source.Trim();
            if ((source.Length != 10) || (string.IsNullOrWhiteSpace(source)))
            {
                return false;
            }
            else
            {
                for (int i = 0; i < source.Length; i++)
                {
                    if (i < 4)
                    {
                        if (!(IsEnglisLetter(source[i])))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if ((!IsNumber(source[i])))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        
        #endregion Public and Protected
    }
}
