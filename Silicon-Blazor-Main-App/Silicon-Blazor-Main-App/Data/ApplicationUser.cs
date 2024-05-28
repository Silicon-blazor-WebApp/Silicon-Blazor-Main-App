using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Silicon_Blazor_Main_App.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? ProfileImage { get; set; } = "avatar.svg";
        public string? Biography { get; set; }

        public string? UserAddressId { get; set; }
        public UserAddress? UserAddress { get; set; }
    }

}
