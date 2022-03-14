using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_TASK
{
    class Product
    {
        public string Price;
        public string ReleaseDate;
        public int Count;

        public Product(string price, string date, int count)
        {
            Price = price;
            ReleaseDate = date;
            Count= count;
        }
        //public string Fullname()
        //{
        //    return $"Price: {Price}, Date: {ReleaseDate}";
        //}
        public void Sell()
        {
            if (Count >= 1)
            {
                Count--;    
                Console.WriteLine(Count);
            }
            else
            {
                Console.WriteLine("Satish prosesi heyata kechmedi");
            }
        }

    }
}
