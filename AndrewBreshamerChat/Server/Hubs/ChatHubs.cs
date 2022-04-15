using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace AndrewBreshamerChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            //'Clients' Gets or sets an object that can be used to invoke methods on the clients connected to this hub.
        }
        public async Task SendMessageOthers(string user, string message)
        {
            await Clients.Others.SendAsync("SendMessage", user, "is typing •••");
        }
    }
}