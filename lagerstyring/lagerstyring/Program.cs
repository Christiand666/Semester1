using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace lagerstyring
{
    class Program
    {


        static void Main(string[] args)
        {



            bool quitprogram = false;
            while (quitprogram == false)
            {
                PrintMenu();
                string input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        Console.Write("Angiv VareNr: ");
                        String vareNr = Console.ReadLine();
                        Console.Write("Angiv vareNavn: ");
                        string vareNavn = Console.ReadLine();
                        Console.Write("angiv vare beskrivelse");
                        string Varebeskrivelse = Console.ReadLine();
                        Console.Write("Angiv vareindkøbspris");
                        string Vareindkøbspris = Console.ReadLine();
                        Console.WriteLine("Angiv Varesalgspris");
                        string Varesalgspris = Console.ReadLine();
                        Console.WriteLine("angiv varelagerbeholdning");
                        string varelagerbeholdning = Console.ReadLine();
                        Console.WriteLine("vælg et eksisterende CVRnummer mellem 1-4");
                        string CVRnummer = Console.ReadLine();
                        Insertvare(vareNr, vareNavn, Varebeskrivelse, Vareindkøbspris, Varesalgspris, varelagerbeholdning, CVRnummer);

                        break;

                    case "2":
                        Console.Write("Angiv ny VareNr: ");
                        String vareNr1 = Console.ReadLine();
                        Console.Write("Angiv ny vareNavn: ");
                        string vareNavn1 = Console.ReadLine();
                        Console.Write("angiv ny vare beskrivelse");
                        string Varebeskrivelse1 = Console.ReadLine();
                        Console.Write("Angiv ny vareindkøbspris");
                        string Vareindkøbspris1 = Console.ReadLine();
                        Console.WriteLine("Angiv ny Varesalgspris");
                        string Varesalgspris1 = Console.ReadLine();
                        Console.WriteLine("angiv ny varelagerbeholdning");
                        string varelagerbeholdning1 = Console.ReadLine();
                        Console.WriteLine("vælg et eksisterende CVRnummer mellem 1-4");
                        string CVRnummer1 = Console.ReadLine();
                        Console.WriteLine("skriv hvilket VareNr du vil ændre på");
                        string vareNr2 = Console.ReadLine();
                        Updatevare(vareNr1, vareNavn1, Varebeskrivelse1, Vareindkøbspris1, Varesalgspris1, varelagerbeholdning1, CVRnummer1, vareNr2);

                        break;

                    case "3":
                        Console.Write("Angiv hvilket vare nummer VareNr du vil slette: ");
                        String vareNr3 = Console.ReadLine();
                        Deletevare(vareNr3);

                        break;

                    case "4":
                        Console.Write("Angiv hvor mange rækker du vil have, hvis du vil have dem alle skriv 1000: ");
                        String rakkeNr4 = Console.ReadLine();
                        Readvare(rakkeNr4);

                        break;

                    case "5":
                        Console.Write("Angiv CVRnummer: ");
                        String levNr = Console.ReadLine();
                        Console.Write("Angiv leverandorNavn: ");
                        string levNavn = Console.ReadLine();
                        InsertLeverandor(levNr, levNavn);

                        break;

                    case "6":
                        Console.Write("Angiv eksisterende VareNr: ");
                        String vareNr7 = Console.ReadLine();
                        Console.Write("Angiv hvilken leverandor (1-4+): ");
                        string CVRnummer7 = Console.ReadLine();
                        BestilVare(vareNr7, CVRnummer7);

                        break;

                    case "7":
                        Console.Clear();
                        break;

                    case "11":
                        quitprogram = true;
                        break;
                }
            }



        }
        public static void PrintMenu()
        {

            Console.WriteLine("velkommen til lagerstyrings program");
            Console.WriteLine("tryk 1 for at inserte/oprette en vare");
            Console.WriteLine("tryk 2 for at Update på en bestemt vare");
            Console.WriteLine("tryk 3 for at Delete noget på en bestemt vare");
            Console.WriteLine("tryk 4 for at Read på en bestemt vare");
            Console.WriteLine("tryk 5 oprette en ny leverandør");
            Console.WriteLine("tryk 6 oprette en bestilling (anbefales at læse hvilke leverandør der kan levere hvilke Vare)");
            Console.WriteLine("tryk 7 for at clear screen");
            Console.WriteLine("tast 11 for at afslutte programmet");
            Console.Write("Enter input: ");
        }


        public static void Insertvare(string vareNr, string vareNavn, string Varebeskrivelse, string Vareindkøbspris, string Varesalgspris, string varelagerbeholdning, string CVRnummer)
        {
            string connString = "data source=localhost;initial catalog= Lagerstyring";
            connString += ";user id=Christian;password=1234";
            try
            {

                SqlConnection conn = new SqlConnection(connString);
                SqlDataAdapter adapter = new SqlDataAdapter();
                conn.Open();

                string query = " INSERT INTO Vare (VareNr, varenavn, varebeskrivelse, Vareindkøbspris, Varesalgspris, varelagerbeholdning, CVRnummer, Vareudgaaet) ";
                query += " VALUES ( " + vareNr + ", '" + vareNavn + "', '" + Varebeskrivelse + "',  " + Vareindkøbspris + ",  " + Varesalgspris + "," + varelagerbeholdning + ", " + CVRnummer + ", 0)";

                //insert
                SqlCommand cmd = new SqlCommand(query, conn);
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();

                conn.Close();
                Console.WriteLine("Lav en ny Vare");
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Det virkede ikke");
            }
        }

        public static void Updatevare(string vareNr1, string vareNavn1, string Varebeskrivelse1, string Vareindkøbspris1, string Varesalgspris1, string varelagerbeholdning1, string CVRnummer1, string vareNr2)
        {
            string connString = "data source=localhost;initial catalog= Lagerstyring";
            connString += ";user id=Christian;password=1234";
            try
            {

                SqlConnection conn = new SqlConnection(connString);
                SqlDataAdapter adapter = new SqlDataAdapter();
                conn.Open();

                string query = "UPDATE Vare SET VareNr= " + vareNr1 + ", varenavn= '" + vareNavn1 + "', varebeskrivelse= '" + Varebeskrivelse1 + "', Vareindkøbspris= " + Vareindkøbspris1 + ", Varesalgspris= " + Varesalgspris1 + ", varelagerbeholdning=" + varelagerbeholdning1 + ", CVRnummer= " + CVRnummer1 + ", Vareudgaaet=0 WHERE VareNr= " + vareNr2 + "";


                //insert
                SqlCommand cmd = new SqlCommand(query, conn);
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();

                conn.Close();
                Console.WriteLine("Din vare er updateret");
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Det virkede ikke");
            }
        }

        public static void Deletevare(string vareNr3)
        {
            string connString = "data source=localhost;initial catalog= Lagerstyring";
            connString += ";user id=Christian;password=1234";
            try
            {

                SqlConnection conn = new SqlConnection(connString);
                SqlDataAdapter adapter = new SqlDataAdapter();
                conn.Open();

                string query = "DELETE FROM Vare WHERE VareNr= " + vareNr3 + "";


                //insert
                SqlCommand cmd = new SqlCommand(query, conn);
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();

                conn.Close();
                Console.WriteLine("Vare slettet");
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Det virkede ikke");
            }
        }

        public static void Readvare(string rakkeNr4)
        {
            string connString = "data source=localhost;initial catalog= Lagerstyring";
            connString += ";user id=Christian;password=1234";
            try
            {

                SqlConnection conn = new SqlConnection(connString);

                conn.Open();

                string query = "SELECT TOP " + rakkeNr4 + "* FROM Vare";



                //insert
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.Write("vareNr=" + reader.GetValue(0));
                    Console.Write(".....\t.....");
                    Console.Write("Varenavn= " + reader.GetValue(1));
                    Console.Write(".....\t.....");
                    Console.Write("varebeskrivelse= " + reader.GetValue(2));
                    Console.Write(".....\t.....");
                    Console.Write("vareindkøbspris= " + reader.GetValue(3));
                    Console.Write(".....\t.....");
                    Console.Write("varesalgspris= " + reader.GetValue(4));
                    Console.Write(".....\t.....");
                    Console.Write("varelagerbeholding= " + reader.GetValue(5));
                    Console.Write(".....\t.....");
                    Console.Write("vareudgået(false=udgået, true=pålager= " + reader.GetValue(6));
                    Console.Write(".....\t.....");
                    Console.WriteLine("CVRnummer= " + reader.GetValue(7));

                }


                cmd.Dispose();

                conn.Close();
                Console.WriteLine("Alt information hentet");
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Det virkede ikke");
            }
            Console.ReadKey();
        }

        public static void InsertLeverandor(string levNr, string levNavn)
        {
            string connString = "data source=localhost;initial catalog= Lagerstyring";
            connString += ";user id=Christian;password=1234";
            try
            {

                SqlConnection conn = new SqlConnection(connString);
                SqlDataAdapter adapter = new SqlDataAdapter();
                conn.Open();

                string query = " INSERT INTO leverandor (CVRnummer, Navn på leverandoren) ";
                query += " VALUES ( " + levNr + ", '" + levNavn + "')";

                //insert
                SqlCommand cmd = new SqlCommand(query, conn);
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();

                conn.Close();
                Console.WriteLine("leverandør lavet");
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Det virkede ikke");
            }
        }

        public static void BestilVare(string vareNr7, string CVRnummer7)
        {
            string connString = "data source=localhost;initial catalog= Lagerstyring";
            connString += ";user id=Christian;password=1234";
            try
            {

                SqlConnection conn = new SqlConnection(connString);
                SqlDataAdapter adapter = new SqlDataAdapter();
                conn.Open();

                string query = " INSERT INTO bestilling (VareNr, CVRnummerr) ";
                query += " VALUES ( " + vareNr7 + ", " + CVRnummer7 + ")";

                //insert
                SqlCommand cmd = new SqlCommand(query, conn);
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();

                conn.Close();
                Console.WriteLine("bestilling lavet");
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Det virkede ikke, check hvilke vareNummre der er tilknyttet til leverandøren :)");
            }
        }
    }
}


