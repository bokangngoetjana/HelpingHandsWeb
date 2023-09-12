using Microsoft.AspNetCore.Identity;

public static async Task SeedRolesAsync(IServiceProvider service)
{
    var userManager = service.GetService<UserManager<ApplicationUser>>();
    var roleManager = service.GetService<RoleManager<IdentityRole<int>>>();

    for
}