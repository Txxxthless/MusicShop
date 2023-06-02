
using MusicShop.Domain.Enum;

namespace MusicShop.Domain.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public InstrumentType Type { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
    }
}
