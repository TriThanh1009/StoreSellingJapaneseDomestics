using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
namespace StoreSellingJapaneseDomestics.Services
{
    public class OrderHub : Hub
    {
        public async Task SendOrder(string order)
        {
            await Clients.All.SendAsync("ReceiveOrder", order);
        }
    }
}
