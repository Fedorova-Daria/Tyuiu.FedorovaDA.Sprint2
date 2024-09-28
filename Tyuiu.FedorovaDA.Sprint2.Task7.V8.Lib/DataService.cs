using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FedorovaDA.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y <= 4) && (y >= 0))
            {
                if ((Math.Pow(x, 2) - y >= 0) && (x >= 0))
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
