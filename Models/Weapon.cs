namespace MAMS.Models
{
    public class Weapon : BaseAsset
    {
        public string Caliber { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public int AmmunitionCount { get; set; }
    }
}
