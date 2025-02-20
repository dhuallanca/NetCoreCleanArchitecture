
namespace Domain.ResultHandler
{
    public sealed record Error(string Message, int StatusCode)
    {
    }
}
