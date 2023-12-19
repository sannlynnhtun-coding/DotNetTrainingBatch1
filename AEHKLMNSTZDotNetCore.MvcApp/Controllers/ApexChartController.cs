using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class ApexChartController : Controller
    {
        public IActionResult PieChart()
        {
            ApexChartPieChartModel model = new ApexChartPieChartModel
            {
                Series = new List<int> { 44, 55, 13, 43, 22 },
                Labels = new List<string> { "Team A", "Team B", "Team C", "Team D", "Team E" }
            };
            return View(model);
        }

        public IActionResult CandleStickChart()
        {
            ApexChartCandleStickChartResponseModel model = new ApexChartCandleStickChartResponseModel
            {
                Data = new List<ApexChartCandleStickChartModel>
                {
                    new ApexChartCandleStickChartModel {x = DateTime.Now.AddDays(1), y = new List<double>{ 6629.81, 6650.5, 6623.04, 6633.33 } },
                    new ApexChartCandleStickChartModel {x = DateTime.Now.AddDays(2), y = new List<double>{ 6632.01, 6643.59, 6620, 6630.11 } },
                    new ApexChartCandleStickChartModel {x = DateTime.Now.AddDays(3), y = new List<double>{ 6630.71, 6648.95, 6623.34, 6635.65 } },
                    new ApexChartCandleStickChartModel {x = DateTime.Now.AddDays(4), y = new List<double>{ 6635.65, 6651, 6629.67, 6638.24 } },
                    new ApexChartCandleStickChartModel {x = DateTime.Now.AddDays(5), y = new List<double>{ 6638.24, 6640, 6620, 6624.47 } },
                }
            };
            return View(model);
        }
    
        public IActionResult RadarChart()
        {
            ApexChartRadarChartModel model = new ApexChartRadarChartModel
            {
                Datas = new List<int> { 80, 50, 30, 40, 100, 20 },
                Categories = new List<string> { "January", "February", "March", "April", "May", "June" }
            };
            return View(model);
        }
        public IActionResult TreeMap()
        {
            ApexChatTreeMapResponseModel model = new ApexChatTreeMapResponseModel
            {
                Items = new List<ApexChatTreeMapModel>
                {
                    new ApexChatTreeMapModel {x = "Bangaluru", y = 336} ,
                    new ApexChatTreeMapModel {x = "Ahmedabad", y = 132} ,
                    new ApexChatTreeMapModel {x = "Mumbai", y = 240} ,
                    new ApexChatTreeMapModel {x = "Kolkata", y =  28 },
                    new ApexChatTreeMapModel {x ="New Delhi", y = 18},
                    new ApexChatTreeMapModel {x = "Bangaluru", y = 36} ,
                    new ApexChatTreeMapModel {x = "Ahmedabad", y = 12} ,
                    new ApexChatTreeMapModel {x = "Mumbai", y = 240} ,
                    new ApexChatTreeMapModel {x = "Kolkata", y =  358 },
                    new ApexChatTreeMapModel {x ="New Delhi", y = 658},
                }
            };
            return View(model);
        }
        public IActionResult RadialBarChart()
        {
            ApexChartRadialBarChartModel model = new ApexChartRadialBarChartModel()
            {
                Series = new List<int> { 44, 55, 67, 83 },
                Lables = new List<string> { "Apples", "Oranges", "Bananas", "Berries" },
                Label = "Total"
            };
            return View(model);
        }
    }
}
