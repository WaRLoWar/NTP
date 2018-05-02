using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_4
{
    // 4. Транспортные средства с различными реализациями расчета за-
    // траченного топлива: машина, машина-гибрид, вертолет.
    public interface ICalculationOfFuel
    {
        // Растояние [км]        
        double Distance { get; set; }

        // Расход топлива [л / 100 км]        
        double Fuel { get; set; }

        double Result { get; set; }
        double GetFloatValue();
        void AddDistance();
        void AddFuel();
        void GetResult();
    }
}
