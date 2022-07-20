using System;
using System.Text.RegularExpressions;

namespace TDS.Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(SsnValidator(args[0]));
        }

        static string SsnValidator(string ssn)
        {



            Regex regex = new Regex("^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$");

            if (ssn == null)
            {
                return "Invalid";
            }
            else
            {

                bool matching = regex.IsMatch(ssn);

                if (matching)
                {
                    return "Valid";
                }
                else
                {
                    return "Invalid";
                }
            }

        }
    }
}
