﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunde_med_telefonummer
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kunde er en klasse og kunde3 er et objekt af kundeklassen 
            Kunde kunde3 = new Kunde(255669503, 0, "ole");


            Kunde kunde4 = new Kunde(2566957, 1, "frederik");

            Console.WriteLine(kunde3.navn);

            
            Console.ReadLine();
        }
    }
}