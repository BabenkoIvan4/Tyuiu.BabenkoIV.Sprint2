using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkoIV.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                2 => 29,
                4 or 6 or 9 or 11 => 30,
                _ => 31
            };

            if (n < daysInMonth)
            {
                n++;
            }
            else
            {
                n = 1;
                if (m == 12)
                {
                    m = 1;
                    g++;
                }
                else
                {
                    m++;
                }
            }

            return $"{n:D2}.{m:D2}.{g}";
        }
    }
}
