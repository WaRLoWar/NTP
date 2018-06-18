using System;
using System.Collections.Generic;
using System.Dynamic;
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
        /// Type of vehicle
        /// [ Car / Boat / Helicopter ]
        /// </summary>
        string TypeVehicle { get; set; }

        /// <summary>
        /// The name of the transport
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The serial number of the transport    
        /// </summary>        
        string SerialNumber { get; set; }

        /// <summary>
        /// The cost of transport       
        /// </summary>
        double Cost { get; set; }

        /// <summary>
        /// Year of manufacture
        /// </summary>       
        DateTime ManufacturesYear { get; set; }        
    }

}
