using System;
namespace ADF_2107_BradleyNatasha
{
    public static class Validation
    {
            //two static methods
            //one for string and one for numbers
        

        public static string StringValidation(string s)
        {
            //use a loop to validate string
            //make sure it is not left blank
            while (string.IsNullOrWhiteSpace(s))
            {
                //tell usser error
                Console.WriteLine("Error! Invalide Input!");

                //catch new answer
                s = Console.ReadLine();

            }

            return s;
        }

        public static int NumberValidation(string num)
        {
            //validates that input is a number
        
            int n;
            while (!int.TryParse(num, out n))
            {
                //tell user the error
                //make sure it is not left blank and is a number
                Console.WriteLine("Error! Ivalide Input!");

                num = Console.ReadLine();
            }
            return n;
        }
    }
}
