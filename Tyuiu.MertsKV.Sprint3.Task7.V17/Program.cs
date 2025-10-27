using Tyuiu.MertsKV.Sprint3.Task7.V17.Lib;
namespace Tyuiu.MertsKV.Sprint3.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            int startValue = -5;
            int stopValue = 5;
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            

            int len = stopValue - startValue + 1;
            double[] res = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+---------+-----------+");
            Console.WriteLine("|    X    |    f(x)   |");
            Console.WriteLine("+---------+-----------+");

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("|{0,5:d}    |  {1, 6:f2}   |", startValue, res[i]);
                startValue++;
            }
            Console.WriteLine("+---------+-----------+");
            Console.ReadKey();
        }
    }
}
