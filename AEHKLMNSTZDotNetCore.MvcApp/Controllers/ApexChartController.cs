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

        public IActionResult HeatMapChart()
        {
            ApexChartHeatMapChartResponseModel model = new ApexChartHeatMapChartResponseModel()
            {
                Data=new List<ApexChartHeatMapChartModel>()
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
    }
}
