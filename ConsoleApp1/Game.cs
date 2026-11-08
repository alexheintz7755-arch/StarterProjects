using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Game
    {
        public string title;
        public string studio;
        public double rating;
        public int year;

        public Game(string argTitle, string argStudio, double argRating, int argYear)
        {
            title = argTitle;
            studio = argStudio;
            rating = argRating;
            year = argYear;
            Console.WriteLine("Storing Data for " + title);
        }


    }
}
