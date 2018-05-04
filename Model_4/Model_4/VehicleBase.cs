using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_4
{
    public abstract class VehicleBase: IVehicle
    {
        public VehicleBase()
        {
               
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
        private double _cost;

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
        protected string _serialNumber;

        /// <summary>
        /// Checking the serial number
        /// </summary>   
        protected abstract bool IsSerialNumber(string source);

        /// <summary>
        /// Checking for the symbol of the English alphabet
        /// </summary>
        protected bool IsEnglisLetter(char symbol)
        {
            if (symbol < 'A' || symbol > 'Z')
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Сhecking whether the number is a character
        /// </summary>        
        protected bool IsNumber(char symbol)
        {
            if (symbol < '0' || symbol > '9')
            {
                return false;
            }
            return true;
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

        #endregion Public

    }
}
