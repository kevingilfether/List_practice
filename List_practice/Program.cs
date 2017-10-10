using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Common List methods
            //Count - returns number of items in list;
            //Clear - Removes all elements from list
            //Add - Adds item to end of list
            //Remove - Removes first occurence of item in list
            //Sort - Sorts elements in list using default comparer (alpha numeric)
            //IndexOf - Returns index of first occurence within range of items
            //Contains -- Determines whether a list contains an item
            //RemoveAt - Removes item at specified index
            //Insert - inserts at index an item


            //Setting up a list of test scores
            List<int> testScores = new List<int>() { 98, 100, 76, 84, 93 };
            testScores.Add(80);
            testScores.Add(99);

            // populating empty list
            List<int> luckyNumbers = new List<int>();
            luckyNumbers.Add(2);
            luckyNumbers.Add(3);
            luckyNumbers.Add(5);
            luckyNumbers.Add(7);
            //Console.WriteLine(luckyNumbers.Count());


            List<string> faveFoods = new List<string>() { "sushi", "A really good burger", "Pupuseria la benedicion", "Mom's rice and beans" };

            //Check list by printing elements
            //Console.WriteLine(faveFoods[0]);
            //Console.WriteLine(faveFoods[1]);
            //Console.WriteLine(faveFoods[3]);

            List<string> leastFaveFoods = new List<string>();
            leastFaveFoods.Add("vinegar");
            leastFaveFoods.Add("olives");
            leastFaveFoods.Add("'raw' stuff");
            //Console.WriteLine(leastFaveFoods[0]);

            leastFaveFoods[0] = "pizza";
            //Console.WriteLine(leastFaveFoods[0]);

            List<string> faveFilms = new List<string>() { "Aliens", "Old Boy", "Arrival", "The Lego Movie" };
            //for (int i = 0; i < faveFilms.Count; i++)
            //{
            //    Console.WriteLine(faveFilms[i]);
            //}

            //foreach (string movie in faveFilms)
            //{
            //    Console.WriteLine(movie);
            //}

            faveFilms.Remove("Aliens");
            faveFilms.Add("Bladerunner 2049");
            faveFilms.Add("Scott Pilgrim Vs. The World");

            //foreach (string movie in faveFilms)
            //Console.WriteLine(movie);


            //Inserts at index, pushes others over 
            //faveFilms.Insert(0, "Aliens");


            //Num 1

            List<string> favAnimals = new List<string>();
            favAnimals.Add("whale");
            favAnimals.Add("cat");
            favAnimals.Add("dust mite");
            favAnimals.Add("tigers");
            favAnimals.Add("opossum");

            foreach (string animal in favAnimals)
            {
                Console.WriteLine(animal);
            }

            //Num 2

            List<bool> boolList = new List<bool>() { true, false, false, true, false };

            foreach (bool value in boolList)
            {
                if (value == true)
                    Console.WriteLine("Better bring an umbrella");
                else
                    Console.WriteLine("No rain today, enjoy the sun!");
            }

            //Num 3

            List<int> someNums = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 4 };
            Console.WriteLine(someNums.Contains(23));
            Console.WriteLine(someNums.Contains(77));
            Console.WriteLine(someNums.Contains(15));

            someNums.Remove(27);
            someNums.Remove(77);
            someNums.Remove(32);
            someNums.Remove(6);

            Console.WriteLine(someNums.Contains(23));
            Console.WriteLine(someNums.Contains(77));
            Console.WriteLine(someNums.Contains(15));




        }
    }
}
