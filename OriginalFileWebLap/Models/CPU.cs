using Microsoft.Build.Framework;

namespace OriginalFileWebLap.Models
{
    public class CPU
    {
        public int Id { get; set; }
        [Required]
        public string CpuName { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
