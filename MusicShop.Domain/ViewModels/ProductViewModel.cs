
using MusicShop.Domain.Enum;

namespace MusicShop.Domain.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public InstrumentType Type { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
    }
}
