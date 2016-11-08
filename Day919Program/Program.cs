using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day919Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> animals = new List<string>();
            animals.Add("cat");
            animals.Add("dolphin");
            animals.Add("elephant");
            animals.Add("lion");
            animals.Add("dog");

            foreach(string currentVal in animals)
            {
                Console.WriteLine(currentVal);
            }

            List<bool> boolList = new List<bool>() { true, false, false, true, false };

            foreach(bool currentVal in boolList)
            {
                if(currentVal == true)
                {
                    Console.WriteLine("Better bring an umbrella.");
                }
                else if(currentVal ==false)
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }
            }
            */

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            phoneBook.Add("Sarah", "123-4567");
            phoneBook.Add("Ben", "234-5678");
            phoneBook.Add("Bob", "345-6789");
            phoneBook.Add("Brian", "456-7890");
            phoneBook.Add("Chloe", "123-0987");

            foreach(KeyValuePair<string,string>tempNameNumber in phoneBook)
            {
                Console.WriteLine(tempNameNumber.Key + " " + tempNameNumber.Value);              
            }
        }
    
    }
}
