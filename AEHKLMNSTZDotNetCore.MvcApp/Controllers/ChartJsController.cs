﻿using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
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

        public IActionResult BubbleChart()
        {
            ChartJsBubbleResponseModel model = new ChartJsBubbleResponseModel
            {
                
                DataSets = new List<ChartJsBubbleModel>
                {
                    new ChartJsBubbleModel
                    {
                        Data = new List<Point>
                        {
                            new Point { X = -2, Y = 5 },
                            new Point { X = 81, Y = 16 },
                            new Point { X = -19, Y = 8 },
                            new Point { X = -53, Y = -1 },
                            new Point { X = 67, Y = -56 },
                            new Point { X = 9, Y = 88 },
                            new Point { X = 76, Y = -62 }
                        },
                        Label = "Dataset 1",
                        BorderColor = "rgb(255, 99, 132)",
                        BackgroundColor = "rgb(255, 99, 132)"
                    },
                    new ChartJsBubbleModel
                    {
                        Data = new List<Point>
                        {
                            new Point { X = -5, Y = 30 },
                            new Point { X = -3, Y = 10 },
                            new Point { X = 15, Y = -2 },
                            new Point { X = 45, Y = 5 },
                            new Point { X = 6, Y = -4 },
                            new Point { X = 20, Y = -32 },
                            new Point { X = 60, Y = -40 }
                        },
                        Label = "Dataset 2",
                        BorderColor = "rgb(255, 159, 64)",
                        BackgroundColor = "rgb(255, 159, 64)"
                    }
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

        public IActionResult FloatingBarChart()
        {
            ChartJsFloatingBarChartResponseModel model = new ChartJsFloatingBarChartResponseModel
            {
                DataCount = 7,
                Labels = new List<string> { "January", "February", "March", "April", "May", "June", "July" },
                DataSets = new List<ChartJsFloatingBarChartModel>
            {
                new ChartJsFloatingBarChartModel
                {
                    Data =  Enumerable.Range(1, 7).Select(x => GenerateData (1, 100)).ToList(),
                    Label = "Dataset 1",
                    BorderColor = "rgb(255, 99, 132)",
                    BackgroundColor = "rgba(255, 99, 132, 0.7)"
                },
                new ChartJsFloatingBarChartModel
                {
                    Data = Enumerable.Range(1, 7).Select(x => GenerateData (1, 100)).ToList(),
                    Label = "Dataset 2",
                    BorderColor = "rgb(54, 162, 235)",
                    BackgroundColor = "rgba(54, 162, 235, 0.7)"
                }
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
            ChartJsTimeScaleModel chartJs = new ChartJsTimeScaleModel()
            {
                labels = date,
                number = number,
            };
            ChartJsTimeScaleResponseModel model = new ChartJsTimeScaleResponseModel()
            {
                Data = chartJs
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

        public IActionResult DoughnutChart()
        {
            ChartJsDoughnutChartResponseModel model = new ChartJsDoughnutChartResponseModel()
            {
                DataCount = 5,
                Labels = new List<string>
                {
                    "Red", "Orange", "Yellow", "Green", "Blue"
                },
                DataSet = new List<ChartJsDoughnutChartModel>
                {
                    new ChartJsDoughnutChartModel
                    {
                        Label = "Dataset 1",
                        Data = new List<int> {1, 2, 3, 4, 5},
                         BackgroundColor = new List<string> { "rgb(255, 99, 132)", "rgb(255, 159, 64)", "rgb(255, 205, 86)", "rgb(75, 192, 192)", "rgb(54, 162, 235)" }
                    }
                }
            };
            return View(model);
        }

        public IActionResult PolarAreaChart()
        {
            ChartJsPolarAreaChartModel model = new ChartJsPolarAreaChartModel
            {
                Labels = new List<string> { "Red", "Green", "Yellow", "Grey", "Blue" },
                Label = "My First Dataset",
                Data = new List<int> { 11,16,7,3,14},
                BackgroundColor = new List<string> { "rgb(255, 99, 132)", "rgb(75, 192, 192)", "rgb(255, 205, 86)", "rgb(201, 203, 207)", "rgb(54, 162, 235)" }

            };
            return View(model);
        }

        public IActionResult AreaChart()
        {
            ChartJsAreaChartResponseModel model = new ChartJsAreaChartResponseModel();
            List<ChartJsAreaChartModel> areaChartList = new List<ChartJsAreaChartModel>()
            {
            new ChartJsAreaChartModel() {Month="January",Improve=20,Reduce=0},
            new ChartJsAreaChartModel() { Month = "February", Improve = 60, Reduce = 0 },
            new ChartJsAreaChartModel() { Month = "March", Improve = 0, Reduce = -20 },
            new ChartJsAreaChartModel() { Month = "April", Improve = 40, Reduce = 0 },
            new ChartJsAreaChartModel() { Month = "May", Improve = 0, Reduce = -40 },
            new ChartJsAreaChartModel() { Month = "June", Improve = 0, Reduce = -20 },
            new ChartJsAreaChartModel() { Month = "July", Improve = 30, Reduce = 0 }
        };
            model.Data = areaChartList;

            return View(model);
        }

        public IActionResult SteppedLineChart()
        {
            ChartJsSteppedLineChartModel model = new ChartJsSteppedLineChartModel
            {
                Labels = new List<string> { "Day 1", "Day 2", "Day 3", "Day 4", "Day 5", "Day 6" },
                Label = "Dataset",
                Data = new List<int> { 14, -74, 29,-42,1,67 },
                BorderColor = "red"
            };
            return View(model);
        }

		public IActionResult MultiAxisLineChart()
		{
			ChartJsMultiAxisLineChartResponseModel model = new ChartJsMultiAxisLineChartResponseModel
			{
				DataCount = 7,
				Labels = new List<string> {"January",
							"February",
							"March",
							"April",
							"May",
							"June",
							"July"},
				Datasets = new List<ChartJsMultiAxisLineChartModel>
				{
					new ChartJsMultiAxisLineChartModel
					{
						label = "Dataset1",
						data = Enumerable.Range(1, 7).Select(x => GenerateData (1, 100)).ToList(),
						borderColor = "rgb(255, 99, 132)",
						backgroundColor = "rgb(255, 99, 132)",
						yAxisID = "y"
					},
					new ChartJsMultiAxisLineChartModel
					{
						label = "Dataset2",
						data = Enumerable.Range(1, 7).Select(x => GenerateData (1, 100)).ToList(),
						borderColor = "rgb(0, 191, 255)",
						backgroundColor = "rgb(0, 191, 255)",
						yAxisID = "y1"
					}
				}
			};
			return View(model);
		}
	}
        

    }
