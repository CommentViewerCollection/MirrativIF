using SitePlugin;

namespace MirrativSitePlugin
{
    public enum MirrativMessageType
    {
        Unknown,
        Comment,
        JoinRoom,
        Connected,
        Disconnected,
    }

    public interface IMirrativMessage : IMessage
    {
        MirrativMessageType MirrativMessageType { get; }
    }
    public interface IMirrativConnected : IMirrativMessage
    {
    }
    public interface IMirrativDisconnected : IMirrativMessage
    {
    }
    public interface IMirrativComment : IMirrativMessage
    {
        //string Comment { get; }
        string Id { get; }
        //string UserName { get; }
        string UserId { get; }
        long PostedAt { get; }
        IMessageImage UserIcon { get; set; }
    }
    public interface IMirrativJoinRoom : IMirrativMessage
    {
        //string Comment { get; }
        string Id { get; }
        //string UserName { get; }
        string UserId { get; }
        long PostedAt { get; }
        IMessageImage UserIcon { get; set; }
    }
}