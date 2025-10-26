using Tyuiu.MertsKV.Sprint3.Task0.V28.Lib;
namespace Tyuiu.MertsKV.Sprint3.Task0.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 17;

            Console.WriteLine("Переменная Х:" + value);
            Console.WriteLine("Старт шага :" + startValue);
            Console.WriteLine("Конец шага: " + stopValue);

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("***********************************************************************************");

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine("Произведение ряда: " + res);


            Console.ReadKey();

        }
    }
}
