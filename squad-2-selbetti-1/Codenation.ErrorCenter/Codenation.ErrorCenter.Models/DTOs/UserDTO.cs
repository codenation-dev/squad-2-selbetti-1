namespace Codenation.ErrorCenter.Models.DTOs
{
    public class UserDTO
    {
        public long Id { get; set; }

        public long Name { get; set; }

        public long Email { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }
    }
}
