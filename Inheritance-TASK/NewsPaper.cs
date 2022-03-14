using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_TASK
{
    class NewsPaper:Product
    {
        public string Advertisement;
        public string Article;

        public NewsPaper(string advertisement,string article,string price, string date, int count):base(price,date,count)
        {
            Advertisement = advertisement;
            Article = article;
        }
        public string GetInfo()
        {
            return $"Adver: {Advertisement}, Article:{Article}, Price: {Price}, Date: {ReleaseDate}";
        }
    }
}
