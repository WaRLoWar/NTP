using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_4
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

    }

}
