using Tyuiu.FedorovaDA.Sprint2.Task5.V8.Lib;
namespace Tyuiu.FedorovaDA.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();

            int n = 2;

            Assert.AreEqual("1 Января", ds.FindDateOfPreviousDay(1, n));
            Assert.AreEqual("1 Февраля", ds.FindDateOfPreviousDay(2, n));
            Assert.AreEqual("1 Марта", ds.FindDateOfPreviousDay(3, n));
            Assert.AreEqual("1 Апреля", ds.FindDateOfPreviousDay(4, n));
            Assert.AreEqual("1 Мая", ds.FindDateOfPreviousDay(5, n));
            Assert.AreEqual("1 Июня", ds.FindDateOfPreviousDay(6, n));
            Assert.AreEqual("1 Июля", ds.FindDateOfPreviousDay(7, n));
            Assert.AreEqual("1 Августа", ds.FindDateOfPreviousDay(8, n));
            Assert.AreEqual("1 Сентября", ds.FindDateOfPreviousDay(9, n));
            Assert.AreEqual("1 Октября", ds.FindDateOfPreviousDay(10, n));
            Assert.AreEqual("1 Ноября", ds.FindDateOfPreviousDay(11, n));
            Assert.AreEqual("1 Декабря", ds.FindDateOfPreviousDay(12, n));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(-1, 1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(13, 32);
            });
            
        }
    }
}