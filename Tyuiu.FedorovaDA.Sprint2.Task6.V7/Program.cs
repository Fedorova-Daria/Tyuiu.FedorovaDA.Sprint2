using Tyuiu.FedorovaDA.Sprint2.Task6.V7.Lib;

namespace Tyuiu.FedorovaDA.Sprint2.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Федрова Д. А. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Федорова Дарья Артемовна | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* С начала 1990 года по некоторый день прошло n месяцев и 2 дня.          *");
            Console.WriteLine("* Определить название месяца (январь, февраль и т. п.) этого дня.         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите сколько месяцев прошло:");
            int n = Convert.ToInt32(Console.ReadLine());

            string a;

            int startYear = 1990;
            a = ds.FindMonthName(startYear, n);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Название месяца - " + a);
            Console.ReadKey();
        }
    }
}
