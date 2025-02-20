using Domain.ResultHandler;

namespace Domain.Errors
{
    public static class ModelError
    {
        public static readonly Error SomeError = new("ModelError Message error", ErrorHttpStatus.BadRequest);
    }
}
