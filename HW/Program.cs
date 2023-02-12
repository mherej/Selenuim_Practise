using System;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringInterpollation(); 
            EscapeSequences();
            StrigClassFormatting();        
        }

        static void StringInterpollation()
        {
            string name, lastName, age;
            Console.WriteLine("Waht is you name ?");
            name = Console.ReadLine();
            Console.WriteLine("Waht is you last name ?");
            lastName = Console.ReadLine();
            Console.WriteLine("What is you age?");
            age = Console.ReadLine();

            Console.WriteLine($"Your details: {name} {lastName} you are {age} years old");
        }

        static void StrigClassFormatting()
        {
            double price = 23.4;
            string itemName = "Toy";

            Console.WriteLine(String.Format("{0,10} {1,10}", "Item Name", "Price"));// string literals
            Console.WriteLine(String.Format("{0,10} {1,10}", itemName, price));
            //msdn docs for String.Format to check.
        }
        static void EscapeSequences()
        {
           // Console.WriteLine("c\my documents\user\marek");// will not work 
            Console.WriteLine("c\\my documents\\user\\marek"); // use extra \
            Console.WriteLine(@"c\my documents\user\marek");// strig literal with 
        }



    }
}
