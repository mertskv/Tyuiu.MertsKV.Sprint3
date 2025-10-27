using Tyuiu.MertsKV.Sprint3.Task5.V18.Lib;
namespace Tyuiu.MertsKV.Sprint3.Task5.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise dataService = new DataServise();

            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;

            Console.WriteLine($"Переменная X: {x}");
            Console.WriteLine($"Старт шага первой суммы ряда: {startValue1}");
            Console.WriteLine($"Конец шага первой суммы ряда: {startValue1}");
            Console.WriteLine($"Старт шага второй суммы ряда: {startValue2}");
            Console.WriteLine($"Конец шага второй суммы ряда: {startValue2}");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write($"Результат = {dataService.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2)}");

            Console.ReadKey();
        }
    }
}
