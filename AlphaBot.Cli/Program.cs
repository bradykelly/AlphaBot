using AlphaBot.Cli;
using AlphaBot.Core;
using AlphaBot.Core.Modules;
using AlphaBot.Core.Modules.Command;
using AlphaBot.Core.Modules.Command.Commands;
using AlphaBot.Core.Modules.Command.Framework;
using AlphaBot.Core.Utilities;
using Discord.WebSocket;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        // Settings
        services.AddSingleton<IDiscordSettings, DiscordSettings>();

        // Bot
        services.AddSingleton<DiscordSocketClient>();
        services.AddSingleton<IBot, Bot>();

        // Hosted services
        services.AddHostedService<Worker>();

        // Commands
        services.AddSingleton<IModule, CommandManager>();
        services.AddSingleton<ICommand, AboutCommand>();

        // All Modules
        services.AddSingleton<IList<IModule>>(s => s.GetServices<IModule>().ToList());
        services.AddSingleton<IList<ICommand>>(s => s.GetServices<ICommand>().ToList());
    })
    .Build();

await host.RunAsync();
