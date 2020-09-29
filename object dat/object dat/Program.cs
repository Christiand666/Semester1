using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace studerendetest
{
    class program
    {
        static void Main(string[] args)
        {
            string binFilePath = @"C:\Users\chris\Desktop\Skole\binærfiler1.dat";



            klient s1 = new klient("Allan", "serq1234", "dinmor");

            klient s2 = new klient("Karl Mogensen", "qwer1234", "din mor");

            klient s3 = new klient("Emma Klinkgaard", "oeur9458", "din mor");

            List<klient> klienter = new List<klient> { s1, s2, s3 };



            using (FileStream stream = new FileStream(binFilePath, FileMode.Create)) //saves students to bin file
            {

                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                foreach (klient klienten in klienter)
                    binaryFormatter.Serialize(stream, klienten);



            }



            List<klient> studentsFromBin = new List<klient>();

            using (FileStream stream = new FileStream(binFilePath, FileMode.Open)) // læs fra binary file
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                for (int i = 0; i < klienter.Count; i++)
                {
                    klient klienten = (klient)binaryFormatter.Deserialize(stream);
                    studentsFromBin.Add(klienten);
                }

            }




            foreach (klient klienten in studentsFromBin)
                Console.WriteLine(klienten.Info());
            Console.ReadLine();
        }
    }
}












