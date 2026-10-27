using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkoIV.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n > 1)
            {
                n--;
            }
            else
            {
                switch (m)
                {
                    case 1: m = 12; g--; n = 31; break;
                    case 2: m = 1; n = 31; break;
                    case 3: m = 2; n = 28; break;
                    case 4: m = 3; n = 31; break;
                    case 5: m = 4; n = 30; break;
                    case 6: m = 5; n = 31; break;
                    case 7: m = 6; n = 30; break;
                    case 8: m = 7; n = 31; break;
                    case 9: m = 8; n = 31; break;
                    case 10: m = 9; n = 30; break;
                    case 11: m = 10; n = 31; break;
                    case 12: m = 11; n = 30; break;
                }
            }
            return $"{n:D2}.{m:D2}.{g}";
        }
    }
}
