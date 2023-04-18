namespace CheckInStyle.Models.Usuario
{
    public class User
    {
        public long UserId { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string UrlFoto { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}