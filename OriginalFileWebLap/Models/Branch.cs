using Microsoft.Build.Framework;

namespace OriginalFileWebLap.Models
{
    public class Branch
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
