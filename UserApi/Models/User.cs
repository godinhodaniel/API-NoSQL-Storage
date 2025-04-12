using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace UserApi.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CodigoPessoa { get; set; }
        public string LembreteSenha { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
    }
}