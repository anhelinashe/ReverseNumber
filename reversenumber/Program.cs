
using System;
namespace reversenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user!Enter the number in which you want to reverse the order of the digits: ");
            string userNumber = Console.ReadLine();

            string reversedNumber = "";
            int startvalue = 0;
            
         
            for (int i = userNumber.Length - 1; i >= startvalue; i--)
            {
                if (userNumber[0] == '-')
                {
                    reversedNumber += "-";
                    startvalue = 1;
                }
                if (userNumber[i] != '0' || reversedNumber.Length > 0 || i == startvalue)
                {
                    reversedNumber += userNumber[i];
                }
            }
          
        
            Console.WriteLine("Reversed number: " + reversedNumber);
        }
    }
}