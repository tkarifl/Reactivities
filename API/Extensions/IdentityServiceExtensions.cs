using API.Services;
using Domain;
using Persistence;

namespace API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddIdentityCore<AppUser>(opt =>
            {
                //the default options for passwords are secure enough, so no need to change them
                //I gave require non alpha numeric prop to true, even though it is true by default, I just wanted to show that we can change them as we wish
                opt.Password.RequireNonAlphanumeric = true;
            })
            .AddEntityFrameworkStores<DataContext>();
            services.AddAuthentication();
            services.AddScoped<TokenService>();

            return services;
        }
    }
}