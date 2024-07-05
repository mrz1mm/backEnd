using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D3
{
    public class NameList
    {
        public string[] Names = { "John", "Jane", "Doe", "Smith", "Alex", "Sandra", "Tom", "Jerry", "Mickey", "Minnie" };

        public void SearchName()         
        {
          Console.WriteLine("Insert name to search");
          string nameToSearch = Console.ReadLine();

            if (Names.Contains(nameToSearch))
            {
                Console.WriteLine($"The name {nameToSearch} is in the list");
            }
            else
            {
                Console.WriteLine($"The name {nameToSearch} is not in the list");
            }
        }
    }
}
