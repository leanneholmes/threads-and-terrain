using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "User",
                    Email = "user@test.com",
                    UserName = "user@test.com",
                    Address = new Address
                    {
                        FirstName = "Sample",
                        LastName = "User",
                        Street = "123 Fake Street",
                        City = "Toronto", 
                        Province = "ON",
                        Postalcode = "L4K M9W"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}