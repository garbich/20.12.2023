using System.Text.RegularExpressions;
namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            string number = "+380239870167";

            var result = Regex.Match(number, @"^\+380\d{9}$");

            bool a = result.Success;

            Console.WriteLine(a);
        }
    }
}