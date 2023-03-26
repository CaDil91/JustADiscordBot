using Microsoft.Extensions.DependencyInjection;

namespace JustADiscordBot;

public static class CompositionRoot
{
    public static IServiceCollection ComposeApplication(this IServiceCollection services)
    {
        services.RegisterDiscordBot();
        return services;
    }
}