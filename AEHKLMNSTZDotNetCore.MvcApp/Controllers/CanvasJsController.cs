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

        public IActionResult SplineAreaChart()
        {
            CanvasJsSplineAreaChartResponseModel model = new CanvasJsSplineAreaChartResponseModel
            {
                Title = "Company Revenue by Year",
                Ytitle = "Revenue in USD",
                Datapoints =new List<CanvasJsSplineAreaChartModel>
                {
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2000,0,1),Y=3289000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2001,0,2),Y=3830000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2002,0,3),Y=2009000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2003,0,4),Y=2840000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2004,0,5),Y=2396000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2005,0,6),Y=1613000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2006,0,7),Y=2821000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2007,0,8),Y=2000000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2008,0,9),Y=1397000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2009,0,1),Y=2506000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2010,0,2),Y=2798000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2011,0,3),Y=3386000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2012,0,4),Y=6704000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2013,0,5),Y=6026000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2014,0,6),Y=2394000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2015,0,7),Y=1872000},
                    //new CanvasJsSplineAreaChartModel { X= new DateTime(2016,0,8),Y=2140000}
				}
            };
            return View(model);
        }
    }
}

