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
    }
}
