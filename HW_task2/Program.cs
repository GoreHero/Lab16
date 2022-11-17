using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using HW_Task2;

namespace HW_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../ProductInfo.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] product = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxProduct = product[0];
            foreach (Product e in product)
            {
                if (e.Cost > maxProduct.Cost)
                {
                    maxProduct = e;
                }
            }
            Console.WriteLine($"{maxProduct.ProductId} | {maxProduct.Name} | {maxProduct.Cost}");
        }
    }
}
