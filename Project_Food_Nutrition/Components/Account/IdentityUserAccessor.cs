using Project_Food_Nutrition.Data;
using Microsoft.AspNetCore.Identity;

namespace Project_Food_Nutrition.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<Project_Food_NutritionUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<Project_Food_NutritionUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
