using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //            /*When would you use a loop
            //            why would you use a loop
            //            Nested Loops
            //            Infinite Loops
            //            Keywords break and continue

            //            For Loop can be used for both counting and Iterating through an array(or other collection types)
            //            Looks like this:
            //             for (initializer; condition; updater)
            //                {
            //                    Do somethings
            //               }
            //               */
            //            for (int i = 0; i <= 10; i++)
            //            {
            //                Console.WriteLine(i);
            //            }



            //            for (int i = 15; i > 0; i--)
            //            {
            //                Console.WriteLine(i);
            //            }


            //            for (int i = 50; i <= 100; i++)
            //            {
            //                Console.WriteLine(i);
            //            }

            //            string greeting = "My name is little Bill.";
            //            string[] wordsInGreeting = greeting.Split();

            //            for (int i = 0; i < wordsInGreeting.Length; i++)
            //            {
            //                Console.WriteLine(wordsInGreeting[i]);

            //                //Create an array called days with the elements Monday, Tuesday, and Wednesday.
            //                //Using a For Loop, print the elements of the days array

            //            }

            //            string[] days = { "Monday", "Tuesday", "Wednesday" };



            //            for (int i = 0; i < days.Length; i++)
            //            {
            //                Console.WriteLine(days[i]);

            //            }

            //            //Starting with the string "Once upon a time" and create an array called
            //            //storyWords using the Split method.Reverse the order of the elements in the array and using a For Loop, print each word.

            //            string storyWords = "Once upon a time";
            //            string[] wordsInStoryWords = storyWords.Split();
            //            Array.Reverse(wordsInStoryWords);

            //            for (int i = 0; i < wordsInStoryWords.Length; i++)
            //            {
            //                Console.WriteLine(wordsInStoryWords[i]);
            //            }

            //            //Add the produt(multiplication) of 1 through 10 using a For Loop
            //           //Print product on the screen.


            //            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //            int product = numbers[0];
            //            for (int i = 0; i < numbers.Length; i++)
            //            {
            //                product = product * numbers[i];
            //            }
            //            Console.WriteLine(product);

            //            int products = 1;
            //            for (int i = 1; i <= 10; i++)
            //            {
            //                products = products * i;
            //            }
            //            Console.WriteLine(products);
            //        }


            //        //Foreach loop - used to iterate over a collection(ex.list or array)
            //             //You can think of the structure of a Foreach loop as the statement :
            //             //For each item in the collection do something

            //            /*      foreach(dataType variable in collection)
            //             *      { 
            //             *      do something
            //             *      }
            //             *      */
            //            int[] studentGrades = { 4, 4, 3, 4, 3 };
            //            foreach (int grade in studentGrades)
            //            {
            //                Console.WriteLine(grade);
            //            }

            //    string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            //            //Always start with the keyword foreach
            //            foreach (string month in firstMonths)
            //            {
            //                Console.WriteLine(month);
            //            }

            ////foreach loops allow the temporary variable to "know" to assign
            ////itself to each element in the collection (like an array), one at a time.


            ////Create an array of 6 musicians (bands or solo artist)
            //// Using a foreach loop, print each muscian's name

            //string[] music = { "Sublime", "Bad Religion", "Dispatch", "Bob Marley", "Sound Garden", "Nirvana" };
            //            foreach (string bands in music)
            //            {
            //                Console.WriteLine(bands);
            //            }

            //While loop is used when you want a chunk of code to run only if a condition is met first.
            //While something is true, do this thing.

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //while (firstName.ToUpper() == "MICHAEL") 
            //{
            //    Console.WriteLine("Dude, you are amazing!");
            //    break;
            //}


            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine();
            //while (playAgain == "yes")
            //{
            //    Console.WriteLine("It's a rematch!!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}


            //A Do-While loop is similar to a while loop, however it is used when you want a chunk of code to run at least once but repeat only if the while condition is met.

            //The structure of a dowhile loop looks like this
            /*
             * do
             * {
             *      Do something
             *      }
             *     While(Condition);
             *     */
            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Thanks for playing!");
            //    Console.WriteLine("Great Game !");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "YES");

            //ask the user for the class (in school) they would like to add to their GPA calculation
            //ask the user for the letter grade for the class.
            //ask the user if they have another class they would like to add to their GPA
            //Using a do while loop, reprat the code if the user says yes

            //string answer;
            //string classes;
            //string grade;
            //Console.WriteLine("Would you like to add a class to your GPA calculation");
            //answer = Console.ReadLine().ToLower();
            //if (answer=="yes")
            //{
            //    do
            //    {
            //        Console.WriteLine("What class would you like to add");
            //        classes = Console.ReadLine();
            //        Console.WriteLine("Please enter your letter grade for this class");
            //        grade = Console.ReadLine();
            //        Console.WriteLine("Would you like to add another class? YES/NO");
            //        answer = Console.ReadLine().ToLower();
            //    }
            //    while (answer == "yes");

            //}

            ////Nested Loops
            //// A loop inside another loop
            ////The inner loop is executed more times then the outer loop

            ////Real life example Clock

            ////Create a nested loop structure that prints:
            ////1234
            ////1234

            //for(int rows = 1; rows <= 2; rows++)
            //{
            //    for (int Columns = 1; Columns <= 4; Columns++)
            //    {
            //        Console.Write(Columns);
            //    }
            //    Console.WriteLine();
            //}

            //Print a triangle
            //outer loop will go line by line
            //the inner loop will go over different elements in the line.
            //Result
            //1
            //12
            //123
            //1234...

            //for (int rows = 1; rows <= 7; rows++)
            //{
            //    for (int Columns = 1; Columns <= rows; Columns++)
            //    {
            //        Console.Write(Columns);
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("How many rows do you want your triangle?");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++) 
                {
                    Console.Write(col);
                }
                Console.WriteLine();

            }




        }
    }
}
