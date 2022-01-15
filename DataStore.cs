using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Assignment__4
{
    public static class DataStore
    {
        private static List<Product> _list;

        public static Catalog Load(string filePath)
        {
            _list = new List<Product>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] parts = line.Split('\t');

                    string Name = parts[0];
                    Department Department = parts[1];
                    decimal Price = Convert.ToDecimal(parts[2]);

                    Product product = new Product
                    {
                        Name = Name,
                        Department = Department,
                        Price = Price
                    };

                    _list.Add(product);
                    line = reader.ReadLine();   
                }
                return _list;
            }
        }

        public static void Save(Catalog catalog, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(catalog);
            }
        }



    }
}
