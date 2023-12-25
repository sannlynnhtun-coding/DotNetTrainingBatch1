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
            CanvasJsChartBoxAndWhiskerChartResponseModel model = new CanvasJsChartBoxAndWhiskerChartResponseModel
            {
                XAxisTitle = "Daily Sleep Statistics of Age Group 12 - 20",
                XAxisFormatting = "DDDD",
                YAxisTitle = "Sleep Time (in Hours)",
                Data = new List<CanvasJsChartBoxAndWhiskerChartModel>
                {
                    new CanvasJsChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 3), y = new double[]{4, 6, 8, 9, 7}},
                    new CanvasJsChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 4), y = new double[]{5, 6, 7, 8, 6.5}},
                    new CanvasJsChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 5), y = new double[]{4, 5, 7, 8, 6.5}},
                    new CanvasJsChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 6), y = new double[]{3, 5, 6, 9, 5.5}},
                    new CanvasJsChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 7), y = new double[]{6, 8, 10, 11, 8.5}},
                    new CanvasJsChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 8), y = new double[]{5, 7, 9, 12, 7.5}},
                    new CanvasJsChartBoxAndWhiskerChartModel { x = new DateTime(2017, 6, 9), y = new double[]{4, 6, 8, 9, 7}}
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
                Datapoints = new List<CanvasJsSplineAreaChartModel>
                {
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2000,1,1),Y=3289000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2001,1,2),Y=3830000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2002,1,3),Y=2009000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2003,1,4),Y=2840000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2004,1,5),Y=2396000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2005,1,6),Y=1613000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2006,1,7),Y=2821000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2007,1,8),Y=2000000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2008,1,9),Y=1397000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2009,1,10),Y=2506000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2010,1,11),Y=2798000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2011,1,12),Y=3386000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2012,1,1),Y=6704000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2013,1,2),Y=6026000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2014,1,3),Y=2394000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2015,1,4),Y=1872000},
                     new CanvasJsSplineAreaChartModel { X= new DateTime(2016,1,5),Y=2140000}
                }
            };
            return View(model);
        }
        public IActionResult ScatterAndBubbleChart()
        {
            CanvasScatterAndBubbleResponseModel model = new CanvasScatterAndBubbleResponseModel
            {
                Title = "Real Estate Rates",
                XAxisTitle = "Area (in sq. ft)",
                YAxisTitle = "Price (in USD)",
                Data = new List<CanvasScatterAndBubbleModel> {
                    new CanvasScatterAndBubbleModel {X = 800,Y = 350},
                    new CanvasScatterAndBubbleModel {X = 900,Y = 450},
                    new CanvasScatterAndBubbleModel {X = 850,Y = 450},
                    new CanvasScatterAndBubbleModel {X = 1250,Y = 700},
                    new CanvasScatterAndBubbleModel {X = 1100,Y = 650},
					new CanvasScatterAndBubbleModel {X = 1350,Y = 850},
					new CanvasScatterAndBubbleModel {X = 1200,Y = 900},
                    new CanvasScatterAndBubbleModel {X = 1410,Y = 1250},
                    new CanvasScatterAndBubbleModel {X = 1250,Y = 1100},
                    new CanvasScatterAndBubbleModel {X = 1400,Y = 1150},
					new CanvasScatterAndBubbleModel {X = 1580,Y = 1220},
					new CanvasScatterAndBubbleModel {X = 1620,Y = 1400},
					new CanvasScatterAndBubbleModel {X = 1250,Y = 1450},
					new CanvasScatterAndBubbleModel {X = 1350,Y = 1600},
					new CanvasScatterAndBubbleModel {X = 1650,Y = 1300},
                    new CanvasScatterAndBubbleModel {X = 1700,Y = 1620},
                    new CanvasScatterAndBubbleModel {X = 1750,Y = 1700},
                    new CanvasScatterAndBubbleModel {X = 1830,Y = 1800},
                    new CanvasScatterAndBubbleModel {X = 1900,Y = 2000},
                    new CanvasScatterAndBubbleModel {X = 2050,Y = 2200},
                    new CanvasScatterAndBubbleModel {X = 2150,Y = 1960},
                    new CanvasScatterAndBubbleModel {X = 2250,Y = 1990},
                }
            };
            return View(model);
        }

        public IActionResult WaterfallChart()
        {
            // Sample data for Waterfall Chart
            CanvasJsWaterfallChartResponseModel model = new CanvasJsWaterfallChartResponseModel
            {
                Data = new List<CanvasJsWaterfallChartModel>
                {
                    new CanvasJsWaterfallChartModel { Label = "Start", Y = 100 },
                    new CanvasJsWaterfallChartModel { Label = "Addition 1", Y = 50 },
                    new CanvasJsWaterfallChartModel { Label = "Subtraction 1", Y = -30 },
                    new CanvasJsWaterfallChartModel { Label = "Addition 2", Y = 20 },
                    new CanvasJsWaterfallChartModel { Label = "Subtraction 2", Y = -10 },
                    new CanvasJsWaterfallChartModel { Label = "End", Y = 130 },
                }
            };

            return View(model);
        }
    }


}

