using System;

namespace Inheritance_TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product("25$", "04.05.2002",5);           


            Book book = new Book("Stephen Hawking", "Biography", "35$", "04.05.2002", 23);                
                Console.WriteLine(book.Name());
            book.Sell();

            NewsPaper newsPaper = new NewsPaper("BMW", "M5", "80.000$", "10.06.2015", 0);
            Console.WriteLine(newsPaper.GetInfo());
           newsPaper.Sell();




        }
    }
}
