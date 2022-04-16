using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace AndrewBreshamerChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.Others.SendAsync("ReceiveMessage", user, message);
            //'SendMessage' send message to 'Others' to recieve "RecieveMessage" (your message w/ bool IsUser = false)
        }
        public async Task SendMessageMyself(string user, string message)
        {
            await Clients.Caller.SendAsync("ReceiveUserMessage", user, message);
            //'SendMessageMyself' send same ^^ message to 'Caller' to recieve "ReceiveMyMessage" (your message w/ bool IsUser = true)
        }
        public async Task SendMessageOthers(string user, string message)
        {
            await Clients.Others.SendAsync("ReceiveMessage", user, message);
            //'SendMessageOthers' send message to 'Others' to recieve "ReceiveMyMessage" (typing...)
        }
        public async Task HideMessageOthers(string user, string message)
        {
            await Clients.Others.SendAsync("HideReceivedMessage", user, message);
            //'HideMessageOthers' unsend message typing... to Others
        }
    }
}