﻿using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MertsKV.Sprint3.Task4.V6.Lib
{
    public class DataServise : ISprint3Task4V6
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    res = res + (x / (Math.Cos(x) - Math.Sin(x)));
                }
            }
            return Math.Round(res, 3);
        }
    }
}
