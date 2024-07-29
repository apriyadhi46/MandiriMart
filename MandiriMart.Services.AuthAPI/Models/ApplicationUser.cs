using Microsoft.AspNetCore.Identity;

namespace MandiriMart.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
