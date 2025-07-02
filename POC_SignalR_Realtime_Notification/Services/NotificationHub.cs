using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using System;

public class NotificationHub : Hub
{
    public override Task OnConnectedAsync()
    {
        Console.WriteLine($"[Hub] Connected: {Context.ConnectionId}");
        return base.OnConnectedAsync();
    }

    public async Task SendMessageToAll(string message)
    {
        await Clients.All.SendAsync("Broadcast", $"📢 {message}");
    }
}