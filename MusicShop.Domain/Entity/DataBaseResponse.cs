
using MusicShop.Domain.Enum;

namespace MusicShop.Domain.Entity
{
    public class DataBaseResponse<T> : IDataBaseResponse<T>
    {
        public string Description { get; set; }
        public StatusCode Status { get; set; }
        public T Data { get; set; }
    }

    public interface IDataBaseResponse<T>
    {
        public string Description { get; set; }
        public StatusCode Status { get; set; }
        public T Data { get; set; }
    }
}
