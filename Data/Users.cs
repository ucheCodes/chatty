namespace Chatty.Data
{
    public class Users
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Mobile { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Password1 { get; set; } = "";
        public string Password2 { get; set; } = "";
        public bool IsAdmin { get; set; }
        public string ImagePath { get; set; } = "";

    }
}
