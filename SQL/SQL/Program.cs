using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "data source=Localhost;initial catalog= DMU19A_Foreningsdatabase";
            connString += ";user id=Christian;password=1234";
            // og I disse sikkerhedstider så skal der password på.
            string sqlstring = "SELECT * FROM Person";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader Reader = cmd.ExecuteReader();
            Int64 att0;
            try
            { // løb ResultSet igennem en tuple af gangen:
                while (Reader.Read()) // sæt curseren til næste tuple.
                {
                    att0 = Reader.FieldCount;
                    //antal attributter
                    for (int i = 0; i < att0; i++)
                    {
                        if (Reader.IsDBNull(i))
                            Console.Write("Ups den var NULL");
                        else
                        {
                            switch (Reader.GetDataTypeName(i))
                            {
                                case "smallint":
                                    Console.Write(Reader.GetInt16(i));
                                    break;
                                case "int":
                                    Console.Write(Reader.GetInt32(i));
                                    break;
                                case "bigint":
                                    Console.Write(Reader.GetInt64(i));
                                    break;
                                case "nvarchar":
                                    Console.Write(Reader.GetString(i));
                                    break;

                                case "money":
                                    Console.Write(Reader.GetDecimal(i));
                                    break;
                                default:
                                    Console.Write(Reader.GetDataTypeName(i));
                                    break;
                            }
                        }
                        Console.Write(" * ");
                    }
                    Console.WriteLine();
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Reader.Close(); // luk ResultSet
                conn.Close(); // luk connection igen
            }
            Console.ReadKey();
        }


    }



}
    
