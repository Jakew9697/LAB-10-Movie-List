using System;
using System.Collections.Generic;

namespace LAB_10_MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MovieClasss> movies = new List<MovieClasss>();

            movies.Add(new MovieClasss("Die Hard", "Action"));

            movies.Add(new MovieClasss("Kill Bill v 2", "Mystery"));

            movies.Add(new MovieClasss("Inception", "Thriller"));

            movies.Add(new MovieClasss("Finding Nemo", "Adventure"));

            movies.Add(new MovieClasss("Matrix", "Action"));


            bool cont = true;
            bool validInput = false;
            string category = "";
            while (cont)
            {
                validInput = false;

                while (!validInput)
                {


                    Console.WriteLine("There are 5 movies in the list what genre are you interested in? \n1 Action \n2 Mystery \n3 Thriller \n4 Adventure ");
                    string input = Console.ReadLine().Trim();
                    try
                    {
                        int movieIndex = int.Parse(input);
                        if (movieIndex == 1)
                        {
                            category = "Action";
                        }
                        else if (movieIndex == 2)
                        {
                            category = "Mystery";
                        }
                        else if (movieIndex == 3)
                        {
                            category = "Thriller";
                        }
                        else if (movieIndex == 4)
                        {
                            category = "Adventure";
                        }
                        else
                        {
                            throw new Exception("Invalid number entry 1-4 only");
                        }

                        validInput = true;

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                        
                    }
                }
                for (int i = 0; i < movies.Count; i++)
                {
                    if (category == movies[i].Genre)
                    {
                        Console.WriteLine(movies[i].Title);
                    }
                }


                validInput = false;
                while (!validInput)
                {
                    Console.WriteLine("Would you like to look at the movies in the other genres? y/n? ");
                    string userContinue = Console.ReadLine().ToLower().Trim();
                    if (userContinue == "y")
                    {
                        validInput = true;
                        cont = true;
                    }
                    else if (userContinue == "n")
                    {
                        validInput = true;
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("That is an invalid input please enter (y) or (n) ");
                    }
                }
            }
        }

    }
}

