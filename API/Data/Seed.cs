using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace API.Data
{
    public class Seed
    {

        public static async Task SeedUsers (DataDbContext context)
        {
            if (await context.Users.AnyAsync()) return;
            var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
            var Users = JsonSerializer.Deserialize<List<AppUser>>(userData);
            foreach (var user in Users)
            {

                user.UserName = user.UserName.ToLower();


                context.Users.Add(user);
            }

            await context.SaveChangesAsync();
        }
    }
}
