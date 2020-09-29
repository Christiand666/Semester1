using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Test_af_file
{
    string xml = File.ReadAllText(@"C:\Users\Christian\Documents\Test og træning af systemudvikling");
    string path = @"C:\Users\Christian\Documents\Skole, word";
    File.Copy(@"D:\MyFolder\test.txt", Path); 
TextWriter tw = new StreamWriter(Path);
    tw.WriteLine(xml);
tw.Close(); 
File.WriteAllText(@"D:\MyFolder\test.txt",filecontentAsaString_after_modification );



}

    
    



            

        
    



