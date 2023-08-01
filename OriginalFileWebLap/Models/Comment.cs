namespace OriginalFileWebLap.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public string IdUser { get; set; }
        public string NameUSer { get; set; }
        public string Content { get; set; }
        

        public Product Product { get; set; }


    }
}
