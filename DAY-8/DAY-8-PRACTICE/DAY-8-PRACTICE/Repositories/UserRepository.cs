using Dapper;
using DAY_8_PRACTICE.Models;
using MySqlConnector;

namespace DAY_8_PRACTICE.Repositories
{
    public class UserRepository
    {
        private readonly string _connectionString;//This stores the connection string so every
                                                  //method in the class can use it without you passing it around every time.

        public UserRepository(string connectionString)
        {
            //This is the constructor. When you create a UserRepository object you pass in
            //the connection string once and it gets stored above.
            _connectionString = connectionString;
        }
        public List<User> GetAll()
        {
            using var conn = new MySqlConnection(_connectionString);
            return conn.Query<User>("SELECT * FROM Users").ToList();
        }

        public void Insert(User user)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Execute("INSERT INTO Users (Name,Email) VALUES (@Name,@Email)",user);
        }
    }
}
