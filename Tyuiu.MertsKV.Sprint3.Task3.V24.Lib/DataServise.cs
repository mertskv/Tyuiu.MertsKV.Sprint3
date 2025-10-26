using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MertsKV.Sprint3.Task3.V24.Lib
{
    public class DataServise : ISprint3Task3V24
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            replaceable = 'g';
            replacement = '*';
            foreach (char repleceable in value)
            {
                if (replaceable == 'g')
                {
                    value = value.Replace('g', '*');
                }
            }
            return value;
        }
    }
}
