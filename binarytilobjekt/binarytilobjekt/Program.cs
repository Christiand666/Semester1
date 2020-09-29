using System;
using System.Collections.Generic;
using System.IO;



namespace PrøveEksamen2
{

    class Studerende
    {
        static void Main(string[] args)
        {

            string binFilePath = @"C:\Users\Christian\Documents\Skole\binærfiler.dat";



            Studerende s1 = new Studerende("Allan", "serq1234");

            Studerende s2 = new Studerende("Karl Mogensen", "qwer1234");

            Studerende s3 = new Studerende("Emma Klinkgaard", "oeur9458");

            Underviser u1 = new Underviser("Bente Tjalfe Fede", "BTF");



            List<Studerende> students = new List<Studerende> { s1, s2, s3 };



            using (FileStream stream = new FileStream(binFilePath, FileMode.Create)) //saves students to bin file
            {

                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                foreach (Studerende student in students)
                    binaryFormatter.Serialize(stream, student);



            }



            List<Studerende> studentsFromBin = new List<Studerende>();

            using (FileStream stream = new FileStream(binFilePath, FileMode.Open)) // læs fra binary file
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                for (int i = 0; i < students.Count; i++)
                {
                    Studerende student = (Studerende)binaryFormatter.Deserialize(stream);
                    studentsFromBin.Add(student);
                }

            }




            foreach (Studerende student in studentsFromBin)
                Console.WriteLine(student.Info());






        }
    }
}
