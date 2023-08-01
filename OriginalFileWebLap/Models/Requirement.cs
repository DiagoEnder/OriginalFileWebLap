namespace OriginalFileWebLap.Models
{
    public class Requirement
    {
        public int IdRe { get; set; }
        [Required]
        public string ReName { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
