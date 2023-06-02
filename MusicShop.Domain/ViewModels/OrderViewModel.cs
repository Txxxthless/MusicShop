
namespace MusicShop.Domain.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public DateTime DateOfCreation { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
