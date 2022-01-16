using System;
using ExtensionMethods.Validators;
namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static bool IsValidPassword(this string str,ValidatorBase[] args)
        {
            var result = false;
            foreach (var item in args)
            {
                 result = item.isValid(str);
            }
            return result;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringExtension.IsValidPassword(Console.ReadLine(),new ValidatorBase[] { new IsDigit(), new IsUpper() }));
        }
    }
}
