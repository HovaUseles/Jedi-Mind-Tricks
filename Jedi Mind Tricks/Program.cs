using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_Mind_Tricks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();

            
            people.Add("John", 44);
            people.Add("Simon", 54);
            people.Add("Gelmmi", 12);

            // Adds new entry if it does not exits
            people["Bo"] = 33;

            // Using ElementAt method to make the dictionary act like an list with indexes
            Console.WriteLine(people.ElementAt(0).Key + ", " + people.ElementAt(0).Value);
            
            // Removes an element with the key Bo
            people.Remove("Bo");

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key}, {person.Value}");
            }
        }
    }
}
