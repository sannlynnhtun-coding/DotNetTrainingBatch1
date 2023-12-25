using Microsoft.AspNetCore.Mvc;
using AEHKLMNSTZDotNetCore.MvcApp.Models;
using System.Collections.Generic;
using AEHKLMNSTZDotNetCore.MvcApp.Models;

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

        public IActionResult StackedBarChart()
        {
            HighChartStackedBarResponseModel model = new HighChartStackedBarResponseModel
            {
                Title = "UEFA CL top scorers by season",
                Categories = new List<string> { "2020/21", "2019/20", "2018/19", "2017/18", "2016/17" },
                Ytitle = "Goals",
                Series = new List<HighChartStackedBarModel>
                {
                    new HighChartStackedBarModel {Name = "Cristiano Ronaldo",Data = new List<int>{4, 4, 6, 15, 12}},
                    new HighChartStackedBarModel {Name = "Lionel Messi",Data = new List<int>{5, 3, 12, 6, 11}},
                    new HighChartStackedBarModel {Name = "Robert Lewandowski",Data = new List<int>{5, 15, 8, 5, 8}}
                }
            };
            return View(model);
        }

        public IActionResult InvertedAreaChart()
        {
            HighChartInvertedAreaResponseModel model = new HighChartInvertedAreaResponseModel
            {
                Title = "Alibaba and Meta (Facebook) revenue",
                Ytitle = "Revenue (billions USD)",
                Startpoint = 2016,
                Series = new List<HighChartInvertedAreaModel>
                {
                    new HighChartInvertedAreaModel {Name = "Alibaba",Data = new List<double>{11.44, 14.89, 21.40, 34.03, 51.52, 70.49, 94.46, 129.44} },
                    new HighChartInvertedAreaModel {Name = "Meta (Facebook)",Data = new List<double>{11.49, 17.08, 26.88, 39.94, 55.01, 69.65, 84.17, 117.93}},
                }
            };
            return View(model);
        }

        public IActionResult LineChart()
        {
            HighChartLineChartResponseModel model = new HighChartLineChartResponseModel
            {
                Title = "U.S Solar Employment Growth",
                YAxisTitle = "Number of Employees",
                RangeDescription = "Range: 2010 to 2020",
                PointStart = 2000,
                Datas = new List<HighChartLineChartModel>
                {
                    new HighChartLineChartModel { name = "Installation & Developers", data = Enumerable.Range(1,11).Select(x => GenerateData(1,5000)).ToList()},
                    new HighChartLineChartModel { name = "Manufacturing", data = Enumerable.Range(1,11).Select(x => GenerateData(1,5000)).ToList()},
                    new HighChartLineChartModel { name = "Operations & Maintenance", data = Enumerable.Range(1,11).Select(x => GenerateData(1,5000)).ToList()},
                    new HighChartLineChartModel { name = "Other", data = Enumerable.Range(1,11).Select(x => GenerateData(1,5000)).ToList()},
                }
            };

            return View(model);
        }
        public IActionResult LollipopChart()
        {
            HighChartLollipopResponseModel model = new HighChartLollipopResponseModel
            {
                XAxisTitle = "Top 10 Countries by Population",
                Data = new List<HighChartLollipopModel>
                {
                    new HighChartLollipopModel {Name = "India", YData = 1444216107},
                    new HighChartLollipopModel {Name = "Myanmar", YData = 50000000},
                    new HighChartLollipopModel {Name = "United States", YData = 332915073},
                    new HighChartLollipopModel {Name = "Mexico", YData = 130262216},
                    new HighChartLollipopModel {Name = "China", YData = 1444216107}
                }
            };
            return View(model);
        }

        private int GenerateData(int from, int to)
        {
            Random random = new Random();
            return random.Next(from, to);
        }
    }
}
