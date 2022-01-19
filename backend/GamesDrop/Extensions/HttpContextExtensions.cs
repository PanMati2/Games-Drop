using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace GamesDrop.Extensions
{
    public static class HttpContextExtensions
    {
        public static string GetUserId(this HttpContext httpContext)
        {
            return httpContext.User.Claims.Single(x => x.Type == ClaimTypes.NameIdentifier).Value;
        }
    }
}