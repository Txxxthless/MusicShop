
namespace MusicShop.Domain.Entity
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
    }
}
