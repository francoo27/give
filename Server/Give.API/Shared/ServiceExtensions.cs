using Give.DataAccess.Abstractions;
using Give.DataAccess.Repositories;
using Give.Service.Abstractions;
using Give.Service.Services;

public static class ServiceExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ICampaignRepository, CampaignRepository>();

        services.AddScoped<ICampaignService, CampaignService>();
        return services;
    }
}
