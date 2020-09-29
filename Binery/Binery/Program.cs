using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Binery
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("something");
                string input = Console.ReadLine();


                string path = @"C:\interger2.dat";
                

                    Random random = new Random();
                    FileStream fileStream = File.OpenWrite(path); // overwrite
                    using (BinaryWriter writer =
                        new BinaryWriter(fileStream))
                    { // using ensures writer is released ?? or does it.
                        for (int i = 1; i <= 10; i++)
                        {
                            //int n = random.Next(65, 65+27); // ASCII capital letters.
                            int n = random.Next((int)'A', (int)'Z'); // 65 .. 65+27, int er unødvendigt
                            Console.WriteLine(n);

                            //writer.Write(n); // int32 = 32 bits = 8 HEX digits
                            writer.Write((char)n); // int32 = 32 bits = 8 HEX digits
                        }
                    }
                    fileStream.Close();

                    Console.WriteLine();

                    fileStream = File.OpenRead(path);
                    using (BinaryReader reader =
                        new BinaryReader(fileStream))
                    {
                        for (int i = 1; i <= 10; i++)
                            Console.WriteLine(reader.ReadChar()); // int = int32, ReadInt
                                                                  //Console.WriteLine((int)reader.ReadChar()); // int = int32
                    }

                    Console.ReadLine();

                    // hent Hex Editor Pro (MS) og læs din dat-fil.

                    // egenskaber på filen viser dens aktuelle størrelse. Spild ikke harddiskplads med unødvendige bytes.

                }
        }
        }
    }
