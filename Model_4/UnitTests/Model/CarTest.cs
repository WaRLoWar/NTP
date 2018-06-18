using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Model;
using NUnit.Framework.Internal;

namespace UnitTests.Model
{
    /// <summary>
    /// A set of tests for a class 'Car'
    /// </summary>
    [TestFixture]
    class CarTest
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
            var testCar = new Car();
            testCar.TypeVehicle = typeVehicle;
            return testCar.TypeVehicle;
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
            var testCar = new Car();
            Assert.That(() => (testCar.TypeVehicle = typeVehicle),
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
            var testCar = new Car();
            testCar.Name = name;
            return testCar.Name;
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
            var testCar = new Car();
            Assert.That(() => (testCar.Name = name),
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
            var testCar = new Car();
            testCar.Cost = cost;
            return testCar.Cost;
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
            var testCar = new Car();
            Assert.That(() => (testCar.Cost = cost),
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
            var testCar = new Car();
            testCar.ManufacturesYear = data;
            return testCar.ManufacturesYear;
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
            var testCar = new Car();
            Assert.That(() => (testCar.ManufacturesYear = data),
                Throws.TypeOf<ArgumentException>());
        }

        /// <summary>
        /// Testing positive the Power property
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0.0, ExpectedResult = 0.0, TestName = "Testing the Power property when assigning 0,0")]
        [TestCase(600.0, ExpectedResult = 600.0, TestName = "Testing the Power property when assigning 600,0")]
        public double PowerTest(double power)
        {
            var testCar = new Car();
            testCar.Power = power;
            return testCar.Power;
        }
        /// <summary>
        /// Testing negative the Power property
        /// </summary>
        /// <param name="power"></param>
        [Test]
        [TestCase(double.MaxValue, TestName = "Testing the Power property when setting the maximum double value")]
        [TestCase(double.MinValue, TestName = "Testing property the Power when adding a minimum negative real number")]
        [TestCase(-1.0, TestName = "Testing the Power property when assigning -1,0")]
        public void PowerTestThrow(double power)
        {
            var testCar = new Car();
            Assert.That(() => (testCar.Power = power),
                Throws.TypeOf<ArgumentException>());
        }

        /// <summary>
        /// Testing positive the Consumption property
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0.0, ExpectedResult = 0.0, TestName = "Testing the Consumption property when assigning 0,0")]
        [TestCase(20.0, ExpectedResult = 20.0, TestName = "Testing the Consumption property when assigning 20,0")]
        [TestCase(1.0, ExpectedResult = 1.0, TestName = "Testing Consumption property when assigning 1,0")]
        public double ConsumptionTest(double consumption)
        {
            var testCar = new Car();
            testCar.Consumption = consumption;
            return testCar.Consumption;
        }
        /// <summary>
        /// Testing negative the Consumption property
        /// </summary>
        /// <param name="consumption"></param>
        [Test]
        [TestCase(double.MaxValue, TestName = "Testing Consumption when adding a maximum positive real number")]
        [TestCase(double.MinValue, TestName = "Testing Consumption when adding a minimum negative real number")]
        public void ConsumptionTestThrow(double consumption)
        {
            var testCar = new Car();
            Assert.That(() => (testCar.Consumption = consumption),
                Throws.TypeOf<ArgumentException>());
        }

        /// <summary>
        /// Testing positive the Type property
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [Test]
        [TestCase("Mini", ExpectedResult = "Mini", TestName = "Testing the Type property when you add a line 'Mini'")]
        [TestCase("Null", ExpectedResult = "Null", TestName = "Testing the Type property when you add a line 'Null'")]
        [TestCase("Compact", ExpectedResult = "Compact", TestName = "Testing the Type property when you add a line 'Compact'")]
        public string TypeTest(string type)
        {
            var testCar = new Car();
            testCar.Type = type;
            return testCar.Type;
        }
        /// <summary>
        /// Testing negative the Type property
        /// </summary>
        /// <param name="type"></param>
        [Test]
        [TestCase("Car", TestName = "Testing the Type property when you add a line 'Car'")]
        [TestCase("MINI", TestName = "Testing the Type property when you add a line  'MINI'")]
        public void TypeTestThrow(string type)
        {
            var testCar = new Car();
            Assert.That(() => (testCar.Type = type),
                Throws.TypeOf<ArgumentException>());
        }

        /// <summary>
        /// Testing positive the SerialNumber property
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        [Test]
        [TestCase("ABCDEFGHIJKLMNOPQ", ExpectedResult = "ABCDEFGHIJKLMNOPQ", TestName = "Testing SerialNumber when assigning a string 'ABCDEFGHIJKLMNOPQ' that is 17 characters long")]
        [TestCase("12345678901234567", ExpectedResult = "12345678901234567", TestName = "Testing SerialNumber when assigning a string '12345678901234567' that is 17 characters long")]
        [TestCase("ABCDEFH1234567890", ExpectedResult = "ABCDEFH1234567890", TestName = "Testing SerialNumber when assigning a string 'ABCDEFH1234567890' that is 17 characters long")]
        public string SerialNumberTest(string number)
        {
            var testCar = new Car();
            testCar.SerialNumber = number;
            return testCar.SerialNumber;
        }
        /// <summary>
        /// Testing negative the SerialNumber property
        /// </summary>
        /// <param name="number"></param>
        [Test]
        [TestCase("12345", TestName = "Testing SerialNumber when assigning a string '12345' that is 5 characters long")]
        [TestCase("ABCDEFGHIJ", TestName = "Testing SerialNumber when assigning a string 'ABCDEFGHIJ' that is 10 characters long")]
        public void SerialNumberTestThrow(string number)
        {
            var testCar = new Car();
            Assert.That(() => (testCar.SerialNumber = number),
                Throws.TypeOf<FormatException>());
        }

    }
}
