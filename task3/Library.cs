using System;
namespace task3
{
    public class Library
    {
        public Product[] products;
        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;

        }
        public int GetJournalCount()
        {
            int count = 0;
            foreach (var item in products)
            {
                if (item is Journal)
                {
                    count++;
                }
            }
            return count;
        }
        public int GetBooksCount()
        {
            int count = 0;
            foreach (var item in products)
            {
                if (item is Book)
                {
                    count++;
                }
            }
            return count;
        }
        public Product[] GetProducts(bool isBook)
        {
            Product[] products;
            if (isBook)
            {
                products = BookProducts();
            }
            else
            {
                products = JournalProducts();
            }
            return products;
        }
        public Product[] BookProducts()
        {
            Product[] books = new Product[0];
            foreach (var item in products)
            {
                if (item is Book)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length - 1] = item;
                }
            }
            return books;
        }
        public Product[] JournalProducts()
        {
            Product[] journals = new Product[0];
            foreach (var item in products)
            {
                if (item is Journal)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length - 1] = item;
                }
            }
            return journals;
        }
    }
}
