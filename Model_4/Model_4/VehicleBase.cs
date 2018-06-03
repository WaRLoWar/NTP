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

        protected VehicleBase() { }
        protected VehicleBase(string name, double cost, DateTime data)
        {
            this.Name = name;            
            this.Cost = cost;
            this.ManufacturesYear = data;
        }
        // ------------ Private fields and methods  ------------ //
        #region Private

        /// <summary>
        /// The name of the transport
        /// </summary>
        private string _name = null;

        /// <summary>
        /// The cost of transport       
        /// </summary>
        private double _cost = 0;

        /// <summary>
        /// Year of manufacture
        /// </summary>   
        private DateTime _manufacturesYear = new DateTime();

        /// <summary>
        /// Name validation
        /// </summary>        
        private bool IsName(string source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (!(IsEnglisLetter(source[i])) && !(IsNumber(source[i])))
                {
                    return false;
                }
            }
            return true;
        }

        #endregion Private
        // ------------ Public / Protected fields and methods  ------------ //
        #region Public
       
        /// <summary>
        /// The serial number of the transport    
        /// </summary>
        protected string _serialNumber = null;

        /// <summary>
        /// Checking the serial number
        /// </summary>   
        protected abstract bool IsSerialNumber(string source);

        /// <summary>
        /// Checking for the symbol of the English alphabet
        /// </summary>
        protected bool IsEnglisLetter(char symbol)
        {                   
            return ((symbol < 'A' || symbol > 'Z') ? false : true);
        }

        /// <summary>
        /// Сhecking whether the number is a character
        /// </summary>        
        protected bool IsNumber(char symbol)
        {
            return Char.IsDigit(symbol);            
        }

        /// <summary>
        /// The name of the transport
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
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
            get
            {
                return _cost;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new Exception("You entered a negative number");
                    }
                    _cost = Convert.ToDouble(value);
                    
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
        public abstract string SerialNumber { get; set; }
        
        /// <summary>
        /// Year of manufacture
        /// </summary>       
        public DateTime ManufacturesYear
        {
            get
            {
                return _manufacturesYear;
            }
            set
            {
                try
                {
                    if (DateTime.UtcNow < value)
                    {
                        throw new Exception("Incorrect date entered");
                    }
                    _manufacturesYear = Convert.ToDateTime(value);
                   
                }
                catch (FormatException)
                {
                    throw new Exception("Incorrect date entered");
                }
            }
        }

        /// <summary>
        /// Features of transport
        /// </summary>
        public abstract string PrintTransportsFeatures();

        /// <summary>
        /// Print General data
        /// </summary>        
        public string PrintGeneralData()
        {
            return Convert.ToString(Name + " " + Cost + " " + SerialNumber + " " + ManufacturesYear);
        }

        /// <summary>
        /// Changing personal characteristics         
        /// | S - Speed, R - Range, C- Capacity / Consumption, D - Draft, P - Power, T - Type, B - BoatCapacity |
        /// </summary>
        public abstract void ChangePersonCharacteristics(string value, char symbol);
        #endregion Public

       
    }
}
