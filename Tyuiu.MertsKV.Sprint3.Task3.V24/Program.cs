using Tyuiu.MertsKV.Sprint3.Task3.V24.Lib;
namespace Tyuiu.MertsKV.Sprint3.Task3.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

          

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '*';





            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Строка, получившаяся после выполнения программы: " + ds.ReplaceCharInString(value, replaceable, replacement));
            Console.ReadKey();
        }
    }
}
