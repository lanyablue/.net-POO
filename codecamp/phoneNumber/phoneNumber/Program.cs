using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a function that accepts an array of 10 integers (between 0 and 9), 
 * that returns a string of those numbers in the form of a phone number.*/


namespace phoneNumber
{
    internal class Program
    {
        public static string phone(int[] numbers)
        {

            return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[3]}{numbers[5]} - {numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
        }

       

    }
}

