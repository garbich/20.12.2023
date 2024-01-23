using System.Text.RegularExpressions;

namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            string email = "thug@itstep.ua";

            var result = Regex.Match(email, "^[a-zA-Z0-9]+[@]+(itstep.ua)+$");

            bool a = result.Success;

            Console.WriteLine(a);
        }
    }
}