using TikTokLiveSharp.Models.Protobuf;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class LinkLayerMessage : AMessageData
    {
        /// <summary>
        /// UNCONFIRMED
        /// </summary>
        public readonly ulong LinkId;

        public readonly (ulong, ulong) Link1;
        public readonly (ulong, ulong) Link2;

        internal LinkLayerMessage(WebcastLinkLayerMessage msg)
            : base(msg.Header.RoomId, msg.Header.MessageId, msg.Header.ServerTime)
        {
            LinkId = msg.Id1;
            Link1 = (msg.IDContainer.Ids.Id1, msg.IDContainer.Ids.Id2);
            Link2 = (msg.IDContainer2.Ids.Id1, msg.IDContainer2.Ids.Id2);
        }
    }
}