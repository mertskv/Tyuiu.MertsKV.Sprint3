using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MertsKV.Sprint3.Task6.V18.Lib
{
    public class DataServise : ISprint3Task6V18
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if ((x % d == 0) & (d < 10))
                    {
                        sum += d;
                    }
            
            
           
                }
            }
            return sum;
        }
    }
}
