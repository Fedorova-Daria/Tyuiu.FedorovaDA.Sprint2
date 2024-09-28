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

            Assert.AreEqual("1 ������", ds.FindDateOfPreviousDay(1, n));
            Assert.AreEqual("1 �������", ds.FindDateOfPreviousDay(2, n));
            Assert.AreEqual("1 �����", ds.FindDateOfPreviousDay(3, n));
            Assert.AreEqual("1 ������", ds.FindDateOfPreviousDay(4, n));
            Assert.AreEqual("1 ���", ds.FindDateOfPreviousDay(5, n));
            Assert.AreEqual("1 ����", ds.FindDateOfPreviousDay(6, n));
            Assert.AreEqual("1 ����", ds.FindDateOfPreviousDay(7, n));
            Assert.AreEqual("1 �������", ds.FindDateOfPreviousDay(8, n));
            Assert.AreEqual("1 ��������", ds.FindDateOfPreviousDay(9, n));
            Assert.AreEqual("1 �������", ds.FindDateOfPreviousDay(10, n));
            Assert.AreEqual("1 ������", ds.FindDateOfPreviousDay(11, n));
            Assert.AreEqual("1 �������", ds.FindDateOfPreviousDay(12, n));

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