using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D3
{
    public class NumberArray
    {
        public void GetNumberArray()
        {
            Console.WriteLine("Insert the number of the array length:");
            string length = Console.ReadLine();
            int lengthArray = Convert.ToInt32(length);
            int[] array = new int[lengthArray];
            for (int i = 0; i < lengthArray; i++)
            {
                array[i] = i + 1;
            }

            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }

            double average = (double)sum / lengthArray;

            Console.WriteLine($"The array is {string.Join(", ", array)}");
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The average is {average}");
        }
    }
}
