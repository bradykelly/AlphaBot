using Microsoft.Extensions.Configuration;

namespace AlphaBot.Core.Utilities
{
    public interface IDiscordSettings
    {
        string Token { get; }

        string ClientId { get; }

        IConfiguration Config { get; }
    }
}
