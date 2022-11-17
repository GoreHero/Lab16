using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 5;
            Product[] product = new Product[n];
            for (int i = 0; i < n; i++)
            {

                Console.Write("Введите артикул(код товара): ");
                int productId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите название: ");
                string productName = Console.ReadLine();
                Console.Write("Введите цену: ");
                int productCost = Convert.ToInt32(Console.ReadLine());

                product[i] = new Product { ProductId = productId, Name = productName, Cost = productCost };

            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true,
            };
            string jsonString = JsonSerializer.Serialize(product, options);

            using (StreamWriter sw = new StreamWriter("../../../ProductInfo.json"))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}
