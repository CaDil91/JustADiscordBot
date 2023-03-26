using Microsoft.Extensions.Options;
using Moq;

namespace JustADiscordBot;

public class DiscordBotTests
{
    private Mock<IOptions<DiscordOptions>> _discordOptions = new();
    
    [Fact]
    public async Task CanStartBot()
    {
        //Arrange.
        _discordOptions = new Mock<IOptions<DiscordOptions>>();
        _discordOptions.Object.Value.DiscordToken = "TODO";
        
        DiscordBot discordBot = new(_discordOptions.Object);

        //Act.
        await discordBot.RunAsync();
        bool connected = discordBot.IsConnected();

        //Assert.
        Assert.True(connected);
    }
}