using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class ChartJsController : Controller
    {
        public IActionResult PieChart()
        {
            ChartJsPieChartModel model = new ChartJsPieChartModel
            {
                Labels = new List<string> { "Red", "Blue", "Yellow" },
                Label = "My First Dataset",
                Data = new List<int> { 300, 50, 100 },
                BackgroundColor = new List<string> { "rgb(255, 99, 132)", "rgb(54, 162, 235)", "rgb(255, 205, 86)" }

            };
            return View(model);
        }

        public IActionResult HorizontalBarChart()
        {
            ChartJsHorizontalBarChartResponseModel model = new ChartJsHorizontalBarChartResponseModel
            {
                DataCount = 7,
                Labels = new List<string> { "January", "February", "March", "April", "May", "June", "July" },
                DataSets = new List<ChartJsHorizontalBarChartModel>
                {
                    new ChartJsHorizontalBarChartModel
                    {
                        Data = Enumerable.Range(1, 7).Select(x => GenerateData (1, 100)).ToList(),
                        Label = "Dataset 1",
                        BorderColor = "rgb(255, 99, 132)",
                        BackgroundColor = "rgb(255, 99, 132)"

                    },
                     new ChartJsHorizontalBarChartModel
                    {
                        Data = Enumerable.Range(1, 7).Select(x => GenerateData (1, 100)).ToList(),
                        Label = "Dataset 2",
                        BorderColor = "rgb(54, 162, 235)",
                        BackgroundColor = "rgb(54, 162, 235)"

                    },
                }
            };
            return View(model);
        }

        public IActionResult StackedBarLineChart()
        {
            ChartJsStackedBarLineChartResponseModel model = new ChartJsStackedBarLineChartResponseModel
            {
                DataCount = 7,
                Labels = new List<string> { "June", "July", "August", "September", "October", "November", "December" },
                DataSets = new List<ChartJsStackedBarLineChartModel>
                {
                    new ChartJsStackedBarLineChartModel
                    {
                        Data = Enumerable.Range(1, 7).Select(x => GenerateData (1, 100)).ToList(),
                        Label = "Dataset 1",
                        BorderColor = "rgb(255, 99, 132)",
                        BackgroundColor = "rgb(255, 99, 132)"

                    },
                     new ChartJsStackedBarLineChartModel
                    {
                        Data = Enumerable.Range(1, 7).Select(x => GenerateData (1, 100)).ToList(),
                        Label = "Dataset 2",
                        BorderColor = "rgb(54, 162, 235)",
                        BackgroundColor = "rgb(54, 162, 235)"

                    },
                }
            };

            return View(model);
        }

        public IActionResult LegendPointStyle()
        {
            ChartJsLegendPointStyleModel model = new ChartJsLegendPointStyleModel
            {
                DataCount = 7,
                Labels = new List<string> { "January", "February", "March", "April", "May", "June", "July" },
                Title = "Dataset 1",
                Data = new List<int> { 34, -59, -18, -83, -81, 61, -47 },
                BorderColor = "rgb(255, 99, 132)",
                BackgroundColor = "rgb(255, 99, 132)"
            };
            return View(model);
        }

        private int GenerateData(int from, int to)
        {
            Random random = new Random();
            return random.Next(from, to);
        }

        public IActionResult ScatterMultiAxisChart()
        {
            ChartJsScatterMultiAxisChartResponseModel model = new ChartJsScatterMultiAxisChartResponseModel
            {
                Datasets = new List<ChartJsScatterMultiAxisChartModel>
                {
                    new ChartJsScatterMultiAxisChartModel
                    {
                        Label = "Dataset 1",
                        Data = new List<Point>
                        {
                            new Point { X = -92, Y = 54 },
                            new Point { X = -71, Y = 6 },
                            new Point { X = -17, Y = 58 },
                            new Point { X = 23, Y = -11 },
                            new Point { X = 40, Y = -66 },
                            new Point { X = 97, Y = 10 },
                            new Point { X = 97, Y = -62 }
                        },
                        BorderColor = "rgb(255, 99, 132)",
                        BackgroundColor = "rgb(255, 99, 132)",
                        YAxisID = "y2"
                    },

                    new ChartJsScatterMultiAxisChartModel
                    {
                        Label = "Dataset 2",
                        Data = new List<Point>
                        {
                            new Point { X = -50, Y = 30 },
                            new Point { X = -30, Y = 10 },
                            new Point { X = 10, Y = -20 },
                            new Point { X = 45, Y = 5 },
                            new Point { X = 60, Y = -40 }
                        },
                        BorderColor = "rgb(255, 159, 64)",
                        BackgroundColor = "rgb(255, 159, 64)",
                        YAxisID = "y2"
                    }
                }
            };
            return View(model);
        }

        public IActionResult PointStylingChart()
        {
            ChartJSPointStylingChartModel model = new ChartJSPointStylingChartModel
            {
                Categories = new List<string> { "Day 1", "Day 2", "Day 3", "Day 4", "Day 5", "Day 6", "Day 7" },
                Data = new List<int> { 300, 50, 100, 300, 50, 100, 20 },

            };
            return View(model);
        }

        public IActionResult VerticalBarChart()
        {
            ChartJsVerticalBarChartResponseModel model = new ChartJsVerticalBarChartResponseModel
            {
                DataCount = 7,
                Labels = new List<string> { "January", "February", "March", "April", "May", "June", "July" },
                Charts = new List<ChartJsVerticalBarChartModel>
                {
                    new ChartJsVerticalBarChartModel
                    {
                        Data = Enumerable.Range(1, 7).Select(x => GenerateData (1, 100)).ToList(),
                        Label = "Dataset 1",
                        BorderColor = "rgb(255, 99, 132)",
                        BackgroundColor = "rgb(255, 99, 132)"
                    },
                    new ChartJsVerticalBarChartModel
                    {
                        Data = Enumerable.Range(1, 7).Select(x => GenerateData (1, 100)).ToList(),
                        Label = "Dataset 2",
                        BorderColor = "rgb(54, 162, 235)",
                        BackgroundColor = "rgb(54, 162, 235)"
                    }
                }
            };
            return View(model);
        }

        public IActionResult StackedLineChart()
        {
            var model = new ChartJsStackedLineChartResponseModel
            {
                Labels = new List<string> { "January", "February", "March", "April", "May", "June", "July" },
                Datasets = new List<ChartJsStackedLineChartModel>
                {
                    new ChartJsStackedLineChartModel
                    {
                        Label = "Dataset 1",
                        Data = new List<int> { 10, 20, 15, 25, 30, 22, 18 },
                        BorderColor = "#FF5733",
                        BackgroundColor = "#FF5733",
                        Fill = true
                    },
                    new ChartJsStackedLineChartModel
                    {
                        Label = "Dataset 2",
                        Data = new List<int> { 15, 25, 18, 35, 28, 20, 15 },
                        BorderColor = "#3385FF",
                        BackgroundColor = "#3385FF",
                        Fill = true
                    }
                }
            };

            return View(model);
        }

        public IActionResult TimeScalChart()
        {
            List<string> date = new List<string> {"2023-02-01T20:30:00.000Z",
                                                  "2023-02-02T16:30:00.000Z",
                                                  "2023-02-03T16:30:00.000Z",
                                                  "2023-02-04T16:30:00.000Z",
                                                  "2023-02-05T16:30:00.000Z",
                                                  "2023-02-06T16:30:00.000Z",
                                                  "2023-02-07T16:30:00.000Z"};
            double[][] number = new double[][]{ new double[] { 3, 4, 2, 1, 8, 5, 5},
                                                  new double[] { 6, 9, 3, 4, 1, 2, 3},
                                                  new double[] { 8, 3, 7, 6, 4, 4, 6} };
            ChartJsTimeScaleModel chartJs=new ChartJsTimeScaleModel()
            {
                labels=date,
                number=number,
            };
            ChartJsTimeScaleResponseModel model = new ChartJsTimeScaleResponseModel()
            {
                Data=chartJs
            };

            model.Data = chartJs;
            
            return View(model);
        }

        public IActionResult Scatter()
        {
            ChartJsScatterChartResponseModel model = new ChartJsScatterChartResponseModel
            {
                Label = "Scatter Dataset",
                Data = new List<ChartJsScatterChartModel>
                {
                    new ChartJsScatterChartModel {x=-10, y= 2},
                    new ChartJsScatterChartModel {x=-8, y= 9},
                    new ChartJsScatterChartModel {x=-10, y= 5},
                    new ChartJsScatterChartModel {x=-6, y= 4},
                    new ChartJsScatterChartModel {x=-4, y= 6},
                    new ChartJsScatterChartModel {x=-5, y= 3},
                    new ChartJsScatterChartModel {x=-3, y= 3},
                    new ChartJsScatterChartModel {x=-8, y= 6},
                    new ChartJsScatterChartModel {x=-7, y= 4},
                },
                backgroundColor = "#166a8f"
            };
            return View(model);
        }

        public IActionResult RadarChart()
        {
            ChartJsRadarChartModel model = new ChartJsRadarChartModel
            {
                Data = new List<int> { 65, 59, 90, 81, 56, 55, 40 },
                Labels = new List<string> { "Eating", "Drinking", "Sleeping", "Designing", "Coding", "Cycling", "Running" },
                SecondDataSet = new List<int> { 28, 48, 40, 19, 96, 27, 100 }
            };
            return View(model);
        }
    }
}
