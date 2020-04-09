using Lab02.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Lab02.Data
{
    public class DbHelper
    {
        public static void SeedData(ApplicationDbContext db, UserManager<IdentityUser> userManager, ILogger log)
        {
            SeedIllustrations(db, log);
            SeedUsers(userManager, log);
        }

        public static async void SeedIllustrations(ApplicationDbContext db, ILogger log)
        {
            var i = db.Illustrations.FirstOrDefault();
            if(i == null)
            {
                log.LogInformation("Seeding Illustration Music");
                var illustrations = new List<Illustration>();

                i = new Illustration()
                {
                    Year = DateTime.Now.Year,
                    Month = DateTime.Now.Month,
                    Name = "Lady in the Snow",
                    Description = "Young lady walking in the snow \nWe wonder how long she has to go \nAnd why she might be on this road.",
                    ImageUrl = "Graphics/lady.jpg"
                };
                illustrations.Add(i);

                i = new Illustration()
                {
                    Year = DateTime.Now.Year,
                    Month = DateTime.Now.Month,
                    Name = "Travel my friend",
                    Description = "Grap your guide and further yo must go\nuntil you don't feel the grasp of the wild take hold\nThen you can se yourself become strong.",
                    ImageUrl = "/Graphics/destination.jpg"
                };
                illustrations.Add(i);

                db.Illustrations.AddRange(illustrations);
                await db.SaveChangesAsync();

            }
        }

        public static async void SeedUsers(UserManager<IdentityUser> userManager, ILogger log)
        {
            // T H E      A D M I N      U S E R
            const string adminEmail = "aa@aa.aa";
            const string adminPassword = "AaAaAa12/";
            if (userManager.FindByNameAsync(adminEmail).Result == null)
            {
                log.LogWarning("Seeding the admin user");
                var user = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail
                };
                IdentityResult result = userManager.CreateAsync
                (user, adminPassword).Result;
                if (result.Succeeded)
                {
                    var adminClaim = new Claim("Admin", "Yes");
                    await userManager.AddClaimAsync(user, adminClaim);
                }
            }
        }
    }
}
