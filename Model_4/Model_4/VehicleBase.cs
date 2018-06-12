using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Model
{
    public abstract class VehicleBase: IVehicle
    {

        /// <summary>
        /// Empty constructor
        /// </summary>
        protected VehicleBase() { }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="typeVehicle"></param>
        /// <param name="name"></param>
        /// <param name="cost"></param>
        /// <param name="data"></param>
        protected VehicleBase(string typeVehicle, string name, double cost, DateTime data)
        {
            this.TypeVehicle = typeVehicle;
            this.Name = name;            
            this.Cost = cost;
            this.ManufacturesYear = data;
        }

        #region Field
        /// <summary>
        /// Types of vehicles
        /// </summary>
        private enum VehiclesTypes
        {
            Car,
            Boat,
            Helicopter,            
        }

        /// <summary>
        /// The name of the transport
        /// </summary>
        private string _name = null;

        /// <summary>
        /// The serial number of the transport    
        /// </summary>
        protected string _serialNumber = null;

        /// <summary>
        /// The cost of transport       
        /// </summary>
        private double _cost = 0;

        /// <summary>
        /// Year of manufacture
        /// </summary>   
        private DateTime _manufacturesYear = new DateTime();

        /// <summary>
        /// Type of Vehicle
        /// </summary>
        private VehiclesTypes _vehiclesTypes;

        #endregion Field

        #region Method

        /// <summary>
        /// Type of Vehicle
        /// </summary>
        public string TypeVehicle
        {
            get => Convert.ToString(_vehiclesTypes);
            set
            {
                bool isCorrectionValue = false;
                VehiclesTypes current;
                for (current = VehiclesTypes.Car; current != VehiclesTypes.Helicopter + 1; current++)
                {
                    if (value == Convert.ToString(current))
                    {
                        _vehiclesTypes = current;
                        isCorrectionValue = true;
                        break;
                    }
                }
                if (!isCorrectionValue)
                {
                    throw new ArgumentException("Invalid character");
                }

            }
        }

        /// <summary>
        /// The name of the transport
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                value = value.ToUpper();
                if (!(IsName(value)))
                {
                    throw new FormatException("Name entered incorrectly !");
                }
                _name = value;
            }
        }

        /// <summary>
        /// The cost of transport       
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                if (value < 0)
                {
                    throw new Exception("You entered a negative number");
                }
                _cost = value;
            }
        }

        /// <summary>
        /// Year of manufacture
        /// </summary>       
        public DateTime ManufacturesYear
        {
            get => _manufacturesYear;
            set
            {
                if (DateTime.Now < value)
                {
                    throw new Exception("Incorrect date entered");
                }
                _manufacturesYear = Convert.ToDateTime(value);
            }
        }

        /// <summary>
        /// Checking the serial number
        /// </summary>   
        protected abstract bool IsSerialNumber(string source);

        /// <summary>
        /// Checking for the symbol of the English alphabet
        /// </summary>
        protected bool IsEnglisLetter(char symbol)
        {                   
            return (symbol >= 'A' || symbol <= 'Z');
        }

        /// <summary>
        /// Сhecking whether the number is a character
        /// </summary>        
        protected bool IsNumber(char symbol)
        {
            return char.IsDigit(symbol);                        
        }       

        /// <summary>
        /// The serial number of the transport    
        /// </summary>
        public abstract string SerialNumber { get; set; }

        /// <summary>
        /// Name validation
        /// </summary>        
        private bool IsName(string source)
        {
            foreach (var current in source)
            {
                if (!(IsEnglisLetter(current)) && !(IsNumber(current)))
                {
                    return false;
                }
            }
            return true;
        }
       
        #endregion Method


    }
}
