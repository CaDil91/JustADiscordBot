using Microsoft.Extensions.DependencyInjection;

namespace JustADiscordBot;

public static class DIRegistrations
{
    public static IServiceCollection RegisterDiscordBot(this IServiceCollection services)
    {
        services.AddTransient<DiscordBot>();
        return services;
    }
}