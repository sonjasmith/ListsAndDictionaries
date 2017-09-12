using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> faveFoods = new List<string>() { "pizza", "alfred", "chciken", "sushi", "broccoli" };
            //Console.WriteLine(faveFoods[0]);
            //Console.WriteLine(faveFoods[4]);

            //List<string> badFoods = new List<string>();
            //badFoods[0] = "Onions";
            //badFoods[1] = "Mushrooms";
            //badFoods[2] = "Liver";
            //badFoods[3] = "Pig Feet";

            //List<int> luckyNums = new List<int>();
            //luckyNums.Add(13);
            //luckyNums.Add(8);
            //luckyNums.Add(44);
            //luckyNums.Add(7);

            //List<string> faveFilms = new List<string>() { "Friday", "Hidden Figures", "The Notebook" };
            //faveFilms.Insert(0, "The Big Sick");
            //faveFilms.Insert(3, "Dumbo");
            //for (int counter = 0; counter < faveFilms.Count; counter++)
            //{
            //    Console.WriteLine(faveFilms[counter]);
            //}

            //foreach (string film in faveFilms)
            //{
            //    Console.WriteLine(film);
            //}

            //faveFilms.Remove("Friday");
            //faveFilms.Remove("The Notebook");

            //foreach (string movie in faveFilms)
            //{
            //    Console.WriteLine(movie);
            //}

            //DO IT
            //List<string> fiveAnimals = new List<string>() { "Dog", "Cat", "Bird", "Fish" };

            //for (int counter = 0; counter < fiveAnimals.Count; counter++)
            //{
            //    Console.WriteLine(fiveAnimals[counter]);
            //}

            //List<string> animals = new List<string>();
            //animals.Add("Dog");
            //animals.Add("Cat");
            //animals.Add("Bird");
            //animals.Add("Fish");
            //animals.Add("Turkey");

            //foreach (string good in animals)
            //{
            //    Console.WriteLine(good);
            //}

            List<bool> boolList = new List<bool>() { true,false, false, true, false};
            //foreach (bool rain in boolList)
            //    if (rain == true)
            //    {
            //        Console.WriteLine("It's a rainy day!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today!");
            //    }

            //for (int counter = 0; counter < boolList.Count; counter++)
            //    if (boolList[counter] == true)
            //    {
            //        Console.WriteLine("Pack that umbrella!");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Enjoy the sunshine!");
            //    }

            //TECH QUESTIONS manipulating ARRAYS & LISTS
            //List<int> numberList = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //Console.WriteLine(numberList.Contains(23));
            //Console.WriteLine(numberList.Contains(77));
            //Console.WriteLine(numberList.Contains(15));

            //numberList.Remove(27);
            //numberList.Remove(77);
            //numberList.Remove(32);
            //numberList.Remove(6);

            //Console.WriteLine(numberList.Contains(23));
            //Console.WriteLine(numberList.Contains(77));
            //Console.WriteLine(numberList.Contains(15));


            //Contains-scans a list and searches for a specific element to see if that element 
            //occurs at least once in the collection.
            // Create List with three elements.
            List <string> carList = new List<string> { "bmw", "honda", "ford" };
    
                Console.WriteLine(carList.Contains("bmw"));
                Console.WriteLine(carList.Contains("honda"));
                Console.WriteLine(carList.Contains("nissan"));
                carList.Remove("honda");
                Console.WriteLine(carList.Contains("honda"));
                        
        }
    }
}
