using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public sealed class Boat: VehicleBase
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Boat() { }

        #region Field

        /// <summary>
        /// The maximum speed of the boat (Max. 80 (km/h) )
        /// </summary>
        private double _speed = 0;  

        /// <summary>
        /// Boat draft (Max 80 cm )
        /// </summary>
        private double _draft = 0;

        /// <summary>
        /// The capacity of the boat (Max. 18)
        /// </summary>
        private uint _boatCapacity = 0;

        #endregion Field

        #region Method

        /// <summary>
        /// The maximum speed of the boat (Max. 80 (km/h) )
        /// </summary>
        public double Speed
        {
            get => _speed;
            set
            {                
                const double maxSpeed = 80.0;
                const double minSpeed = 0.0;
                _speed = value;
                if (value > maxSpeed || value < minSpeed)
                {
                    throw new ArgumentException("Entered speed greater than maximum speed !( 80 km/h )");
                }
            }
        }

        /// <summary>
        /// Boat draft (Max 80 cm )
        /// </summary>
        public double Draft
        {
            get => _draft;
            set
            {
                const double maxDraft = 80.0;
                const double minDraft = 0.0;
                _draft = value;
                if(value > maxDraft || value < minDraft)
                {
                    throw new ArgumentException("The entered value of the boat draught is greater than the maximum value ! ( 80 cm )");
                }

            }
        }

        /// <summary>
        /// The capacity of the boat (Max. 18)
        /// </summary>
        public uint BoatCapacity
        {
            get => _boatCapacity;
            set
            {
                const uint maxBoatCapacity = 18;
                _boatCapacity = value;
                if (value > maxBoatCapacity)
                {
                    throw new ArgumentException("The entered boat capacity value is greater than the maximum value ! ( 18 )");
                }
            }
        }

        /// <summary>
        /// The serial number of the transport.
        /// The length of the string 8 or 12 and composed of numbers only
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
            const uint firstConstLength = 8;
            const uint secondConstLength = 12;
            if ((source.Length != firstConstLength) && (source.Length != secondConstLength) || (string.IsNullOrWhiteSpace(source)))
            {
                return false;
            }
            return source.All(IsNumber);
        }

      
        #endregion Method
    }
}
