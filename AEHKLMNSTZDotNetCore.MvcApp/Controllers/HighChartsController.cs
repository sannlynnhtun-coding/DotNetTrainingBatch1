using Microsoft.AspNetCore.Mvc;
using AEHKLMNSTZDotNetCore.MvcApp.Models;
using System.Collections.Generic;
using  AEHKLMNSTZDotNetCore.MvcApp.Models;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class HighChartsController : Controller
    {
        public IActionResult PieChart()
        {
            return View();
        }

        public IActionResult SemiCircleDonutChart()
        {
            var model = new List<HighChartSemiCircleDonutChartModel>
            {
                new HighChartSemiCircleDonutChartModel { Title = "Chrome", Point = 73.86 },
                new HighChartSemiCircleDonutChartModel { Title = "Edge", Point = 11.97 },
                new HighChartSemiCircleDonutChartModel { Title = "Firefox", Point = 5.52 },
                new HighChartSemiCircleDonutChartModel { Title = "Safari", Point = 2.98 },
                new HighChartSemiCircleDonutChartModel { Title = "Internet Explorer", Point = 1.90 },
                new HighChartSemiCircleDonutChartModel { Title = "Other", Point = 3.77 },
            };
            return View(model);
        }
        public IActionResult BasicColumnChart()
        {
            HighChartBasicColumnChartModel model = new HighChartBasicColumnChartModel
            {
                Categories = new List<string> { "USA", "China", "Brazil", "EU", "India", "Russia" },
                Name = new List<string> { "Corn", "Wheat" },
                Data = new List<List<int>>
                {
                    new List<int> { 406292, 260000, 107000, 68300, 27500, 14500 },
                    new List<int> { 51086, 136000, 5500, 141000, 107180, 77000 }
                }
            };

            return View(model);
        }
    }
}
