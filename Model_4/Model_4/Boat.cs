using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_4
{
    sealed public class Boat: VehicleBase
    {
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
    }
}
