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
            var testCar = new Car();
            testCar.TypeVehicle = typeVehicle;
            return testCar.TypeVehicle;
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
            var testCar = new Car();
            testCar.Name = name;
            return testCar.Name;
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
            var testCar = new Car();
            testCar.Cost = cost;
            return testCar.Cost;
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
            var testCar = new Car();
            testCar.ManufacturesYear = data;
            return testCar.ManufacturesYear;
        }

        /// <summary>
        /// Testing the Power property
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0.0, ExpectedResult = 0.0, TestName = "Testing the Power property when assigning 0,0")]
        [TestCase(600.0, ExpectedResult = 600.0, TestName = "Testing the Power property when assigning 600,0")]
        [TestCase(double.MaxValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Power property when setting the maximum double value")]        
        [TestCase(double.MinValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing property the Power when adding a minimum negative real number")]
        [TestCase(-1.0, ExpectedResult = typeof(ArgumentException), TestName = "Testing the Power property when assigning -1,0")]
        [TestCase("0.0", ExpectedResult = typeof(FormatException), TestName = "Testing Power the when adding a character string")]
        public double PowerTest(double power)
        {
            var testCar = new Car();
            testCar.Power = power;
            return testCar.Power;
        }

        /// <summary>
        /// Testing the Consumption property
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        [Test]
        [TestCase(0.0, ExpectedResult = 0.0, TestName = "Testing the Consumption property when assigning 0,0")]
        [TestCase(20.0, ExpectedResult = 20.0, TestName = "Testing the Consumption property when assigning 20,0")]
        [TestCase(double.MaxValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing Consumption when adding a maximum positive real number")]
        [TestCase(double.MinValue, ExpectedResult = typeof(ArgumentException), TestName = "Testing Consumption when adding a minimum negative real number")]
        [TestCase(1.0, ExpectedResult = 1.0, TestName = "Testing Consumption property when assigning 1,0")]
        [TestCase("0.0",ExpectedResult = typeof(FormatException),TestName = "Testing Consumption the when adding a character string")]
        public double ConsumptionTest(double consumption)
        {
            var testCar = new Car();
            testCar.Consumption = consumption;
            return testCar.Consumption;
        }

        /// <summary>
        /// Testing the Type property
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [Test]
        [TestCase("Mini",ExpectedResult = "Mini",TestName = "Testing the Type property when you add a line 'Mini'")]
        [TestCase("Null", ExpectedResult = "Null", TestName = "Testing the Type property when you add a line 'Null'")]
        [TestCase("Compact", ExpectedResult = "Compact", TestName = "Testing the Type property when you add a line 'Compact'")]
        [TestCase("Car", ExpectedResult = typeof(ArgumentException), TestName = "Testing the Type property when you add a line 'Car'")]
        [TestCase(0, ExpectedResult = typeof(FormatException), TestName = "Testing the type property when adding an integer value '0'")]
        public string TypeTest(string type)
        {
            var testCar = new Car();
            testCar.Type = type;
            return testCar.Type;
        }

        /// <summary>
        /// Testing the SerialNumber property
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        [Test]
        [TestCase("ABCDEFGHIJKLMNOPQ", ExpectedResult = "ABCDEFGHIJKLMNOPQ", TestName = "Testing SerialNumber when assigning a string 'ABCDEFGHIJKLMNOPQ' that is 17 characters long")]
        [TestCase("12345678901234567", ExpectedResult = "12345678901234567", TestName = "Testing SerialNumber when assigning a string '12345678901234567' that is 17 characters long")]
        [TestCase("ABCDEFH1234567890", ExpectedResult = "ABCDEFH1234567890", TestName = "Testing SerialNumber when assigning a string 'ABCDEFH1234567890' that is 17 characters long")]
        [TestCase("12345", ExpectedResult = typeof(FormatException), TestName = "Testing SerialNumber when assigning a string '12345' that is 5 characters long")]
        [TestCase("ABCDEFGHIJ", ExpectedResult = typeof(FormatException), TestName = "Testing SerialNumber when assigning a string 'ABCDEFGHIJ' that is 10 characters long")]
        public string SerialNumberTest(string number)
        {
            var testCar = new Car();
            testCar.SerialNumber = number;
            return testCar.SerialNumber;
        }
        
    }
}
