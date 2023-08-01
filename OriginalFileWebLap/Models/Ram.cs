using Microsoft.Build.Framework;

namespace OriginalFileWebLap.Models
{
    public class Ram
    {
        public int Id { get; set; }
        [Required]
        public string RaName { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
