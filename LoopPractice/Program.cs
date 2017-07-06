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
            //When would you use a loop
            //why would you use a loop
            //Nested Loops
            //Infinite Loops
            //Keywords break and continue

            //For Loop can be used for both counting and Iterating through an array(or other collection types )
            //Looks like this:
            // for(initializer; condition; updater)
            //  {
            //     Do somethings
            //   }

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}



            //for (int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string greeting = "My name is little Bill.";
            //string[] wordsInGreeting = greeting.Split();

            //for (int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);

            //    //Create an array called days with the elements Monday, Tuesday, and Wednesday.
            //    //Using a For Loop, print the elements of the days array

            //}

            //string[] days = { "Monday", "Tuesday", "Wednesday" };



            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);

            // }

            //Starting with the string "Once upon a time" and create an array called
            //storyWords using the Split method. Reverse the order of the elements in the array and using a For Loop, print each word.

            //string storyWords = "Once upon a time";
            //string[] wordsInStoryWords = storyWords.Split();
            //Array.Reverse(wordsInStoryWords);

            //for (int i = 0; i < wordsInStoryWords.Length; i++)
            //{
            //    Console.WriteLine(wordsInStoryWords[i]);
            //}

            //Add the produt (multiplication) of 1 through 10 using a For Loop
            //Print product on the screen.


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //Console.WriteLine(product);

            //int products = 1;
            //for(int i = 1; i <= 10; i++)
            //{
            //    products = products * i;
            //}
            //Console.WriteLine(products);
            //}


            //Foreach loop - used to iterate over a collection (ex. list or array)
            // You can think of the structure of a Foreach loop as the statement :
            // For each item in the collection do something

            /*      foreach(dataType variable in collection)
             *      { 
             *      do something
             *      }
             *      */
            //int[] studentGrades = { 4, 4, 3, 4, 3 };
            //foreach (int grade in studentGrades)
            //{
            //    Console.WriteLine(grade);
            //}

            //string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            ////Always start with the keyword foreach
            //foreach (string month in firstMonths)
            //{
            //    Console.WriteLine(month);
            //}

            ////foreach loops allow the temporary variable to "know" to assign
            ////itself to each element in the collection (like an array), one at a time.


            ////Create an array of 6 musicians (bands or solo artist)
            //// Using a foreach loop, print each muscian's name

            //string[] music = { "Sublime", "Bad Religion", "Dispatch", "Bob Marley", "Sound Garden", "Nirvana" };
            //foreach (string bands in music)
            //{
            //    Console.WriteLine(bands);
            //}
        }
    }
}
