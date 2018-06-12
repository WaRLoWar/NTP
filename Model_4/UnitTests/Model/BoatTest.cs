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
    /// A set of tests for a class 'Boat'
    /// </summary>
    [TestFixture]
    class BoatTest
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
            var testBoat = new Boat();
            testBoat.TypeVehicle = typeVehicle;
            return testBoat.TypeVehicle;
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
            var testBoat = new Boat();
            testBoat.Name = name;
            return testBoat.Name;
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
            var testBoat = new Boat();
            testBoat.Cost = cost;
            return testBoat.Cost;
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
            var testBoat = new Boat();
            testBoat.ManufacturesYear = data;
            return testBoat.ManufacturesYear;
        }

        /// <summary>
        /// Testing the Speed property
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0.0, ExpectedResult = 0.0, TestName = "Testing the Speed property when assigning 0,0")]
        [TestCase(80.0, ExpectedResult = 80.0, TestName = "Testing the Speed property when assigning 80,0")]
        [TestCase(-1.0, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Speed property when assigning -1,0")]
        [TestCase(double.MaxValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Speed property when setting the maximum double value")]
        [TestCase(double.MinValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing property the Speed when adding a minimum negative real number")]
        public double SpeedTest(double speed)
        {
            var testBoat = new Boat();
            testBoat.Speed = speed;
            return testBoat.Speed;
        }

        /// <summary>
        /// Testing the Draft property
        /// </summary>
        /// <param name="draft"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0.0, ExpectedResult = 0.0, TestName = "Testing the Draft property when assigning 0,0")]
        [TestCase(80.0, ExpectedResult = 80.0, TestName = "Testing the Draft property when assigning 80,0")]
        [TestCase(-1.0, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Draft property when assigning -1,0")]
        [TestCase(double.MaxValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Draft property when setting the maximum double value")]
        [TestCase(double.MinValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing property the Draft when adding a minimum negative real number")]
        public double DraftTest(double draft)
        {
            var testBoat = new Boat();
            testBoat.Draft = draft;
            return testBoat.Draft;
        }

        /// <summary>
        /// Testing the BoatCapacity property
        /// </summary>
        /// <param name="capacity"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0U, ExpectedResult = 0, TestName = "Testing the BoatCapacity property when assigning 0")]
        [TestCase(18U, ExpectedResult = 18, TestName = "Testing the BoatCapacity property when assigning 18")]
        [TestCase(19U, ExpectedResult = typeof(ArgumentException), TestName = "Testing the BoatCapacity property when assigning 19")]
        [TestCase(uint.MaxValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing the BoatCapacity property when assigning MaxValue")]
        [TestCase(1U, ExpectedResult = 1, TestName = "Testing the BoatCapacity property when assigning 1")]
        public uint BoatCapacityTest(uint capacity)
        {
            var testBoat = new Boat();
            testBoat.BoatCapacity = capacity;
            return testBoat.BoatCapacity;
        }

        /// <summary>
        /// Testing the SerialNumber property
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        [Test]
        [TestCase("12345678", ExpectedResult = "12345678", TestName = "Testing SerialNumber when assigning a string '12345678' that is 8 characters long")]
        [TestCase("123456789012", ExpectedResult = "123456789012", TestName = "Testing SerialNumber when assigning a string '123456789012' that is 12 characters long")]
        [TestCase("ABCDEFGH", ExpectedResult =typeof(FormatException), TestName = "Testing SerialNumber when assigning a string 'ABCDEFGH' that is 8 characters long")]
        [TestCase("ABCDEFGHIJKL", ExpectedResult = typeof(FormatException), TestName = "Testing SerialNumber when assigning a string 'ABCDEFGHIJKL' that is 12 characters long")]
        [TestCase("ABCD1234", ExpectedResult = typeof(FormatException), TestName = "Testing SerialNumber when assigning a string 'ABCD1234' that is 8 characters long")]
        [TestCase("1234", ExpectedResult = typeof(FormatException), TestName = "Testing SerialNumber when assigning a string '1234' that is 4 characters long")]
        public string SerialNumberTest(string number)
        {
            var testBoat = new Boat();
            testBoat.SerialNumber = number;
            return testBoat.SerialNumber;
        }
    }
}
