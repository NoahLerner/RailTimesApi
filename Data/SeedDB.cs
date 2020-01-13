using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailTimesApi.Data
{
    public class SeedDB
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            context.Database.EnsureCreated();
            if(!context.Users.Any())
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Email = "noahlerner94@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "nlerner"
                };
                var created = userManager.CreateAsync(user, "noah@123");
            }
        } 
    }
}