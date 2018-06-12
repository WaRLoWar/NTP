using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Model;

namespace UnitTests.Model
{
    /// <summary>
    /// A set of tests for a class 'Helicopter'
    /// </summary>
    [TestFixture]
    class HelicopterTest
    {
        /// <summary>
        /// Testing the TypeVehicle property
        /// </summary>
        /// <param name="typeVehicle"></param>
        /// <returns></returns>
        [Test]
        [TestCase("Car", ExpectedResult = "Car", TestName = "Testing property TypeVehicle when assigning string 'Car'")]
        [TestCase("CAR", ExpectedResult = typeof(ArgumentException), TestName = "Testing property TypeVehicle when assigning string 'CAR'")]
        [TestCase("Null", ExpectedResult = typeof(ArgumentException), TestName = "Testing property TypeVehicle when assigning string 'Null'")]
        [TestCase("Boat", ExpectedResult = "Boat", TestName = "Testing property TypeVehicle when assigning string 'Boat'")]
        [TestCase("Helicopter", ExpectedResult = "Helicopter", TestName = "Testing property TypeVehicle when assigning string 'Helicopter'")]
        public string TypeVehicleTest(string typeVehicle)
        {
            var testHelicopter = new Helicopter();
            testHelicopter.TypeVehicle = typeVehicle;
            return testHelicopter.TypeVehicle;
        }

        /// <summary>
        /// Testing the Name property
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Test]
        [TestCase("ABCD", ExpectedResult = "ABCD", TestName = "Testing property Name when assigning string 'ABCD'")]
        [TestCase("1234", ExpectedResult = "1234", TestName = "Testing property Name when assigning string '1234'")]
        [TestCase("BMWX5", ExpectedResult = "BMWX5", TestName = "Testing property Name when assigning string 'BMWX5'")]
        [TestCase("Car#3", ExpectedResult = typeof(FormatException), TestName = "Testing property Name when assigning string 'Car#3'")]
        [TestCase("##**", ExpectedResult = typeof(FormatException), TestName = "Testing property Name when assigning string '##**'")]
        public string NameTest(string name)
        {
            var testHelicopter = new Helicopter();
            testHelicopter.Name = name;
            return testHelicopter.Name;
        }

        /// <summary>
        /// Testing the Cost property
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0.0, ExpectedResult = 0.0, TestName = "Testing the Cost property when assigning 0,0")]
        [TestCase(1.01, ExpectedResult = 1.01, TestName = "Testing the Cost property when assigning 1,01")]
        [TestCase(double.MaxValue, ExpectedResult = double.MaxValue, TestName = "Testing the Cost property when assigning MaxValue")]
        [TestCase(-1.0, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Cost property when assigning -1,0")]
        [TestCase(double.MinValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Cost property when assigning 0,0")]
        public double CostTest(double cost)
        {
            var testHelicopter = new Helicopter();
            testHelicopter.Cost = cost;
            return testHelicopter.Cost;
        }

        /// <summary>
        /// Testing the ManufacturesYear property
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [Test]
        [TestCase("01/01/0001", ExpectedResult = "01/01/0001", TestName = "Testing the DateTime property when assigning a value '01/01/0001'")]
        [TestCase("01/01/2018", ExpectedResult = "01/01/2018", TestName = "Testing the DateTime property when assigning a value; '01/01/2018'")]
        [TestCase("12/12/1992", ExpectedResult = "12/12/1992", TestName = "Testing the DateTime property when assigning a value '12/12/1992'")]
        [TestCase("12/12/2018", ExpectedResult = typeof(ArgumentException), TestName = "Testing the DateTime property when assigning a value '12/12/2018'")]
        [TestCase("12/12/2018", ExpectedResult = typeof(ArgumentException), TestName = "Testing the DateTime property when assigning a value '12/12/2018'")]
        public DateTime ManufacturesYearTest(DateTime data)
        {
            var testHelicopter = new Helicopter();
            testHelicopter.ManufacturesYear = data;
            return testHelicopter.ManufacturesYear;
        }

        /// <summary>
        /// Testing the Range property
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0U, ExpectedResult = 0, TestName = "Testing the Range property when assigning 0")]
        [TestCase(1200U, ExpectedResult = 1200, TestName = "Testing the Range property when assigning 1200")]
        [TestCase(uint.MaxValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Range property when assigning MaxValue")]
        [TestCase(1201U, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Range property when assigning 1201")]
        [TestCase(uint.MinValue, ExpectedResult = 0, TestName = "Testing the Range property when assigning MinValue")]
        public uint RangeTest(uint range)
        {
            var testHelicopter = new Helicopter();
            testHelicopter.Range = range;
            return testHelicopter.Range;
        }

        /// <summary>
        /// Testing the Capacity property
        /// </summary>
        /// <param name="capacity"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0U, ExpectedResult = 0, TestName = "Testing the Capacity property when assigning 0")]
        [TestCase(8000U, ExpectedResult = 8000, TestName = "Testing the Capacity property when assigning 8000")]
        [TestCase(uint.MaxValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Capacity property when assigning MaxValue")]
        [TestCase(8001U, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Capacity property when assigning 8001")]
        [TestCase(uint.MinValue, ExpectedResult = 0, TestName = "Testing the Capacity property when assigning MinValue")]
        public uint CapacityTest(uint capacity)
        {
            var testHelicopter = new Helicopter();
            testHelicopter.Capacity = capacity;
            return testHelicopter.Capacity;
        }

        /// <summary>
        /// Testing the Speed property
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0.0, ExpectedResult = 0.0, TestName = "Testing the Speed property when assigning 0,0")]
        [TestCase(200.0, ExpectedResult = 200.0, TestName = "Testing the Speed property when assigning 200,0")]
        [TestCase(double.MaxValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Speed property when setting the maximum double value")]
        [TestCase(double.MinValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing property the Speed when adding a minimum negative real number")]
        [TestCase(-1.0, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Speed property when assigning -1,0")]
        [TestCase("0.0", ExpectedResult = typeof(ArgumentException), TestName = "Testing Speed the when adding a character string")]
        public double SpeedTest(double speed)
        {
            var testHelicopter = new Helicopter();
            testHelicopter.Speed = speed;
            return testHelicopter.Speed;
        }

        /// <summary>
        /// Testing the SerialNumber property
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        [Test]
        [TestCase("ABCD123456", ExpectedResult = "ABCD123456", TestName = "Testing SerialNumber when assigning a string 'ABCD123456' that is 10 characters long")]
        [TestCase("BOOB311208", ExpectedResult = "BOOB311208", TestName = "Testing SerialNumber when assigning a string 'BOOB311208' that is 10 characters long")]
        [TestCase("1234ABCDEF", ExpectedResult = typeof(FormatException), TestName = "Testing SerialNumber when assigning a string '1234ABCDEF' that is 10 characters long")]
        [TestCase("1234567890", ExpectedResult = typeof(FormatException), TestName = "Testing SerialNumber when assigning a string '1234567890' that is 10 characters long")]
        [TestCase("ABCDEFGHIJ", ExpectedResult = typeof(FormatException), TestName = "Testing SerialNumber when assigning a string 'ABCDEFGHIJ' that is 10 characters long")]
        [TestCase("XB19", ExpectedResult = typeof(FormatException), TestName = "Testing SerialNumber when assigning a string 'XB19' that is 4 characters long")]
        public string SerialNumberTest(string number)
        {
            var testHelicopter = new Helicopter();
            testHelicopter.SerialNumber = number;
            return testHelicopter.SerialNumber;
        }
    }
}
