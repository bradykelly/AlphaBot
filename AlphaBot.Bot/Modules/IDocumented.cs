namespace AlphaBot.Core.Modules
{
    public interface IDocumented
    {
        string Name { get; }
        string Version { get; }
        string Description { get; }
        bool Configurable { get; }
        ReleaseState ReleaseState { get; }
    }
}
