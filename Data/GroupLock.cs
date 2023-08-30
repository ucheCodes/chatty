namespace Chatty.Data
{
    public class GroupLock
    {
        public string Id { get; set; } = "";
        public string GroupId { get; set; } = "";
        public string AdminId { get; set; } = "";
        public string UserLockedId { get; set; } = "";
        public bool IsLocked { get; set; } = false;
    }
}
