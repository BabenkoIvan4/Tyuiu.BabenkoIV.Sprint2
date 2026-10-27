using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkoIV.Sprint2.Task2.V2.Lib
{
    public class DataService : ISprint2Task2V2
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if(
            (x >= 2 && x <= 5 && y >= 3 && y <= 6) ||    // 1
            (x >= 8 && x <= 9 && y >= 3 && y <= 9) ||    // 2
            (x >= 11 && x <= 12 && y >= 3 && y <= 5) ||  // 3
            (x >= 2 && x <= 3 && y >= 6 && y <= 7) ||    // 4
            (x >= 5 && x <= 9 && y >= 6 && y <= 12) ||   // 5
            (x >= 10 && x <= 13 && y >= 7 && y <= 9) ||  // 6
            (x >= 2 && x <= 4 && y >= 11 && y <= 13)     // 7
              )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
