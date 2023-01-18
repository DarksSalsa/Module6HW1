namespace Catalog.Host.Models
{
    public class ClothingPiece
    {
        public string ObjectsType { get; set; } = null!;
        public string Color { get; set; } = null!;
        public double Price { get; set; }
        public DateTime CollectionArrivalDate { get; set; }
    }
}
