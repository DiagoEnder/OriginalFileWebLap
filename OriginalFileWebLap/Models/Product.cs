namespace OriginalFileWebLap.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public double Price { get; set; }


        public int IdBranch { get; set; }
        public int IdCpu { get; set; }
        public int IdHdh { get; set; }
        public int IdRam { get; set; }
        public int IdRquire { get; set; }


        public Branch Branch { get; set; }
        public CPU CPU { get; set; }
        public HDH HDH { get; set; }
        public Ram Ram { get; set; }
        public Requirement Requirement { get; set; }

        public ICollection<Comment> comments { get; set; }
        
    }
}
