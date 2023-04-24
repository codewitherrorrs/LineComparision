using System.Globalization;

namespace LineComparision
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Object Creation.
            LineCompare obj = new LineCompare(20,30,40,50);
            obj.Calculate();
            Console.ReadKey();
        }
    }
}