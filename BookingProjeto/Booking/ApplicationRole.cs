using Microsoft.AspNetCore.Identity;

namespace Booking
{
    internal class ApplicationRole
    {
        private readonly RoleManager<ApplicationRole> roleManager;

        public ApplicationRole(RoleManager<ApplicationRole> roleManager)
        {
            this.roleManager = roleManager;
        }
    }

}