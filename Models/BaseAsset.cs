using System.ComponentModel.DataAnnotations;

namespace MAMS.Models
{
    public enum AssetType
    {
        Vehicle,
        Weapon,
        Personnel
    }

    public enum Status
    {
        Active,
        Inactive,
        Maintenance
    }


    public abstract class BaseAsset
    {
        [Key]
        public int Id;

        public string Name { get; set; } = string.Empty;
        public AssetType assetType { get; set; }
        public Status status { get; set; }
    }
}
