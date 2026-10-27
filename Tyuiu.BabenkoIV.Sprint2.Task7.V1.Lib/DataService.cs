using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabenkoIV.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return (x * x + y * y <= 1) && (y >= x) && (y >= -x);
        }
    }
}
