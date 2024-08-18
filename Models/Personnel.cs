using Microsoft.EntityFrameworkCore;

namespace MAMS.Models
{
    public class Personnel : BaseAsset
    {
        public string Rank { get; set; } = string.Empty;
        public string ServiceNumber { get; set; } = string.Empty;
        public string AssignedUnit { get; set; } = string.Empty;
    }
}
