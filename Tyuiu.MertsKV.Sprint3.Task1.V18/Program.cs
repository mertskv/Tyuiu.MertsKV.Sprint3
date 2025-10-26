
using Tyuiu.MertsKV.Sprint3.Task1.V18.Lib;
namespace Tyuiu.MertsKV.Sprint3.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataServise ds = new DataServise();

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());


            double result = ds.GetSumSeries(x, y);


            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
