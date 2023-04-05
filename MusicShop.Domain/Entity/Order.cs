
namespace MusicShop.Domain.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int BasketId { get; set; }
        public virtual Basket Basket { get; set; }
    }
}
