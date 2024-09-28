using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FedorovaDA.Sprint2.Task4.V17.Lib
{
    public class DataService : ISprint2Task4V17
    {
        public double Calculate(double x, double y)
        {
            double z = x - 22 > Math.Sqrt(y) ? Math.Pow(6 + 2 / Math.Pow(x, 2), y) : y + (12 /  Math.Pow(x, 2));
            return Math.Round(z, 3);
        }
    }
}
