using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 3, 5 };
            string[] names = new string[3];
            List<int> Nume = new List<int>();
            Nume.Add(5);
            Nume.Add(2);
            Nume.Add(3);
            Nume.Add(8);
            Nume.Remove(3);
            Nume.RemoveAt(0);

            List<string> Names = new List<string>();
            Names.Add("Hootan");
            Names.Add("Hooman");
            Names.Add("Hedi");
            Names.Add("Negin");
            Names.Add("Erfan");

            foreach(string name in Names)
            {
                Console.WriteLine($"Name Is :{name}");
            }
            Console.ReadKey();
        }
    }
}
