using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Hosting;

namespace Chatty.Data
{
    public class AppHub : Hub
    {
        public const string HubUrl = "/signalr";
        public async void SendMessage(Chats chat)
        {
            await Clients.All.SendAsync("NewChat", chat);
        }
        public async void DeleteChat(string section, string id)
        {
            if (section != "" && id != "")
            {
                await Clients.All.SendAsync("Delete", section,id);
            }
        }
        public async void AddGroupChat(GroupChats chat)
        {
            if (chat.Id != "" && chat.GroupId != "")
            {
                await Clients.All.SendAsync("NewGroupChat", chat);
            }
        }
        public async void AddGroup(Groups group)
        {
            if (group.Id != "")
            {
                await Clients.All.SendAsync("NewGroup", group);
            }
        }
        public async void UpdateLastSeen(string userId)
        {
            if (userId != "")
            {
                await Clients.All.SendAsync("RefreshLastSeen", userId);
            }
        }
        public async void AddRemoveActiveUser(string userId,string operation)
        {
            if (userId != "" && operation != "")
            {
                await Clients.All.SendAsync("UpdateActiveUserStatus", userId,operation);
            }
        }
    }
}
