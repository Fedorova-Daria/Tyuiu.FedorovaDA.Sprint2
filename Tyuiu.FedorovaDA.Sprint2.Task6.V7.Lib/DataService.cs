using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FedorovaDA.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            startYear = 1990;
            while (n > 12)
            {
                n = n - 12;
            }
            n += 1;

            switch (n)
            {
                case 1: return "январь";
                case 2: return "Февраль";
                case 3: return "март";
                case 4: return "апрель";
                case 5: return "май";
                case 6: return "июнь";
                case 7: return "июль";
                case 8: return "август";
                case 9: return "сентябрь";
                case 10: return "октябрь";
                case 11: return "ноябрь";
                case 12: return "декабрь";
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {n}");

            }
        }
    }
}
