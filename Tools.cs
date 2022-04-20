using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rugby_Opgave
{
    internal class Tools
    {
        public void PrintArray(List<string> input)
        {
            int i = 0;
            Console.WriteLine("While: ");
            while (i < input.Count)
            {
                Console.WriteLine(input[i]);
                i++;
            }

            Console.WriteLine("Foreach: ");
            foreach (string s in input)
                Console.WriteLine(s);

            Console.WriteLine("For: ");
            for (i = 0; i < input.Count; i++)
                Console.WriteLine(input[i]);
        }
    }
}
