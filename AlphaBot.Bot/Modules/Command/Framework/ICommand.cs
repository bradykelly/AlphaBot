namespace AlphaBot.Core.Modules.Command.Framework
{
    public interface ICommand
    {
        Task TryTrigger(CommandContext context);

        Task Execute(CommandContext context);
    }
}
