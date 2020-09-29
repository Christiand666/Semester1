using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace opgave3opg
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepgoing = true;
        endLoop: while (keepgoing)

            {
                string input = "";
                bool isAFunction = false;
                string createFunc = "createtxtfile";
                string deleteFunc = "deletetxtfile";
                string showDirFunc = "showdir";
                string path = @"C:\Users\Christian\Documents\Test og træning af systemudvikling\";


                while (isAFunction == false)
                {
                    Console.WriteLine("functions: ");
                    Console.WriteLine("createtxtfile(filename)");
                    Console.WriteLine("deletetxtfile(filename)");
                    Console.WriteLine("showdir(directory)");
                    Console.WriteLine("to finish loop write stop");

                    input = Console.ReadLine();
                    if (input == "stop")
                    {
                        keepgoing = false;
                        goto endLoop;
                    }

                    if (input.Contains(createFunc) || input.Contains(deleteFunc) || input.Contains(showDirFunc))
                        isAFunction = true;


                }


                //get the element in parantheses 
                string element = "";
                bool elementStarts = false;
                foreach (char c in input)
                {

                    if (elementStarts && c != ')')
                    {
                        element += c;
                    }
                    if (c == '(')
                        elementStarts = true;
                }
                string file = (path + element + ".txt");


                if (input.Contains(createFunc))//creates .txt file
                {

                    FileStream fs = File.Create(file);
                    fs.Close();
                    Console.WriteLine(".txt file created!");
                    Console.Write("Enter kundenavn i {0} file: ", element);
                    string textIn = Console.ReadLine();
                    

                    StreamWriter sw = new StreamWriter(file);
                    sw.Write(textIn);
                    
                   
                    Console.WriteLine("text was added to your new .txt file!");
                    sw.Close();

                }

                else if (input.Contains(deleteFunc))//deletes .txt file 
                {
                    System.IO.File.Delete(file);

                    Console.WriteLine(".txt file deleted!");
                }
                else if (input.Contains(showDirFunc))//access all files in directory
                {

                    string p = element;

                    DirectoryInfo d = new DirectoryInfo(p);
                    FileInfo[] files = d.GetFiles();

                    foreach (FileInfo f in files)
                    {
                        Console.WriteLine(f);
                    }

                }


                Console.ReadLine();
            }

        }
    }
}
