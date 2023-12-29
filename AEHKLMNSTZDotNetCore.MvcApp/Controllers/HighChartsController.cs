using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.WebSockets;
using System.Collections.Generic;

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
            for (var i = 1; i <= 19; i++)
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
        public IActionResult LogarithmicAxisChart()
        {
            HighChartLogarithmicAxisChartResponseModel model = new HighChartLogarithmicAxisChartResponseModel
            {
                ChartTitle = "Logarithmic Axis Demo",
                DataPoints = new List<HighChartLogarithmicAxisChartModel>
                {
                    new HighChartLogarithmicAxisChartModel { X = 1, Y = 1 },
                    new HighChartLogarithmicAxisChartModel { X = 2, Y = 2 },
                    new HighChartLogarithmicAxisChartModel { X = 3, Y = 4 },
                    new HighChartLogarithmicAxisChartModel { X = 4, Y = 8 },
                    new HighChartLogarithmicAxisChartModel { X = 5, Y = 16 },
                    new HighChartLogarithmicAxisChartModel { X = 6, Y = 32 },
                    new HighChartLogarithmicAxisChartModel { X = 7, Y = 64 },
                    new HighChartLogarithmicAxisChartModel { X = 8, Y = 128 },
                    new HighChartLogarithmicAxisChartModel { X = 9, Y = 256 },
                    new HighChartLogarithmicAxisChartModel { X = 10, Y = 512 },
                },
            };

            return View(model);
        }

        public IActionResult AreaRangeChart()
        {
            HighChartAreaRangeChartResponseModel model = new HighChartAreaRangeChartResponseModel()
            {
                data = new List<HighChartAreaRangeChartModel>
                {
                    new HighChartAreaRangeChartModel { timestamp = 1483232400000, low = 1.4, high = 4.7 },
                    new HighChartAreaRangeChartModel { timestamp = 1485824400000, low = -1.3, high = 1.9 },
                    new HighChartAreaRangeChartModel { timestamp = 1488848400000, low = -0.7, high = 4.3 },
                    new HighChartAreaRangeChartModel { timestamp = 1492214400000, low = -5.5, high = 3.2 },
                    new HighChartAreaRangeChartModel { timestamp = 1496534400000, low = -9.9, high = -6.6 },
                    new HighChartAreaRangeChartModel { timestamp = 1500595200000, low = -9.6, high = 0.1 },
                    new HighChartAreaRangeChartModel { timestamp = 1501977600000, low = -0.9, high = 4 },
                    new HighChartAreaRangeChartModel { timestamp = 1502668800000, low = -2.2, high = 2.9 },
                    new HighChartAreaRangeChartModel { timestamp = 1503619200000, low = 1.3, high = 2.3 },
                    new HighChartAreaRangeChartModel { timestamp = 1504137600000, low = -0.3, high = 2.9 },
                    new HighChartAreaRangeChartModel { timestamp = 1505001600000, low = 1.1, high = 3.8 },
                    new HighChartAreaRangeChartModel { timestamp = 1505520000000, low = 0.6, high = 2.1 },
                    new HighChartAreaRangeChartModel { timestamp = 1507161600000, low = -3.04, high = 2.5 },
                }
            };

            return View(model);
        }

        public IActionResult SplitPackedBubbleChart()
        {
            HighChartSplitPackedBubbleChartResponseModel model = new HighChartSplitPackedBubbleChartResponseModel()
            {
                data = new List<HighChartSplitPackedBubbleChartContinentModel>
                {
                    new HighChartSplitPackedBubbleChartContinentModel
                    {
                        name="Europe",
                        data=new List<HighChartSplitPackedBubbleChartCountryModel>()
                        {
                            new HighChartSplitPackedBubbleChartCountryModel{name="Germany",value=767.1},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Croatia",value=20.7},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Belgium",value=97.2},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Czech Republic",value=111.7},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Netherlands",value=158.1},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Spain",value=241.6},
                            new HighChartSplitPackedBubbleChartCountryModel{name="France",value=323.7},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Italy",value=337.6}
                        }
                    },
                      new HighChartSplitPackedBubbleChartContinentModel
                    {
                        name="Africa",
                        data=new List<HighChartSplitPackedBubbleChartCountryModel>()
                        {
                            new HighChartSplitPackedBubbleChartCountryModel{name="Zimbabwe",value=13.1},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Kenya",value=14.1},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Ghana",value=14.1},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Sudan",value=17.3},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Tunisia",value=24.3},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Angola",value=25},
                        }
                    },
                        new HighChartSplitPackedBubbleChartContinentModel
                    {
                        name="Oceania",
                        data=new List<HighChartSplitPackedBubbleChartCountryModel>()
                        {
                            new HighChartSplitPackedBubbleChartCountryModel{name="Australia",value=409.4},
                            new HighChartSplitPackedBubbleChartCountryModel{name="New Zealand",value=34.1},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Papua New Guinea",value=7.1}
                        }
                    },
                          new HighChartSplitPackedBubbleChartContinentModel
                    {
                        name="North America",
                        data=new List<HighChartSplitPackedBubbleChartCountryModel>()
                        {
                            new HighChartSplitPackedBubbleChartCountryModel{name="Costa Rica",value=7.6},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Honduras",value=8.4},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Jamaica",value=8.3},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Panama",value=10.2},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Cuba",value=30.2},
                            new HighChartSplitPackedBubbleChartCountryModel{name="USA",value=5334.5},
                        }
                    },
                          new HighChartSplitPackedBubbleChartContinentModel
                    {
                        name="Asia",
                        data=new List<HighChartSplitPackedBubbleChartCountryModel>()
                        {
                            new HighChartSplitPackedBubbleChartCountryModel{name="Singapore",value=47.8},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Hong Kong",value=49.9},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Philippines",value=96.9},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Kuwait",value=98.6},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Thailand",value=272},
                            new HighChartSplitPackedBubbleChartCountryModel{name="Japan",value=1278.9},
                        }
                    }
                }
            };
            return View(model);
        }
    }
}

