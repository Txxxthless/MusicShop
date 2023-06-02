<<<<<<< HEAD
﻿
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
=======
﻿
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
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
