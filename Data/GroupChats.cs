namespace Chatty.Data
{
    public class GroupChats
    {
        public string Id { get; set; } = "";
        public string GroupId { get; set; } = "";
        public string SenderId { get; set; } = "";
        public string SenderNames { get; set; } = "";
        public string SenderImg { get; set; } = "";
        public string Body { get; set; } = "";
        public bool IsBodyImage { get; set; } = false;
        public DateTime Date { get; set; }
    }
}
