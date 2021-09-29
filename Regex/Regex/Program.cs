using System;

namespace Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            Console.WriteLine(patterns.validatePinCode("abc123"));
        }
    }
}
