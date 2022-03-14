using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_TASK
{
    class Book : Product
    {
        public string Author;
        public string Genre;

        public Book(string author, string genre, string price, string date, int count): base(price, date, count)
        {
            Author = author;
            Genre = genre;
        }
        public string Name()
        {
            return $"Author: {Author}, Genre: {Genre}, Price: {Price}, Date: {ReleaseDate}";
        }
    }
}
