using Microsoft.AspNetCore.SignalR;

public class ViewHub : Hub
{
    public static int ViewCount { get; set; } = 0;
    public async Task NotifyWatching()
    {
        ViewCount++;
        // notify everyOne about view count
        await Clients.All.SendAsync("viewCountUpdate", ViewCount);
    }
}