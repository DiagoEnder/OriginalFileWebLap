using Microsoft.Build.Framework;

namespace OriginalFileWebLap.Models
{
    public class HDH
    {
        public int Id { get; set; }
        [Required]
        public string HDHName { get; set;}

        public ICollection<Product> products { get; set; }
    }
}
