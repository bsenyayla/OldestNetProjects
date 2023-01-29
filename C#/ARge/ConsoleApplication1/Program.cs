using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            //Application.Run(new Form1());
            var connString = "Host=localhost;Username=postgres;Password=Abc12345;Database=dbCrm";



            var conn = new NpgsqlConnection(connString);
            conn.Open();

            // Insert some data
            using (var cmd = new NpgsqlCommand("INSERT INTO data (some_field) VALUES (@p)", conn)) {
                cmd.Parameters.AddWithValue("p", "Hello world");
                cmd.ExecuteNonQueryAsync();
            }

            // Retrieve all rows
            using (var cmd = new NpgsqlCommand("SELECT * FROM table_1", conn))
            using (var reader = cmd.ExecuteReader()) {
                while (reader.Read())
                    Console.WriteLine(reader.GetString(0));

            }


            Console.ReadLine();
        }
    }
}
