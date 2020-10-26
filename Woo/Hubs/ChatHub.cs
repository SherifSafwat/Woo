using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Woo.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {

            await Clients.All.SendAsync("ReceiveMessage", user, Context.ConnectionId + "-all");
        }

        public Task SendPrivateMessage(string user, string message)
        {
            int i = 0;


            var q111 = Clients.Client(message).SendAsync("ReceiveMessage", user, message + "-pv1");
            var q11 = Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", user, message + "-pv2");
            var q1 = Clients.User(message).SendAsync("ReceiveMessage", user, message + "-pv3");
            return Clients.User(user).SendAsync("ReceiveMessage", user, message + "-pv4");
        }
    }
}