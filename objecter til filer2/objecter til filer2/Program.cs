using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace objecter_til_filer2
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.WriteLine("Please choose an aaction by entering the number of the action");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Object to binary");
                Console.WriteLine("2 - Read file from last instance");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("Action> ");
                string action = Console.ReadLine();

                if (action == "1")
                    Write();
                if (action == "2")
                    Read();
            }
        }

        public static void Write()
        {
            Console.WriteLine("This program will create a new binaray file");
            Console.WriteLine("Hit any key when you're ready");
            Console.ReadKey();

            Item item = new Item();
            Console.WriteLine("Person instance created");

            Console.WriteLine("-------------------------------------------------");
            Console.Write("What is your name> ");
            item.name = Console.ReadLine().ToString();
            Console.Write("How old are you (as number only)> ");
            item.Price = int.Parse(Console.ReadLine());
            Console.Write("What is your descrippion> ");
            item.Description = Console.ReadLine().ToString();

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Trying to write object to binary file");

            if (File.Exists("file.bin"))
            {
                Console.WriteLine("file.bin already exists");
                Console.Write("Do you want yo delete it (Y/N)");
                string ans = Console.ReadLine().ToUpper();
                if (ans == "Y")
                    File.Delete("file.bin");
                if (ans == "N")
                    return;
            }

            Console.WriteLine("Creating file...");
            FileStream fs = File.Create("file.bin");

            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            binaryFormatter.Serialize(fs, item);

            fs.Close();
            Console.WriteLine("File has been created and object was written");
        }

        public static void Read()
        {
            Console.WriteLine("Reading file.bin");
            FileStream fs = File.Open("file.bin", FileMode.Open);

            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Item personFromFile = (Item)binaryFormatter.Deserialize(fs);

            Console.WriteLine("{");
            Console.WriteLine("    " + personFromFile.name);
            Console.WriteLine("    " + personFromFile.Price);
            Console.WriteLine("    " + personFromFile.Description);
            Console.WriteLine("}");

            fs.Close();
        }
    }
    [Serializable]
    public class Item
    {
        public string name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }
    }
}


