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


        public IActionResult RangeAreaChart()
        {

            ApexChartRangeAreaResponseModel model = new ApexChartRangeAreaResponseModel
            {
                Data = new List<ApexChartRangeAreaModel> {
                    new ApexChartRangeAreaModel { x ="Jan",y = new List<int>{ -2, 4 } },
                    new ApexChartRangeAreaModel { x ="Feb",y = new List<int>{ -1, 6 } },
                    new ApexChartRangeAreaModel { x ="Mar",y = new List<int>{ 3, 10 } },
                    new ApexChartRangeAreaModel { x ="Apr",y = new List<int>{ 8, 16 } },
                    new ApexChartRangeAreaModel { x ="May",y = new List<int>{ 13, 22 } },
                    new ApexChartRangeAreaModel { x ="Jun",y = new List<int>{ 18, 26 } },
                    new ApexChartRangeAreaModel { x ="Jul",y = new List<int>{ 21, 29 } },
                    new ApexChartRangeAreaModel { x ="Aug",y = new List<int>{ 21, 28 } },
                    new ApexChartRangeAreaModel { x ="Sep",y = new List<int>{ 17, 24 } },
                    new ApexChartRangeAreaModel { x ="Oct",y = new List<int>{ 11, 18 } },
                    new ApexChartRangeAreaModel { x ="Nov",y = new List<int>{ 6, 12 } },
                    new ApexChartRangeAreaModel { x ="Dec",y = new List<int>{ 1, 7 } },

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

        public IActionResult HeatMapChart()
        {
            ApexChartHeatMapChartResponseModel model = new ApexChartHeatMapChartResponseModel()
            {
                Data = new List<ApexChartHeatMapChartModel>()
                {
                    new ApexChartHeatMapChartModel{Name="Random 1",Count=20,MinRange=0,MaxRange=90},
                    new ApexChartHeatMapChartModel{Name="Random 2",Count=20,MinRange=0,MaxRange=90},
                    new ApexChartHeatMapChartModel{Name="Random 3",Count=20,MinRange=0,MaxRange=90},
                    new ApexChartHeatMapChartModel{Name="Random 4",Count=20,MinRange=0,MaxRange=90},
                    new ApexChartHeatMapChartModel{Name="Random 5",Count=20,MinRange=0,MaxRange=90},
                    new ApexChartHeatMapChartModel{Name="Random 6",Count=20,MinRange=0,MaxRange=90},
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


        public IActionResult FunnelChart()
        {
            ApexChartFunnelChartModel model = new ApexChartFunnelChartModel
            {
                Data = new List<int> { 70, 60, 50, 40, 30, 20, 10 },
                Categories = new List<string> { "Team A", "Team B", "Team C", "Team D", "Team E", "Team F", "Team G" }
            };
            return View(model);
        }

        public IActionResult BoxPlotChart()
        {
            ApexChartBoxPlotResponseModel model = new ApexChartBoxPlotResponseModel
            {
                Data = new List<ApexChartBoxPlotModel>()
                {
                    new ApexChartBoxPlotModel { x = "Jan 2015", y = new List<int> { 54, 66, 69, 75, 88 } },
                    new ApexChartBoxPlotModel { x = "Jan 2016", y = new List<int> { 43, 65, 69, 76, 81 } },
                    new ApexChartBoxPlotModel { x = "Jan 2017", y = new List<int> { 31, 39, 45, 51, 59 } },
                    new ApexChartBoxPlotModel { x = "Jan 2018", y = new List<int> { 39, 46, 55, 65, 71 } },
                    new ApexChartBoxPlotModel { x = "Jan 2019", y = new List<int> { 29, 31, 35, 39, 44 } },
                    new ApexChartBoxPlotModel { x = "Jan 2020", y = new List<int> { 41, 49, 58, 61, 67 } },
                    new ApexChartBoxPlotModel { x = "Jan 2021", y = new List<int> { 54, 59, 66, 71, 88 } },
                }
            };
            return View(model);
        }
        public IActionResult LineChart()
        {
            ApexChartLineChartModel model = new ApexChartLineChartModel
            {
                Series = new List<LineChartSeriesModel>
                {
                    new LineChartSeriesModel
                    {
                        Name = "Desktops",
                        Data = new List<int> { 10, 41, 35, 51, 49, 62, 69, 91, 148 }
                    }
                },
                XAxisCategories = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" }
            };

            return View(model);
        }
    }
}
