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
            for (int i = 0; i< faveFilms.Count; i++)
            {
                //Console.WriteLine(faveFilms[i]);
            }

            foreach (string movie in faveFilms)
            {
                //Console.WriteLine(movie);
            }

            faveFilms.Remove("Aliens");
            faveFilms.Add("Bladerunner 2049");
            faveFilms.Add("Scott Pilgrim Vs. The World");

            foreach (string movie in faveFilms)
                //Console.WriteLine(movie);


            //Inserts at index, pushes others over 
            faveFilms.Insert(0, "Aliens");



        }
    }
}
