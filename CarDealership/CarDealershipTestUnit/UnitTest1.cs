using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealership;
using System;
using System.IO;

namespace CarDealershipTestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorTestMethod()
        {
            var tesla= CreateTestCar();
            Assert.AreEqual("Tesla", tesla.Brand);
            Assert.AreEqual(2014, tesla.YearOfRelease);
            Assert.AreEqual("abcdefg1234", tesla.Vin);
            Assert.AreEqual(AllBodyTypes.Sedan, tesla.BodyType);
            Assert.AreEqual(3000000, tesla.Price);
            Assert.AreEqual("25.09.2015", tesla.DateOfSell.ToShortDateString());
            Assert.AreEqual("Ivanov Ivan Ivanovich", tesla.BuyerDetails);
        }
        [TestMethod]
        public void ToStringTestMethod()
        {
            var tesla = CreateTestCar();
            Assert.AreEqual("Бренд: Tesla. Год выпуска: 2014. Идентификационный номер: abcdefg1234.", tesla.ToString());
        }
        [TestMethod]
        public void PrintInfoTestMethod()
        {
            
            var tesla = CreateTestCar();
            var honda = new Car("Honda", 2010, "xyz555000123", AllBodyTypes.Station_wagon, 2500000, "14.08.2011", "Mendeleev Mihail Ivanovich");
            var consoleOut = new[] { "Бренд: Tesla. Год выпуска: 2014. Идентификационный номер: abcdefg1234.", $"Тип кузова: седан. Цена: 3000000. Дата продажи: 25.09.2015. ФИО покупателя: Ivanov Ivan Ivanovich.", "Бренд: Honda. Год выпуска: 2010. Идентификационный номер: xyz555000123.", $"Тип кузова: универсал. Цена: 2500000. Дата продажи: 14.08.2011. ФИО покупателя: Mendeleev Mihail Ivanovich." };

           
            TextWriter oldOut = Console.Out;
            StringWriter output = new StringWriter();
            Console.SetOut(output); 
            tesla.PrintInfo();
            honda.PrintInfo();
            Console.SetOut(oldOut); 
            var outputArray = output.ToString().Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

          
            Assert.AreEqual(4, outputArray.Length);
            for (var i = 0; i < consoleOut.Length; i++)
                Assert.AreEqual(consoleOut[i], outputArray[i]);
        }
        private Car CreateTestCar()
        {
            return new Car("Tesla", 2014, "abcdefg1234", AllBodyTypes.Sedan, 3000000, "25.09.2015", "Ivanov Ivan Ivanovich");
        }
    }
}
