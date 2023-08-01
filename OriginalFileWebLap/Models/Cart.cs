namespace OriginalFileWebLap.Models
{
    public class Cart
    {
        public int IdCart { get; set; }
        public int IdPro { get; set; }
        public string NamePro { get; set; }
        public string imgPro { get; set; }
        public int IdUser { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total => Price * Quantity;

        public ICollection<Product> products { get; set; }
        
    }
}
