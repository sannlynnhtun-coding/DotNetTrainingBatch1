using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.WebSockets;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class HighChartsController : Controller
    {
        public IActionResult PieChart()
        {
            return View();
        }
        public IActionResult SplineChart()
        {
            HighSplineResponseChart model = new HighSplineResponseChart();
            model.items = new List<HighSplineChart>();
            for (var i = 1; i <= 19 ; i++)
            {
                long timestamp = DateTimeOffset.UtcNow.AddSeconds(i).ToUnixTimeMilliseconds(); ;
                model.items.Add(new HighSplineChart { x = timestamp, y = GenerateData(0, 10) });
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> TakeData()
        {
            long timestamp = DateTimeOffset.UtcNow.AddSeconds(20).ToUnixTimeMilliseconds();
            HighSplineResponseChart model = new HighSplineResponseChart
            {
                items = new List<HighSplineChart>
                {
                    new HighSplineChart{x= timestamp , y = GenerateData(0,10)}
                }
            };
            return Json(model);
        }
        private double GenerateData(int from, int to)
        {
            Random random = new Random();
            return random.Next(from, to);
        }
    }
}
