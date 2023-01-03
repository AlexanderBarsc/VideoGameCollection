using System.Data;
using System.Data.SQLite;
using Dapper;

namespace VideoGameCollection
{
    public class DataAccess
    {
        public static List<VideoGameModel> LoadVideoGamesGameModels()
        {
            using (IDbConnection cnn = CreateConnection())
            {
                var output = cnn.Query<VideoGameModel>("select * from Videogame", new DynamicParameters());

                return output.ToList();
            }
        }

        public static void AddVideoGame(VideoGameModel videoGameModel)
        {
            using (IDbConnection cnn = CreateConnection())
            {
                cnn.Execute(
                    "insert into Videogame (Name, Publisher, Platform, Owned, Price) values (@Name, @Publisher, @Platform, @Owned, @Price)",
                    videoGameModel);
            }
        }

        public static void DeleteVideoGame(string name)
        {
            using (IDbConnection cnn = CreateConnection())
            {

                
                string query = $"DELETE FROM Videogame WHERE Name='{name}'";


                cnn.Execute(query);
            }
        }

        public static void UpdateVideoGame(VideoGameModel videoGameModel)
        {
            using (IDbConnection cnn = CreateConnection())
            {

                string query = $"UPDATE Videogame SET Owned = {(int)videoGameModel.Owned} WHERE Id = {videoGameModel.Id}";

                cnn.Execute(query);
            }

        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source= GameDatabase.db");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }
    }
}
