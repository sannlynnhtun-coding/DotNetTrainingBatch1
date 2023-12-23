using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
