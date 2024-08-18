namespace MAMS.Models
{
    public class Vehicle : BaseAsset
    {
        public string Model { get; set; } = string.Empty;
        public string LicensePlate { get; set; } = string.Empty;
        public string OperationalStatus { get; set; } = string.Empty;

    }
}
