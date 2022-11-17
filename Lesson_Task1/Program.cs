using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;

namespace Lesson_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string jsonString = "{\"firstName\":\"Tom\",\"lastName\":\"Jackson\",\"gender\":\"male\",\"age\":\"29,\"online\":true,\"hobby\":[\"football\", \"reading\", \"swimming\"]}";
            //Person person = JsonSerializer.Deserialize<Person>(jsonString);
            Person person1 = new Person()
            {
                firstName = "Вася",
                lastName = "Васячкин",
                gender = "муж",
                age = 30,
                online = false,
                hobby = new string[] { "футбол", "програмирование" }
            };
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
            };
            string jsonString1 = JsonSerializer.Serialize(person1, options);
            Console.WriteLine(jsonString1);
            Console.ReadKey();
        }
    }
    class Person
    {
        
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public bool online { get; set; }
        public string[] hobby { get; set; }
    }
}

