using Tyuiu.MertsKV.Sprint3.Task6.V18.Lib;
namespace Tyuiu.MertsKV.Sprint3.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("*************************************************************************");

            int startValue = 9;
            int stopValue = 18;


            Console.WriteLine("Начало числового отрезка = " + startValue);
            Console.WriteLine("Конец числового отрезка = " + stopValue);


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
