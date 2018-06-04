using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    sealed public class Boat: VehicleBase
    {
        public Boat() { }
        public Boat(string name, string serialNumber, double cost, DateTime data, double speed, double draft, short capacity)
            : base(name, cost, data)
        {
            this.Speed = speed;
            this.Draft = draft;
            this.BoatCapacity = capacity;
            this.SerialNumber = serialNumber;
        }
        #region Private

        /// <summary>
        /// The maximum speed of the boat (Max. 80 (km/h) )
        /// </summary>
        private double _speed = 0;

        /// <summary>
        /// Maximum speed value
        /// </summary>
        private const double _MaxSpeed = 80;

        /// <summary>
        /// Boat draft (Max 80 cm )
        /// </summary>
        private double _draft = 0;

        /// <summary>
        /// Maximum boat draft value
        /// </summary>
        private const double _MaxDraft = 80;

        /// <summary>
        /// The capacity of the boat
        /// </summary>
        private int _boatCapacity = 0;

        /// <summary>
        /// Maximum boat capacity value
        /// </summary>
        private const int _MaxBoatCapacity = 18;

        #endregion Private

        #region Public and Protected

        /// <summary>
        /// The maximum speed of the boat
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
                    if (Convert.ToDouble(value) > _MaxSpeed)
                    {
                        throw new Exception("Entered speed greater than maximum speed !( 80 km/h )");
                    }
                }
                catch (FormatException)
                {
                    throw new FormatException("Format Exception ! ");
                }
            }
        }

        /// <summary>
        /// Boat draft (Max 80 cm )
        /// </summary>
        public double Draft
        {
            get
            {
                return _draft;
            }
            set
            {
                try
                {
                    _draft = Convert.ToDouble(value);
                    if(Convert.ToDouble(value) > _MaxDraft)
                    {
                        throw new Exception("The entered value of the boat draught is greater than the maximum value ! ( 80 cm )");
                    }
                }
                catch(FormatException)
                {
                    throw new FormatException("Format Exception");
                }
            }
        }

        /// <summary>
        /// The capacity of the boat
        /// </summary>
        public int BoatCapacity
        {
            get
            {
                return _boatCapacity;
            }
            set
            {
                try
                {
                    _boatCapacity = Convert.ToInt16(value);
                    if (Convert.ToInt16(value) > _MaxBoatCapacity)
                    {
                        throw new Exception("The entered boat capacity value is greater than the maximum value ! ( 18 )");
                    }
                }
                catch (FormatException)
                {
                    throw new FormatException("Format Exception !");
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
            return Convert.ToString(Speed + " " + Draft + " " + BoatCapacity);
        }

        /// <summary>
        /// Changing personal characteristics 
        /// | S - Speed, D - Draft, B - BoatCapacity |
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
                case 'D':
                    {
                        Draft = Convert.ToDouble(value);
                        break;
                    }
                case 'B':
                    {
                        BoatCapacity = Convert.ToInt16(value);
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
            if ((source.Length != 8) || (source.Length != 12) || (string.IsNullOrWhiteSpace(source)))
            {
                return false;
            }
            else
            {
                for (int i = 0; i < source.Length; i++)
                {
                    if (!IsNumber(source[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion Public and Protected
    }
}
