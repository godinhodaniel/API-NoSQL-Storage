using MongoDB.Driver;
using UserApi.Models;

namespace UserApi.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("MongoDb"));
            var database = client.GetDatabase("UserDb");
            _users = database.GetCollection<User>("Users");
        }

        public List<User> Get() => _users.Find(u => true).ToList();

        public User GetByEmail(string email) =>
            _users.Find(u => u.Email == email).FirstOrDefault();

        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public void Update(string id, User userIn) =>
            _users.ReplaceOne(u => u.Id == id, userIn);

        public void Remove(string id) =>
            _users.DeleteOne(u => u.Id == id);
    }
}