using Tyuiu.BabenkoIV.Sprint2.Task0.V6.Lib;
namespace Tyuiu.BabenkoIV.Sprint2.Task0.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            int x = 107;
            int y = 754;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            for(int i = 0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }
            

        }
    }
}
