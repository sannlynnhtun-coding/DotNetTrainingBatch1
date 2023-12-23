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
