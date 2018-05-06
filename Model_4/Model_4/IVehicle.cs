using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // 4. Транспортные средства с различными реализациями расчета за-
    // траченного топлива: машина, машина-гибрид, вертолет.
    public interface IVehicle
    {
        /// <summary>
        /// The name of the transport
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The cost of transport       
        /// </summary>
        double Cost { get; set; }

        /// <summary>
        /// The serial number of the transport    
        /// </summary>        
        string SerialNumber { get; set; }

        /// <summary>
        /// Year of manufacture
        /// </summary>       
        DateTime ManufacturesYear { get; set; }

        /// <summary>
        /// Features of transport
        /// </summary>
        string PrintTransportsFeatures();

        /// <summary>
        /// Print General data
        /// </summary>        
        string PrintGeneralData();

        /// <summary>
        /// Changing personal characteristics 
        /// | S - Speed, R - Range, C- Capacity / Consumption, D - Draft, P - Power, T - Type, B - BoatCapacity |
        /// </summary>
        void ChangePersonCharacteristics(string value, char symbol);
    }

}
