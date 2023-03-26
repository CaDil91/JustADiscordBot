using Discord;
using Discord.WebSocket;

namespace JustADiscordBot;

public class DiscordBot
{
    private readonly DiscordSocketClient _client;

    public DiscordBot()
    {
        //When working with events that have Cacheable<IMessage, ulong> parameters, you must enable the message cache in your config settings if you plan to use the cached message entity.
        var discordSocketConfig = new DiscordSocketConfig { MessageCacheSize = 100 };
        _client = new DiscordSocketClient(discordSocketConfig);
    }
    
    public async Task Execute()
    {
        
        
    }

    /// <summary>
    /// Check if DiscordBotSocketClient.ConnectionState.Connected == True.
    /// </summary>
    /// <returns>bool</returns>
    public bool IsConnected()
    {
        return _client.ConnectionState == ConnectionState.Connected;
    }
}