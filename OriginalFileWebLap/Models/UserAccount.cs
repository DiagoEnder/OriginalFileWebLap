namespace OriginalFileWebLap.Models
{
    public class UserAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        

        public ICollection<Comment> Comments { get; set; }
    }
}
