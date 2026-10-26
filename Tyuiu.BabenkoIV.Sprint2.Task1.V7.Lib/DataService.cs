using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkoIV.Sprint2.Task1.V7.Lib
{
    public class DataService : ISprint2Task1V7
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            //a = 195, b = 16, c = 14, d = 45
            //True, False, False, False, True, False
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d);
            res[1] = (a - 179 > b) & (c < d);
            res[2] = (a < b) || (c > d);
            res[3] = (a - 179 > b) && (c < d);
            res[4] = !(!res[0]);
            res[5] = (a > b) ^ (c < d);

            return res;
        }
    }
}
