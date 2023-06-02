<<<<<<< HEAD
﻿
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
=======
﻿
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
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
