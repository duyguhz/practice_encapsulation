using System;
namespace task3
{
    public class Journal:Product
    {
        public string Company;
        public  override string  GetInfo()
        {
            return $"Name: {Name} - Company: {Company} - Price: {Price}";
        }
    }
}
