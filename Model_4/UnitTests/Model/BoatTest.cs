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
        /// Testing positive the TypeVehicle property
        /// </summary>
        /// <param name="typeVehicle"></param>
        /// <returns></returns>
        [Test]
        [TestCase("Car", ExpectedResult = "Car", TestName = "Testing property TypeVehicle when assigning string 'Car'")]
        [TestCase("Boat", ExpectedResult = "Boat", TestName = "Testing property TypeVehicle when assigning string 'Boat'")]
        [TestCase("Helicopter", ExpectedResult = "Helicopter", TestName = "Testing property TypeVehicle when assigning string 'Helicopter'")]
        public string TypeVehicleTest(string typeVehicle)
        {
            var testBoat = new Boat();
            testBoat.TypeVehicle = typeVehicle;
            return testBoat.TypeVehicle;
        }

        /// <summary>
        /// Testing negative the TypeVehicle property
        /// </summary>
        /// <param name="typeVehicle"></param>
        [Test]
        [TestCase("CAR", TestName = "Testing property TypeVehicle when assigning string 'CAR'")]
        [TestCase("Null", TestName = "Testing property TypeVehicle when assigning string 'Null'")]
        public void TypeVehicleTestThrow(string typeVehicle)
        {
            var testBoat = new Boat();
            Assert.That(() => (testBoat.TypeVehicle = typeVehicle),
                Throws.TypeOf<ArgumentException>());
        }

        /// <summary>
        /// Testing positive the Name property
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Test]
        [TestCase("ABCD", ExpectedResult = "ABCD", TestName = "Testing property Name when assigning string 'ABCD'")]
        [TestCase("1234", ExpectedResult = "1234", TestName = "Testing property Name when assigning string '1234'")]
        [TestCase("BMWX5", ExpectedResult = "BMWX5", TestName = "Testing property Name when assigning string 'BMWX5'")]
        public string NameTest(string name)
        {
            var testBoat = new Boat();
            testBoat.Name = name;
            return testBoat.Name;
        }
        /// <summary>
        /// Testing negative the Name property
        /// </summary>
        /// <param name="name"></param>
        [Test]
        [TestCase("Car#3", TestName = "Testing property Name when assigning string 'Car#3'")]
        [TestCase("##**", TestName = "Testing property Name when assigning string '##**'")]
        public void NameTestThrow(string name)
        {
            var testBoat = new Boat();
            Assert.That(() => (testBoat.Name = name),
                Throws.TypeOf<FormatException>());
        }

        /// <summary>
        /// Testing positive the Cost property
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0.0, ExpectedResult = 0.0, TestName = "Testing the Cost property when assigning 0,0")]
        [TestCase(1.01, ExpectedResult = 1.01, TestName = "Testing the Cost property when assigning 1,01")]
        [TestCase(double.MaxValue, ExpectedResult = double.MaxValue, TestName = "Testing the Cost property when assigning MaxValue")]
        public double CostTest(double cost)
        {
            var testBoat = new Boat();
            testBoat.Cost = cost;
            return testBoat.Cost;
        }
        /// <summary>
        /// Testing negative the Cost property
        /// </summary>
        /// <param name="cost"></param>
        [Test]
        [TestCase(-1.0, TestName = "Testing the Cost property when assigning -1,0")]
        [TestCase(double.MinValue, TestName = "Testing the Cost property when assigning MinValue")]
        public void CostTestThrow(double cost)
        {
            var testBoat = new Boat();
            Assert.That(() => (testBoat.Cost = cost),
                Throws.TypeOf<ArgumentException>());
        }

        /// <summary>
        /// Testing positive the ManufacturesYear property
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [Test]
        [TestCase("01/01/0001", ExpectedResult = "01/01/0001", TestName = "Testing the DateTime property when assigning a value '01/01/0001'")]
        [TestCase("01/01/2018", ExpectedResult = "01/01/2018", TestName = "Testing the DateTime property when assigning a value; '01/01/2018'")]
        [TestCase("12/12/1992", ExpectedResult = "12/12/1992", TestName = "Testing the DateTime property when assigning a value '12/12/1992'")]
        public DateTime ManufacturesYearTest(DateTime data)
        {
            var testBoat = new Boat();
            testBoat.ManufacturesYear = data;
            return testBoat.ManufacturesYear;
        }
        /// <summary>
        /// Testing negative the ManufacturesYear property
        /// </summary>
        /// <param name="data"></param>
        [Test]
        [TestCase("12/12/2018", TestName = "Testing the DateTime property when assigning a value '12/12/2018'")]
        [TestCase("12/12/9999", TestName = "Testing the DateTime property when assigning a value '12/12/9999'")]
        public void ManufacturesYearTestThrow(DateTime data)
        {
            var testBoat = new Boat();
            Assert.That(() => (testBoat.ManufacturesYear = data),
                Throws.TypeOf<ArgumentException>());
        }

        /// <summary>
        /// Testing positive the Speed property
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0.0, ExpectedResult = 0.0, TestName = "Testing the Speed property when assigning 0,0")]
        [TestCase(80.0, ExpectedResult = 80.0, TestName = "Testing the Speed property when assigning 80,0")]
        public double SpeedTest(double speed)
        {
            var testBoat = new Boat();
            testBoat.Speed = speed;
            return testBoat.Speed;
        }
        /// <summary>
        ///  Testing negative the Speed property
        /// </summary>
        /// <param name="speed"></param>
        [Test]
        [TestCase(-1.0, TestName = "Testing the Speed property when assigning -1,0")]
        [TestCase(double.MaxValue, TestName = "Testing the Speed property when setting the maximum double value")]
        [TestCase(double.MinValue, TestName = "Testing property the Speed when adding a minimum negative real number")]
        public void SpeedTestThrow(double speed)
        {
            var testBoat = new Boat();
            Assert.That(() => (testBoat.Speed = speed),
                Throws.TypeOf<ArgumentException>());
        }

        /// <summary>
        /// Testing positive the Draft property
        /// </summary>
        /// <param name="draft"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0.0, ExpectedResult = 0.0, TestName = "Testing the Draft property when assigning 0,0")]
        [TestCase(80.0, ExpectedResult = 80.0, TestName = "Testing the Draft property when assigning 80,0")]
        public double DraftTest(double draft)
        {
            var testBoat = new Boat();
            testBoat.Draft = draft;
            return testBoat.Draft;
        }
        /// <summary>
        /// Testing negative the Draft property
        /// </summary>
        /// <param name="draft"></param>
        [Test]
        [TestCase(-1.0, TestName = "Testing the Draft property when assigning -1,0")]
        [TestCase(double.MaxValue, TestName = "Testing the Draft property when setting the maximum double value")]
        [TestCase(double.MinValue, TestName = "Testing property the Draft when adding a minimum negative real number")]
        public void DraftTestNegative(double draft)
        {
            var testBoat = new Boat();
            Assert.That(() => (testBoat.Draft = draft),
                Throws.TypeOf<ArgumentException>());
        }

        /// <summary>
        /// Testing positive the BoatCapacity property
        /// </summary>
        /// <param name="capacity"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0U, ExpectedResult = 0, TestName = "Testing the BoatCapacity property when assigning 0")]
        [TestCase(18U, ExpectedResult = 18, TestName = "Testing the BoatCapacity property when assigning 18")]
        [TestCase(1U, ExpectedResult = 1, TestName = "Testing the BoatCapacity property when assigning 1")]
        public uint BoatCapacityTest(uint capacity)
        {
            var testBoat = new Boat();
            testBoat.BoatCapacity = capacity;
            return testBoat.BoatCapacity;
        }
        /// <summary>
        /// Testing negative the BoatCapacity property
        /// </summary>
        /// <param name="capacity"></param>
        [Test]
        [TestCase(19U, TestName = "Testing the BoatCapacity property when assigning 19")]
        [TestCase(uint.MaxValue, TestName = "Testing the BoatCapacity property when assigning MaxValue")]
        public void BoatCapacityTestThrow(uint capacity)
        {
            var testBoat = new Boat();
            Assert.That(() => (testBoat.BoatCapacity = capacity),
                Throws.TypeOf<ArgumentException>());
        }

        /// <summary>
        /// Testing positive the SerialNumber property
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        [Test]
        [TestCase("12345678", ExpectedResult = "12345678", TestName = "Testing SerialNumber when assigning a string '12345678' that is 8 characters long")]
        [TestCase("123456789012", ExpectedResult = "123456789012", TestName = "Testing SerialNumber when assigning a string '123456789012' that is 12 characters long")]
        public string SerialNumberTest(string number)
        {
            var testBoat = new Boat();
            testBoat.SerialNumber = number;
            return testBoat.SerialNumber;
        }
        /// <summary>
        /// Testing negative the SerialNumber property
        /// </summary>
        /// <param name="number"></param>
        [Test]
        [TestCase("ABCDEFGH", TestName = "Testing SerialNumber when assigning a string 'ABCDEFGH' that is 8 characters long")]
        [TestCase("ABCDEFGHIJKL", TestName = "Testing SerialNumber when assigning a string 'ABCDEFGHIJKL' that is 12 characters long")]
        [TestCase("ABCD1234", TestName = "Testing SerialNumber when assigning a string 'ABCD1234' that is 8 characters long")]
        [TestCase("1234", TestName = "Testing SerialNumber when assigning a string '1234' that is 4 characters long")]
        public void SerialNumberTestThrow(string number)
        {
            var testBoat = new Boat();
            Assert.That(() => (testBoat.SerialNumber = number),
                Throws.TypeOf<FormatException>());
        }
    }
}
