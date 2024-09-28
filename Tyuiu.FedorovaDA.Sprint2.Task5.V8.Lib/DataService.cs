using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FedorovaDA.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            string a;

            switch (m)
            {
                case 1:
                    a ="Января";
                    break;
                case 2:
                    a ="Февраля";
                    break;
                case 3:
                    a ="Марта";
                    break;
                case 4:
                    a ="Апреля";
                    break;
                case 5:
                    a ="Мая";
                    break;
                case 6:
                    a ="Июня";
                    break;
                case 7:
                    a ="Июля";
                    break;
                case 8:
                    a ="Августа";
                    break;
                case 9:
                    a ="Сентября";
                    break;
                case 10:
                    a ="Октября";
                    break;
                case 11:
                    a ="Ноября";
                    break;
                case 12:
                    a ="Декабря";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");

            }
            if ((n > 1) && (n < 32))
            {
                n = n - 1;
            }
            else
            {
                Console.WriteLine("Число дня задано некорректно. Введите число от 2 до 31");
            }
            return  n + " " + a;
        }
    }
}
