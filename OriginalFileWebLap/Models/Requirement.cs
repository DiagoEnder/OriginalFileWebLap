using Microsoft.Build.Framework;

namespace OriginalFileWebLap.Models
{
    public class Requirement
    {
        public int Id { get; set; }
        [Required]
        public string ReName { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
