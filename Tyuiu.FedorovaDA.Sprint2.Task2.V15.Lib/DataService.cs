using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FedorovaDA.Sprint2.Task2.V15.Lib
{
    public class DataService : ISprint2Task2V15
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool a = true;

            if ((x >= 2) && (x <= 13) && (y >= 3) && (y <= 13))
            {
                if ((x == 2) && (y >= 3) && (y <= 4) && (y >= 7) && (y <= 12))
                {
                    return a = false;
                }
                if ((x == 3) && (y >= 8) && (y <= 12))
                {
                    return a = false;
                }
                if ((x == 4) && (y >= 8) && (y <= 11))
                {
                    return a = false;
                }
                if ((x == 5) && (y == 8))
                {
                    return a = false;
                }
                if ((x == 5) && (y == 11))
                {
                    return a = false;
                }
                if ((x >= 6) && (x <= 8) && (y >= 3) && (y <= 4))
                {
                    return a = false;
                }
                if ((x >= 7) && (x <= 10) && (y >= 9) && (y <= 13))
                {
                    return a = false;
                }
                if ((x == 11) && (y == 12))
                {
                    return a = false;
                }
                if ((x == 13) && (y <= 3) && (y >= 5))
                {
                    return a = false;
                }
                if ((x == 13) && (y <= 9) && (y >= 11))
                {
                    return a = false;
                }

                return a;
            }
            else
            {
                return false;
            }
        }
    }
}
