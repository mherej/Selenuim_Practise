using System;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringInterpollation(); 
            //EscapeSequences();
            //StrigClassFormatting();
            //IsLeapYear();
            //MathOpsCheck();
            //SentinelExample();
            //Nested_loop_practise();
            Input_Values_checker();
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

        static void IsLeapYear()
        {
            Console.WriteLine("Enter the year to check");
            int year = Convert.ToInt32( Console.ReadLine());
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine($"Given year {year} is a leap Year");
            }
            else
            {
                Console.WriteLine($"Given year {year} is not a leap Year");
            }
        }

        static void MathOpsCheck()
        {
            int a = 18;
            int b = 5;
            Console.WriteLine(18 / 5);
        }

        static void SentinelExample()
        {
            string enterredValue = "";
            while (enterredValue != "99")
            {
                Console.WriteLine("Enter the value [99 to exit]");
                enterredValue = Console.ReadLine();
            }
        }

        static void Nested_loop_practise()
        {
            var innerNumber = 10;
            var outerNumber = 0;

            while(outerNumber < 3)
            {
                while (innerNumber > 5)
                {
                    Console.WriteLine($" Outer:{outerNumber} \tInner: {innerNumber}");
                    innerNumber--;
                }
                innerNumber = 10;
                outerNumber++;
            }
            
        }

        static void Input_Values_checker()
        {
            // collect ur input
            // enter check if the input is ecceptable 0-10 int
            // add input to array of accepatble and none acceptable values
            // diplay total number of values valid and invalid 
            // dispaly distinct number of vai d values, how many entries occurred.
            // do not disply vaalue unless it was displayed

            string sentinelControl = "";
            int[] valiarr =  new int [10];
            string[] invalidarr = new string [10];
            int entryCounter = 0;
            int inValue;

            while (sentinelControl != "N")
            {
                Console.WriteLine("Enter the Value 0-10 only! ");
                var input = Console.ReadLine();
                entryCounter++;

                    if (int.TryParse(input, out inValue) && inValue >= 0 && inValue <= 10)
                    {
                        valiarr[inValue]++;
                    }
                    else
                    {
                        Console.WriteLine("This was not a valid entry");
                    }
                

                Console.WriteLine("Do You want to continue [Y/N]");
                sentinelControl = Console.ReadLine();
            }

            Console.WriteLine($"Total Entries: {entryCounter} \t Valid {valiarr.Length} \t Invalid {invalidarr.Length}");
            Console.WriteLine(valiarr.Length);



        }



    }
}
