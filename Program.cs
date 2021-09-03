using System.Threading;
using System;
using System.Data.SqlClient;

namespace sqlserver_connection
{
    class Program
    {
        // Application Name=Exemplo SQL Server;
        // Pooling=false;
        // Min Pool Size=0;
        // Max Pool Size=5;
        // Connection Lifetime=10;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            const string connectionString =
                @"Server=localhost;" +
                "Database=SGC_999999_Teste;" +
                "User Id=sa;" +
                "Password=Pass1234;" +
                "Pooling=false;" +
                "Application Name=Exemplo SQL Server;";

            var conn1 = new SqlConnection(connectionString);
            var conn2 = new SqlConnection(connectionString);
            var conn3 = new SqlConnection(connectionString);
            var conn4 = new SqlConnection(connectionString);
            var conn5 = new SqlConnection(connectionString);

            conn1.Open();
            conn2.Open();
            conn3.Open();
            conn4.Open();
            conn5.Open();

            conn1.Close();

            //Thread.Sleep(TimeSpan.FromSeconds(15));

            Console.ReadLine();

            conn1.Open();
            conn1.Close();

            Console.ReadLine();
        }
    }
}
