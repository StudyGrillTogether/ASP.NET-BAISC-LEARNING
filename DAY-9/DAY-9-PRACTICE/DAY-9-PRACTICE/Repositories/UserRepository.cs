using Dapper;
using MySqlConnector;
using DAY_9_PRACTICE.Models;


namespace DAY_9_PRACTICE.Repositories
{
    public class UserRepository
    {
        private readonly string _connectionString;
        
        public UserRepository(string connectionString)
        {
            _connectionString= connectionString;
        }

        public List<User> GetAll()
        {
            using var conn = new MySqlConnection(_connectionString);
            return conn.Query<User>("SELECT * FROM Users").ToList();
        }

        public void Insert(User user)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Execute("INSERT INTO Users (Name,Email) VALUES(@Name,@Email)", user);
        }

        public User GetById(int id)
        {
            using var conn = new MySqlConnection(_connectionString);
            return conn.QueryFirstOrDefault<User>("SELECT * FROM Users WHERE Id=@Id", new { Id = id });
        }
        public void Update(User user)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Execute("UPDATE Users SET Name=@Name,Email=@Email WHERE Id=@ID", user);
        }
        public void Delete(int id)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Execute("DELETE FROM Users WHERE Id=@Id", new { Id = id });
        }
    }
}
