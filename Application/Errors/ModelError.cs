using Application.ResultHandler;

namespace Application.Errors
{
    public static class ModelError
    {
        public static readonly Error SomeError = new("ModelError Message error", ErrorHttpStatus.BadRequest);
    }
}
