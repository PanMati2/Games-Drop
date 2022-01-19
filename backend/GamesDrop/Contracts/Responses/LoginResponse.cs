using System.Collections.Generic;

namespace GamesDrop.Contracts.Responses
{
    public class LoginResponse
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccessToken { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}