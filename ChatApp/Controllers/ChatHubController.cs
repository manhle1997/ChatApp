using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Controllers
{
    public class ChatHubController : Hub
    {
        public async Task NewMessage(string userName, string message)
        {
            await Clients.All.SendAsync("messageReceived", userName, message);
        }
    }
}
