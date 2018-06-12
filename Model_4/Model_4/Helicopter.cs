    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public sealed class Helicopter: VehicleBase
    {

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Helicopter() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="typeVehicle"></param>
        /// <param name="name"></param>
        /// <param name="serialNumber"></param>
        /// <param name="cost"></param>
        /// <param name="data"></param>
        /// <param name="speed"></param>
        /// <param name="range"></param>
        /// <param name="capacity"></param>
        public Helicopter(string typeVehicle, string name, string serialNumber, double cost, DateTime data, double speed, uint range, uint capacity)
            : base(typeVehicle, name, cost, data)
        {
            this.Speed = speed;
            this.Range = range;
            this.Capacity = capacity;
            this.SerialNumber = serialNumber;
        }

        #region Field

        /// <summary>
        /// The practical range (Max. 1200 km)
        /// </summary>
        private uint _range = 0;        

        /// <summary>
        /// Helicopter capacity (up to 8000 kg)
        /// </summary>
        private uint _capacity = 0;         

        /// <summary>
        /// Helicopter speed ( up to 200 km/h )
        /// </summary>
        private double _speed = 0;       

        #endregion Field

        #region Method

        /// <summary>
        /// The practical range (Max. 1200 km)
        /// </summary>
        public uint Range
        {
            get => _range;
            set
            {
                const int maxRange = 1200;
                _range = value;
                if (value > maxRange)
                {
                    throw new ArgumentException("The entered value is greater than the maximum value (1200 km) !");
                }
            }
        }

        /// <summary>
        /// Helicopter capacity (up to 8000 kg)
        /// </summary>
        public uint Capacity
        {
            get => _capacity;
            set
            {
                const int maxCapacity = 8000;
                _capacity = value;
                if (value > maxCapacity)
                {
                    throw new ArgumentException("The entered value is greater than the maximum value(8000 kg) !");
                }
            }
        }

        /// <summary>
        /// Helicopter speed ( up to 200 km/h )
        /// </summary>
        public double Speed
        {
            get => _speed;
            set
            {
                const double maxSpeed = 200;
                _speed = value;
                if (value > maxSpeed) 
                {
                    throw new ArgumentException("The entered value is greater than the maximum value (200 km / h ) !");
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
                if (!(IsSerialNumber(value)))
                {
                    throw new FormatException("Serial code entered incorrectly");
                }
                value = value.Trim();
                _serialNumber = value.ToUpper();
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
            return true;
        }
        #endregion Method
    }
}
