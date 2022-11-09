using System.Collections;


namespace DateFunction
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Enter your preferred date (month/day/year)");
            var inputDate = Console.ReadLine();
            if (string.IsNullOrEmpty(inputDate) != true)
            {
                Console.WriteLine(DateFunc(inputDate));
            }
            
        }

        public static DateTime DateFunc(string inputDate)
        {

            DateTime DateConverted = new DateTime();
            DateTime DateAdd = new DateTime();

            if (string.IsNullOrEmpty(inputDate) != true)
            {
                DateConverted = DateTime.Parse(inputDate);
                DateAdd = DateConverted.AddDays(7);
            }
            return DateAdd;

        }
    }
}