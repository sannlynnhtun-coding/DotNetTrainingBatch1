using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class CanvasJsController : Controller
    {
        public IActionResult PieChart()
        {
            return View();
        }

        public IActionResult InvertedFunnelChart()
        {
            var model = new CanvasJsInvertedFunnelChartModel
            {
                DataPoints = new List<DataPoint>
                {
                    new DataPoint {Y = 3500, Label = "Impressions"},
                    new DataPoint {Y = 2130, Label = "Clicked"},
                    new DataPoint {Y = 1950, Label = "Free Downloads"},
                    new DataPoint {Y = 500, Label = "Purchase"},
                    new DataPoint {Y = 300, Label = "Renewal"},

                }
            };
            return View(model);
        }

        public IActionResult BoxAndWhiskerChart()
        {
            CanvasChartBoxAndWhiskerChartResponseModel model = new CanvasChartBoxAndWhiskerChartResponseModel
            {
                XAxisTitle = "Daily Sleep Statistics of Age Group 12 - 20",
                XAxisFormatting = "DDDD",
                YAxisTitle = "Sleep Time (in Hours)",
                Datas = new List<CanvasChartBoxAndWhiskerChartModel>
                {
                    new CanvasChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 3), y = new double[]{4, 6, 8, 9, 7}},
                    new CanvasChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 4), y = new double[]{5, 6, 7, 8, 6.5}},
                    new CanvasChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 5), y = new double[]{4, 5, 7, 8, 6.5}},
                    new CanvasChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 6), y = new double[]{3, 5, 6, 9, 5.5}},
                    new CanvasChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 7), y = new double[]{6, 8, 10, 11, 8.5}},
                    new CanvasChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 8), y = new double[]{5, 7, 9, 12, 7.5}},
                    new CanvasChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 9), y = new double[]{4, 6, 8, 9, 7}}
                }
            };

            return View(model);
        }

        public IActionResult PyramidChart()
        {
            CanvasChartPyramidChartModel model = new CanvasChartPyramidChartModel
            {
                Categories = new List<string> { "Day 1", "Day 2", "Day 3", "Day 4", "Day 5", "Day 6", "Day 7" },
                Data = new List<int> { 300, 50, 100, 300, 50, 100, 20 },

            };
            return View(model);
        }
    }
}

