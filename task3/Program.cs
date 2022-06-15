using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Product product1 = new Journal()
            {
                Name = "VideoGames",
                Price = 56,
                Company = "IDK"
            };
            Product product2 = new Book()
            {
                Name = "The Sign of the Four",
                Price = 333,
                Author = "Arthur Conan Doyle",
                Genre = "Mystery Novel"
            };
            library.AddProduct(product1);
            library.AddProduct(product2);

        }
    }
}
