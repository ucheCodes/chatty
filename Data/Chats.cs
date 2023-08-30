namespace Chatty.Data
{
    public class Chats
    {
        public string Id { get; set; } = "";
        public string SenderId { get; set; } = "";
        public string ReceiverId { get; set; } = "";
        public DateTime Date { get; set; }
        public string Body { get; set; } = "";
        public bool IsBodyImage { get; set; } = false;
        public bool HasReceiverViewedChat { get; set; } = false;
    }
}
