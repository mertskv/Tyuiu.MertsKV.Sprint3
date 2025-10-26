using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MertsKV.Sprint3.Task1.V18.Lib
{
    public class DataServise : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sm = 0;
            while (startValue <= stopValue)
            {
                sm += ((Math.Sin(startValue)) * (Math.Pow((1.0 / 4.0), 2)));
                startValue++;
            }
            return Math.Round(sm, 3);
            

        }
        
    }
}
