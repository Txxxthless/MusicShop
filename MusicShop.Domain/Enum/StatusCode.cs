
namespace MusicShop.Domain.Enum
{
    public enum StatusCode
    {
        UserNotFound = 0,
        UserAlreadyExists = 1,

        ProductNotFound = 10,

        OK = 200,
        InternalServerError = 500
    }
}
