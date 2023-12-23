using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using AEHKLMNSTZDotNetCore.MvcApp.Models;
using System.Reflection.Emit;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class ChartJsController : Controller
    {
        public IActionResult PieChart()
        {
            return View();
        }

        public IActionResult HorizontalBarChart()
        {
            return View();
        }

        public IActionResult StackedBarLineChart()
        {
            ChartJsStackedBarLineChartModel model = new ChartJsStackedBarLineChartModel
            { 
                DataCount = 7,
                Labels = new List<string> { "June", "July", "August", "September", "October", "November", "December" },
                DataSets = new List<DataSetModel>
                {
                    new DataSetModel
                    {
                        Datas = Enumerable.Range(1, 7).Select(x => GenerateData (1, 100)).ToList(),
                        Label = "Dataset 1",
                        BorderColor = "rgb(255, 99, 132)",
                        BackgroundColor = "rgb(255, 99, 132)"

                    },
                     new DataSetModel
                    {
                        Datas = Enumerable.Range(1, 7).Select(x => GenerateData (1, 100)).ToList(),
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

		private int GenerateData(int from,  int to)
        {
            Random random = new Random();
            return random.Next(from,to);
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
    }
}
