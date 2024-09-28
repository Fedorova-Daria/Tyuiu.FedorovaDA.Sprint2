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

            int m = 2;

            Assert.AreEqual("1.01", ds.FindDateOfPreviousDay(m, 1));
            Assert.AreEqual("1.02", ds.FindDateOfPreviousDay(m, 2));
            Assert.AreEqual("1.03", ds.FindDateOfPreviousDay(m, 3));
            Assert.AreEqual("1.04", ds.FindDateOfPreviousDay(m, 4));
            Assert.AreEqual("1.05", ds.FindDateOfPreviousDay(m, 5));
            Assert.AreEqual("1.06", ds.FindDateOfPreviousDay(m, 6));
            Assert.AreEqual("1.07", ds.FindDateOfPreviousDay(m, 7));
            Assert.AreEqual("1.08", ds.FindDateOfPreviousDay(m, 8));
            Assert.AreEqual("1.09", ds.FindDateOfPreviousDay(m, 9));
            Assert.AreEqual("1.10", ds.FindDateOfPreviousDay(m, 10));
            Assert.AreEqual("1.11", ds.FindDateOfPreviousDay(m, 11));
            Assert.AreEqual("1.12", ds.FindDateOfPreviousDay(m, 12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(1, -1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(32, 13);
            });
            
        }
    }
}