using Tyuiu.BabenkoIV.Sprint2.Task7.V1.Lib;
namespace Tyuiu.BabenkoIV.Sprint2.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x, y;
            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();
        }
    }
}
