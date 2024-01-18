using AEHKLMNSTZDotNetCore.SignalRChatApp.Hubs;
using AEHKLMNSTZDotNetCore.SignalRChatApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;

namespace AEHKLMNSTZDotNetCore.SignalRChatApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHubContext<ChatHub> _chatHub;

        public HomeController(ILogger<HomeController> logger, IHubContext<ChatHub> chatHub)
        {
            _logger = logger;
            _chatHub = chatHub;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private static int count = 0;
        public async Task<IActionResult> Order()
        {
            count++;
            await _chatHub.Clients.All.SendAsync("ClientOrderReceiveMessage", count);
            return Redirect("/");
        }

        public IActionResult Chat()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
