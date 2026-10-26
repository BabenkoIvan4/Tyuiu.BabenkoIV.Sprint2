using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkoIV.Sprint2.Task0.V6.Lib
{
    public class DataService : ISprint2Task0V6
    {
        //Написать программу из операций сравнений (==, !=, <, >, <=, >=,
        // при x = 107, y = 754
        //(True, True, True, False, True, False)
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x + 647 == y;
            res[1] = x != y;
            res[2] = x < y;
            res[3] = x > y;
            res[4] = x <= y;
            res[5] = x >= y;
            return res;
        }
    }
}
