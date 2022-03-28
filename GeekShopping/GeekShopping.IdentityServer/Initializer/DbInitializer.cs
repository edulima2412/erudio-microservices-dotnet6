using GeekShopping.IdentityServer.Configuration;
using GeekShopping.IdentityServer.Model;
using GeekShopping.IdentityServer.Model.Context;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace GeekShopping.IdentityServer.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly MySqlContext _context;
        private readonly UserManager<ApplicationUser> _user;
        private readonly RoleManager<IdentityRole> _role;

        public DbInitializer(MySqlContext context, UserManager<ApplicationUser> user, RoleManager<IdentityRole> role)
        {
            _context = context;
            _user = user;
            _role = role;
        }

        public void Initialize()
        {
            if (_role.FindByNameAsync(IdentityConfiguration.Admin).Result != null) return;

            _role.CreateAsync(new IdentityRole(IdentityConfiguration.Admin))
                .GetAwaiter().GetResult();
            _role.CreateAsync(new IdentityRole(IdentityConfiguration.Client))
                .GetAwaiter().GetResult();

            #region Admin

            ApplicationUser admin = new ApplicationUser
            {
                UserName = "edu-admin",
                Email = "edu-admin@email.com",
                EmailConfirmed = true,
                PhoneNumber = "+55 (85) 12345-6789",
                FirstName = "Edu",
                LastName = "Admin"
            };

            _user.CreateAsync(admin, "Edu#1234")
                .GetAwaiter().GetResult();
            _user.AddToRoleAsync(admin, IdentityConfiguration.Admin)
                .GetAwaiter().GetResult();

            var adminClaims = _user.AddClaimsAsync(admin, new Claim[]
            {
                new Claim(JwtClaimTypes.Name, $"{admin.FirstName} {admin.LastName}"),
                new Claim(JwtClaimTypes.GivenName, admin.FirstName),
                new Claim(JwtClaimTypes.FamilyName, admin.LastName),
                new Claim(JwtClaimTypes.Role, IdentityConfiguration.Admin)
            }).Result;

            #endregion

            ApplicationUser client = new ApplicationUser
            {
                UserName = "edu-client",
                Email = "edu-client@email.com",
                EmailConfirmed = true,
                PhoneNumber = "+55 (85) 12345-6789",
                FirstName = "Edu",
                LastName = "Client"
            };

            _user.CreateAsync(client, "Edu#1234")
                .GetAwaiter().GetResult();
            _user.AddToRoleAsync(client, IdentityConfiguration.Client)
                .GetAwaiter().GetResult();

            var clientClaims = _user.AddClaimsAsync(client, new Claim[]
            {
                new Claim(JwtClaimTypes.Name, $"{client.FirstName} {client.LastName}"),
                new Claim(JwtClaimTypes.GivenName, client.FirstName),
                new Claim(JwtClaimTypes.FamilyName, client.LastName),
                new Claim(JwtClaimTypes.Role, IdentityConfiguration.Client)
            }).Result;
        }
    }
}
