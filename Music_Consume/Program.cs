using Microsoft.Data.SqlClient;

string connectionString = "Data Source=(localdb)\\BStormLocalDB;Initial Catalog=DB_MUSIC;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=False";


//SqlConnection connection = new SqlConnection(connectionString);

//connection.Open();
//Console.WriteLine(connection.State);
//connection.Close();
//Console.WriteLine(connection.State);


// Demander la date à la DB !

//using(SqlConnection connection = new SqlConnection(connectionString))
//{
//    using (SqlCommand command = connection.CreateCommand())
//    {
//        command.CommandText = "SELECT GETDATE() as date";

//        connection.Open();
//        string date = command.ExecuteScalar().ToString();

//        Console.WriteLine(date);
//    }
//}

// Exercice 1, ajouter une artiste
// Aya Nakamura
// 2014
// 2014
// France

//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    using (SqlCommand command = connection.CreateCommand())
//    {
//        command.CommandText = "INSERT INTO dbo.[Artist] " +
//            "OUTPUT inserted.Id " +
//            "VALUES('Aya Nakamura', '2014-01-01', '2014-01-02', 'FRANCE')";


//        connection.Open();
//        int id = (int)command.ExecuteScalar();
//        Console.WriteLine(id);
//    }
//}


//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    using(SqlCommand command = connection.CreateCommand())
//    {
//        command.CommandText = "DELETE FROM dbo.[Artist] WHERE id = 1";

//        connection.Open();
//        int rows = command.ExecuteNonQuery();

//        if(rows > 0)
//        {
//            Console.WriteLine("bye aya");
//        }
//        else
//        {
//            Console.WriteLine("toujours là");
//        }
//    }
//}


//using(SqlConnection connection = new SqlConnection(connectionString))
//{
//    using(SqlCommand command = connection.CreateCommand())
//    {
//        command.CommandText = "SELECT * FROM dbo.[Artist] WHERE name like 'aya%'";

//        connection.Open();

//        using (SqlDataReader reader = command.ExecuteReader()) { 
//            while (reader.Read())
//            {
//                int id = (int)reader["Id"];
//                string name = reader["Name"].ToString();
//                DateTime creationDate = (DateTime)reader["Creation_Date"];
//                DateTime retirementDate = (DateTime)reader["Retirement_Date"];
//                string country = reader["Country"].ToString();

//                Console.WriteLine($"{id} - {name} qui débute sa carrière le {creationDate.ToString("dd-MM-yyyy")} vient de {country} ");
//            }

//        }
//    }
//}



// Exo 2 Ajout Music et lien dans la table intermédiaire


//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    using(SqlCommand command = connection.CreateCommand())
//    {
//        command.CommandText = "INSERT INTO dbo.[Music] OUTPUT Inserted.Id VALUES ('Djadja', '2018-04-06', '2:55', 'spotify.com/music/playlist/ayanakamura.com')";

//        connection.Open();

//        int id = (int)command.ExecuteScalar();

//        Console.WriteLine(id);

//    }
//};

int idArtistMusic;
using (SqlConnection connection = new SqlConnection(connectionString))
{
    using (SqlCommand command = connection.CreateCommand())
    {
        command.CommandText = "INSERT INTO dbo.[Artist_Music] OUTPUT Inserted.Id VALUES (1,2)";

        connection.Open();

        idArtistMusic = (int)command.ExecuteScalar();

        Console.WriteLine(idArtistMusic);

    }
};


using (SqlConnection connection = new SqlConnection(connectionString))
{
    using (SqlCommand command = connection.CreateCommand())
    {
        command.CommandText = "SELECT A.Name, M.Title " +
            "FROM Artist_Music AM " +
            "JOIN Artist A ON AM.Artist_Id = A.Id " +
            "JOIN Music M ON AM.Music_Id = M.Id " +
            $"";

        connection.Open();

        using (SqlDataReader reader = command.ExecuteReader()) 
        {
            while (reader.Read())
            {
                Console.WriteLine($"{reader["Name"].ToString()} - {reader["Title"].ToString()}");
            }
        }

    }
}