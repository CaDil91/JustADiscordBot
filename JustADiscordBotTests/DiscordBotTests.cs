namespace JustADiscordBot;

public class DiscordBotTests
{
    [Fact]
    public async Task CanStartBot()
    {
        //Arrange.
        DiscordBot discordBot = new();

        //Act.
        await discordBot.Execute();
        bool connected = discordBot.IsConnected();

        //Assert.
        Assert.True(connected);
    }
}