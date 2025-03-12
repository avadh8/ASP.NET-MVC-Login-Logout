using Microsoft.AspNetCore.Identity;

namespace LoginOut.Models
{
    public class Users :IdentityUser
    {
        public string FullName { get; set; }
        
    }
}
