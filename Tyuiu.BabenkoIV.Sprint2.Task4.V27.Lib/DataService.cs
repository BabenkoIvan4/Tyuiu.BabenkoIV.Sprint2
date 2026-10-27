using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkoIV.Sprint2.Task4.V27.Lib
{
    public class DataService : ISprint2Task4V27
    {
        public double Calculate(double x, double y)
        {
            double z = Math.Round((x - 10 > y + 2) ? (x * Math.Pow((y + 2) / (x - 1), x)) : (Math.Pow(y, 2) - (2 / x)),3);
            return z;
        }
    }
}
