namespace OriginalFileWebLap.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdUser { get; set; }
        public string NameUSer { get; set; }
        public string Content { get; set; }
        

        public Product Product { get; set; }
        public UserAccount User { get; set; }


    }
}
