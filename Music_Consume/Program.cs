using Microsoft.Data.SqlClient;

string connectionString = "Data Source=(localdb)\\BStormLocalDB;Initial Catalog=DB_MUSIC;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=False";


//SqlConnection connection = new SqlConnection(connectionString);

//connection.Open();
//Console.WriteLine(connection.State);
//connection.Close();
//Console.WriteLine(connection.State);


// Demander la date à la DB !

using(SqlConnection connection = new SqlConnection(connectionString))
{
    using (SqlCommand command = connection.CreateCommand())
    {
        command.CommandText = "SELECT GETDATE() as date";

        connection.Open();
        string date = command.ExecuteScalar().ToString();

        Console.WriteLine(date);
    }
}