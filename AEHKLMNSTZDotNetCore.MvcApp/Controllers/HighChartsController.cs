using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.WebSockets;
﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult FanChart()
        {
            // Sample data for the fan chart
            var model = new HighchartsFanChartResponseModel
            {
                Data = new List<HighchartsFanChartModel>
                {
                    new HighchartsFanChartModel { Name = "Point 1", Y = 10, Low = 5, High = 15 },
                    new HighchartsFanChartModel { Name = "Point 2", Y = 158, Low = 100, High = 208 },
                    new HighchartsFanChartModel { Name = "Point 3", Y = 207, Low = 80, High = 350 },
                    new HighchartsFanChartModel { Name = "Point 4", Y = 180, Low = 111, High = 426 },
                    new HighchartsFanChartModel { Name = "Point 5", Y = 224, Low = 124, High = 524 },
                    new HighchartsFanChartModel { Name = "Point 6", Y = 455, Low = 246, High = 600 },
                    

                }
            };

            return View(model);
        }

        private int GenerateData(int from, int to)
        {
            Random random = new Random();
            return random.Next(from, to);
        }

		public IActionResult DoeNetChart()
		{
			HighChartsDoeNetResponseModel model = new HighChartsDoeNetResponseModel
			{
				Name = "Medals",
				Data = new List<HighChartsDoeNetModel>
				{
					new HighChartsDoeNetModel {Country = "Norway", Count=16},
					new HighChartsDoeNetModel {Country = "Germany", Count=12},
					new HighChartsDoeNetModel {Country = "USA", Count=8},
					new HighChartsDoeNetModel {Country = "Sweden", Count=8},
					new HighChartsDoeNetModel {Country = "Netherlands", Count=8},
					new HighChartsDoeNetModel {Country = "ROC", Count=6},
					new HighChartsDoeNetModel {Country = "Austria", Count=7},
					new HighChartsDoeNetModel {Country = "Canada", Count=4},
					new HighChartsDoeNetModel {Country = "Japan", Count=3},
				}
			};
			return View(model);
		}
	}
}
