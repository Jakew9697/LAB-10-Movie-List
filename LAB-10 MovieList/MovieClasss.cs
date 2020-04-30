using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_10_MovieList
{
    class MovieClasss
    {
        //fields

        private string title;

        private string genre;

        //properties
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }

        //constructors
        public MovieClasss(string _title, string _genre)
        {
            title = _title;

            genre = _genre;
        }

        public MovieClasss()
        {
            title = "default Movie";

            genre = "default Genre";

        }

        //methods
        public void PrintMovie()
        {
            Console.WriteLine(genre + " " + title + " ");
        }

        
    }
}
