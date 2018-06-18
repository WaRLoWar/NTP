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
                const uint maxRange = 1200;
                if (value > maxRange)
                {
                    throw new ArgumentException("The entered value is greater than the maximum value (1200 km) !");
                }
                _range = value;                
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
                const uint maxCapacity = 8000;
                if (value > maxCapacity)
                {
                    throw new ArgumentException("The entered value is greater than the maximum value(8000 kg) !");
                }
                _capacity = value;                
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
                const double minSpeed = 0;
                if (value > maxSpeed || value < minSpeed)
                {
                    throw new ArgumentException("The entered value is greater than the maximum value (200 km / h ) !");
                }
                _speed = value;                
            }
        }

        /// <summary>
        /// The serial number of the transport.
        /// The number consists of 10 characters,
        /// the first 4 of which are letters of the English alphabet, and the other 6 are numbers. 
        /// </summary>
        public override string SerialNumber
        {
            get => _serialNumber;
            set
            {
                value = value.Trim();
                value = value.ToUpper();
                if (!(IsSerialNumber(value)))
                {
                    throw new FormatException("Serial code 'Helicopter' entered incorrectly");
                }
                _serialNumber = value;
            }
        }

        /// <summary>
        /// Checking the serial number.     
        /// </summary>   
        protected override bool IsSerialNumber(string source)
        {            
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
