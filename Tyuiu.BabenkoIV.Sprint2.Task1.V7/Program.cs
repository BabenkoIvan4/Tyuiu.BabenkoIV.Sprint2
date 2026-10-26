using Tyuiu.BabenkoIV.Sprint2.Task1.V7.Lib;
namespace Tyuiu.BabenkoIV.Sprint2.Task1.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            //a = 195, b = 16, c = 14, d = 45
            int a = 195, b = 16, c = 14, d = 45;
            res = ds.GetLogicOperations(a, b, c, d);
            for(int i =0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
