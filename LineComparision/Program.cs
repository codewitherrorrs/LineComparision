using System.Globalization;

namespace LineComparision
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Object Creation.
            LineCompare obj = new LineCompare(20,30,40,50);
            double lenght_one = obj.Calculate();
            LineCompare obj_Two = new LineCompare(10,20,30,40);
            double lenght_two = obj.Calculate();
            if(lenght_one.Equals(lenght_two)) 
            {
                Console.WriteLine("Both line are equals");
            }
            else
            {
                Console.WriteLine("Line are not equals");
            }
            
            Console.ReadKey();
        }
    }
}