﻿using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections;

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

        public IActionResult TimeLineChart()
        {

            ApexChatTimelineChartResponseModel model = new ApexChatTimelineChartResponseModel
            {
                Events = new List<ApexChatTimelineChartEventModel>
        {
            new ApexChatTimelineChartEventModel { Label = "Code", StartDate = new DateTime(2019, 3, 2), EndDate = new DateTime(2019, 3, 4) },
            new ApexChatTimelineChartEventModel { Label = "Test", StartDate = new DateTime(2019, 3, 4), EndDate = new DateTime(2019, 3, 8) },
            new ApexChatTimelineChartEventModel { Label = "Validation", StartDate = new DateTime(2019, 3, 8), EndDate = new DateTime(2019, 3, 12) },
            new ApexChatTimelineChartEventModel { Label = "Deployment", StartDate = new DateTime(2019, 3, 12), EndDate = new DateTime(2019, 3, 18) },
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

        public IActionResult BarChart()
        {
            ApexChartBarChartModel model = new ApexChartBarChartModel
            {
                Data = new List<int> { 400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380 },
                Categories = new List<string> { "South Korea", "Canada", "United Kingdom", "Netherlands", "Italy", "France", "Japan",
            "United States", "China", "Germany" }
            };
            return View(model);
        }

        public IActionResult BubbleChart()
        {
            ApexChartBubbleChartModel model = new ApexChartBubbleChartModel
            {
                Data = new List<BubbleChartDataItem>
                {
                    new BubbleChartDataItem { X = 10, Y = 20, Z = 30, Label = "Data Point 1" },
                    new BubbleChartDataItem { X = 15, Y = 25, Z = 35, Label = "Data Point 2" },
                    new BubbleChartDataItem { X = 20, Y = 30, Z = 40, Label = "Data Point 3" },
                    new BubbleChartDataItem { X = 25, Y = 35, Z = 45, Label = "Data Point 4" },
                    new BubbleChartDataItem { X = 30, Y = 40, Z = 50, Label = "Data Point 5" },
                }
            };
            return View(model);
        }

        public IActionResult MixedChart()
        {
            ApexChartMixedChartResponseModel model = new ApexChartMixedChartResponseModel
            {
                Data = new List<ApexChartMixedChartModel>
                {
                    new ApexChartMixedChartModel {name="TEAM A", type="column",data = new List<int>{ 23, 11, 22, 27, 13, 22, 37, 21, 44, 22, 30 } },
                    new ApexChartMixedChartModel {name="TEAM B", type="area",data = new List<int>{ 44, 55, 41, 67, 22, 43, 21, 41, 56, 27, 43 } },
                    new ApexChartMixedChartModel {name="TEAM C", type="line",data = new List<int>{ 30, 25, 36, 30, 45, 35, 64, 52, 59, 36, 39 } },
                },
                Label = new List<string>
                {
                    "01/01/2003","02/01/2003", "03/01/2003", "04/01/2003", "05/01/2003", "06/01/2003", "07/01/2003",
                    "08/01/2003", "09/01/2003", "10/01/2003", "11/01/2003"
                }
            };
            return View(model);
        }

        public IActionResult PolarAreaChart()
        {
            ApexChartPolarAreaChartModel model = new ApexChartPolarAreaChartModel
            {
                PolarSeries = new List<int> { 14, 23, 21, 17, 15, 10, 12, 17, 21 }
            };
            return View(model);
        }

        public IActionResult AreaChart()
        {
            ApexChartAreaChartModel model = new ApexChartAreaChartModel
            {
                prices = new List<double>
                {
                      8423.7,
      8423.5,
      8514.3,
      8481.85,
      8487.7,
      8506.9,
      8626.2,
      8668.95,
      8602.3,
      8607.55,
      8512.9,
      8496.25,
      8600.65,
      8881.1,
      9040.85,
      8340.7,
      8165.5,
      8122.9,
      8107.85,
      8128.0
                },

                dates = new List<string>
                {
                     "13 Nov 2017",
      "14 Nov 2017",
      "15 Nov 2017",
      "16 Nov 2017",
      "17 Nov 2017",
      "20 Nov 2017",
      "21 Nov 2017",
      "22 Nov 2017",
      "23 Nov 2017",
      "24 Nov 2017",
      "27 Nov 2017",
      "28 Nov 2017",
      "29 Nov 2017",
      "30 Nov 2017",
      "01 Dec 2017",
      "04 Dec 2017",
      "05 Dec 2017",
      "06 Dec 2017",
      "07 Dec 2017",
      "08 Dec 2017"
                }

            };

            return View(model);
        }

        public IActionResult ColumnChart()
        {
            //List<int> lst = new();
            //for (int i = 1; i <= 9; i++)
            //{
            //    int result = GenerateData(1, 10);
            //    lst.Add(result);
            //}

            ApexChartColumnChartModel model = new ApexChartColumnChartModel
            {
                Series = new List<ColumnChartSeriesModel>
                {
                    new ColumnChartSeriesModel
                    {
                        Name1 = "Net Profit",
                        //Data = new List<int> { 44, 55, 57, 56, 61, 58, 63, 60, 66 }
                        Data = Enumerable.Range(1, 9).Select(x => GenerateData(1, 100)).ToList(),
                    },
                    new ColumnChartSeriesModel
                    {
                        Name2 = "Revenue",
                        //Data = new List<int> { 44, 55, 57, 56, 61, 58, 63, 60, 66 }
                        Data = Enumerable.Range(1, 9).Select(x => GenerateData(1, 100)).ToList(),
                    },
                    new ColumnChartSeriesModel
                    {
                        Name3 = "Revenue",
                        //Data = new List<int> { 44, 55, 57, 56, 61, 58, 63, 60, 66 }
                        Data = Enumerable.Range(1, 9).Select(x => GenerateData(1, 100)).ToList(),
                    }
                },
                XAxisCategories = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" }
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

        private int GenerateData(int from, int to)
        {
            Random random = new Random();
            return random.Next(from, to);
        }

        public IActionResult ScatterChart()
        {
            ApexChartScatterChartResponseModel model = new ApexChartScatterChartResponseModel
            {
                Series = new List<ApexChartScatterChartModel>
                {
                    new ApexChartScatterChartModel{name = "SAMPLE A" ,data = new double[][]
                    { new double[] {16.4, 5.4},
                        new double[] {21.7, 2},
                        new double[] {25.4, 3},
                        new double[] { 19, 2 },
                        new double[] {10.9, 1},
                        new double[] {13.6, 3.2},
                        new double[] {21.7, 2},
                        new double[] {25.4, 3},
                        new double[] {19, 2},
                        new double[] {10.9, 1},
                        new double[] {13.6, 3.2},
                        new double[] {10.9, 7.4}
                    }},
                    new ApexChartScatterChartModel{name = "SAMPLE B" ,data = new double[][]
                    { new double[] {36.4, 13.4},
                        new double[] {1.7, 11},
                        new double[] { 5.4, 8 },
                        new double[] { 9, 17    },
                        new double[] { 1.9, 4 },
                        new double[] { 3.6, 12.2 },
                        new double[] { 1.4, 7 },
                        new double[] { 6.4, 8.8 },
                        new double[] { 3.6, 4.3 },
                        new double[] { 1.6, 10 },
                        new double[] { 9.9, 2 },
                        new double[] { 7.1, 15}
                    }},
                    new ApexChartScatterChartModel{name = "SAMPLE C" ,data = new double[][]
                    { new double[] { 23, 2 },
                        new double[] { 10.9, 3 },
                        new double[] { 28, 4    },
                        new double[] { 27.1, 0.3 },
                        new double[] {16.4, 4},
                        new double[] { 13.6, 0 },
                        new double[] {6.4, 8.8},
                        new double[] {28, 4},
                        new double[] {27.1, 0.3},
                        new double[] {13.6, 0},
                        new double[] {19, 5},
                        new double[] { 22.4, 3 }
                    }}
                }
            };
            return View(model);
        }
    }
}

