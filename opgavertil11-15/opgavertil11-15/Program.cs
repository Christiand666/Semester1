using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace opgavertil11_15
{
    class Program
    {
      

    [Serializable]
        public class SomeClass
        {
            public string someProperty { get; set; }
        }
       
        
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");

                string path = @"c:\Objects3.dat";

                // 4 strings to save ;-)
                SomeClass object1 = new SomeClass { someProperty = "someString1" };
                SomeClass object2 = new SomeClass { someProperty = "someString2" };
                SomeClass object3 = new SomeClass { someProperty = "someString3" };
                SomeClass object4 = new SomeClass { someProperty = "someString4" };

                // unefficient (open file for just one object)
                WriteToBinaryFile<SomeClass>(path, object1);
                WriteToBinaryFile<SomeClass>(path, object2, true);
                WriteToBinaryFile<SomeClass>(path, object3, true);
                WriteToBinaryFile<SomeClass>(path, object4, true);

                // read file, to known end.
                using (Stream stream = File.Open(path, FileMode.Open)) // reopen, all the time
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    var o1 = (SomeClass)binaryFormatter.Deserialize(stream); // var == SomeClass
                    Console.WriteLine(o1.someProperty);

                    for (int i = 2; i <= 4; i++)
                        Console.WriteLine(((SomeClass)binaryFormatter.Deserialize(stream)).someProperty);

                    try
                    {
                        Console.WriteLine(((SomeClass)binaryFormatter.Deserialize(stream)).someProperty);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("EOF reached, apparently."); // End Of File = EOF
                    }
                }
                Console.ReadLine();
            }

            /// <summary>
            /// Writes the given object instance to a binary file.
            /// <para>Object type (and all child types) must be decorated with the [Serializable] attribute.</para>
            /// <para>To prevent a variable from being serialized, decorate it with the [NonSerialized] attribute; cannot be applied to properties.</para>
            /// </summary>
            /// <typeparam name="T">The type of object being written to the binary file.</typeparam>
            /// <param name="filePath">The file path to write the object instance to.</param>
            /// <param name="objectToWrite">The object instance to write to the binary file.</param>
            /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
            public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
            {
                using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binaryFormatter.Serialize(stream, objectToWrite);
                }
            }

            /// <summary>
            /// Reads an object instance from a binary file.
            /// </summary>
            /// <typeparam name="T">The type of object to read from the binary file.</typeparam>
            /// <param name="filePath">The file path to read the object instance from.</param>
            /// <returns>Returns a new instance of the object read from the binary file.</returns>
            public static T ReadFromBinaryFile<T>(string filePath)
            {
                using (Stream stream = File.Open(filePath, FileMode.Open)) // reopen, all the time
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    return (T)binaryFormatter.Deserialize(stream);
                }
            }

            [Serializable]
            public class Item
            {
                public int Id { get; set; }
                public string Description { get; set; }
                public int Price { get; set; }
                public int InStock { get; set; }
            }
        }
    }

