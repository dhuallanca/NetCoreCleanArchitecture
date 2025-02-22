using Infrastructure;

namespace WebAPI
{
    public class UserIdProvider(IHttpContextAccessor contextAccessor) : IUserIdProvider
    {
        public int UserId => (int)(contextAccessor.HttpContext?.Items["userid"] ?? 0);
    }
}
