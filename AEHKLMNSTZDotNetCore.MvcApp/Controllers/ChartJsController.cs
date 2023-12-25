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
    }
}
