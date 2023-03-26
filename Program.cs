using JustADiscordBot;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost? host = Host.CreateDefaultBuilder(args)
    .UseDefaultServiceProvider((context, options) => { options.ValidateScopes = true; })
    .ConfigureServices((context, services) => { services.ComposeApplication(); })
    .Build();

var discordBot = host.Services.GetRequiredService<DiscordBot>();

await discordBot.RunAsync();