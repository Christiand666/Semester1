using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace IOsystemopgave10
{ //1-Print filerne i en mappe.
  //2-Opret en ny fil i en mappe.
  //3-Flyt en fil fra en mappe til en anden.
  //4-Lav en backup af en fil.
  //5-Slet en fil.
  //6-Opret en ny undermappe.
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
                string movefile = "movefile";
                string backup = "backup";
                string createfolder = "create";
                string path = @"C:\Users\Christian\Documents\Test og træning af systemudvikling\";


                while (isAFunction == false)
                {
                    Console.WriteLine("functions: ");
                    Console.WriteLine("createtxtfile(filename)");
                    Console.WriteLine("deletetxtfile(filename)");
                    Console.WriteLine("showdir(directory)");
                    Console.WriteLine("movefile(from file location to another location)");
                    Console.WriteLine("backup(create copy of file to another location)");
                    Console.WriteLine("create' new folder (not txt file)");
                    Console.WriteLine("to finish loop write stop");

                    input = Console.ReadLine();
                    if (input == "stop")
                    {
                        keepgoing = false;
                        goto endLoop;
                    }

                    if (input.Contains(createFunc) || input.Contains(deleteFunc) || input.Contains(showDirFunc) || input.Contains(movefile) || input.Contains(backup) || input.Contains(createfolder))
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
                    Console.Write("Enter text for {0} file: ", element);
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
                //definere ny paths og destanations ingen betydning for brugeren kun koden der bliver mere overskuelig
                else if (input.Contains(movefile)) //moves a txt file from a location to another
                {
                    string path1;
                    string destanation1;
                    Console.Write("indsæt path1(filnavn steddog navnet på filen.txt) ");
                    path1 = Console.ReadLine();
                    Console.Write("indsæt destanation1(filnavn sted, husk og skrive navnet på filen.txt igen ");
                    destanation1 = Console.ReadLine();
                                   
                    File.Move(path1, destanation1);
                    Console.WriteLine("file moved to writen location");
                    if (!File.Exists(destanation1))
                    {
                        Console.WriteLine("filen eksistere allerede");
                    }

                }
                else if (input.Contains(backup)) //creates a backup for a txt file
                {
                    string path2;
                    string destanation2;
                    Console.Write("indsæt path2(filnavn sted og navnet på filen.txt) ");
                    path2 = Console.ReadLine();
                    Console.Write("indsæt destanation2(locations sted, husk og skrive navnet på filen.txt ");
                    destanation2 = Console.ReadLine();

                    File.Copy(path2, destanation2);
                    Console.WriteLine("filecopied");
                    if (!File.Exists(destanation2)) 
                    {
                        Console.WriteLine("filen eksistere allerede");
                    }

                }


                else if (input.Contains(createfolder))
                {
                    string path3;
                    Console.WriteLine("skriv stien du vil oprette en mappe samt navn på folder f.eks. folder1");
                    path3 = Console.ReadLine();
                    if (!Directory.Exists(path3))
                    {

                        Directory.CreateDirectory(path3);
                        Console.WriteLine("du har oprettet en mappe");
                    }
                    else
                    {
                        Console.WriteLine("denne fil existere allerede");
                    }
                  

                }
                Console.ReadLine();
            }

        }
    }
}
