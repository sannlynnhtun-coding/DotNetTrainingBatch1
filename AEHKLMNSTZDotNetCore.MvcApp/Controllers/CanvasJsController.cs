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

        public IActionResult ParetoChart()
        {
            CanvasJSParetoChartResponseModel model = new CanvasJSParetoChartResponseModel()
            {
                items = new List<CanvasJSParetoChartModel>
                {
                    new CanvasJSParetoChartModel{label="Parking",y=35 },
                    new CanvasJSParetoChartModel{label="Rude Sales Rep.",y=69 },
                    new CanvasJSParetoChartModel{label="Poor Lighting",y=42 },
                    new CanvasJSParetoChartModel{label="Limited Size",y=13 },
                    new CanvasJSParetoChartModel{label="Faded Clothes",y=5 }
                }
            };

            return View(model);
        }

        public IActionResult CandleStick()
        {
            CanvasJsCandleStickResponseModel model = new CanvasJsCandleStickResponseModel();
            model.Text = "Netflix Stock Price in 2016";
            model.AxisX = new CandleStickAxisXModel
            {
                interval = 1,
                valueFormatString = "MMM",
            };
            model.AxisY = new CandleStickAxisYModel
            {
                prefix = "$",
                title = "Price",
            };
            model.Data = new List<CanvasJsCandleStickModel>
                {
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-01-04"),
                        y = new List<double>{ 109, 122.18, 104.959999, 111.389999}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-01-11"),
                        y = new List<double>{ 112.129997, 117.779999, 101.209999, 104.040001}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-01-18"),
                        y = new List<double>{ 109, 122.18, 104.959999, 111.389999}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-01-25"),
                        y = new List<double>{ 80.57, 92.209999, 79.949997, 87.400002}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-01-1"),
                        y = new List<double>{ 89, 94.900002, 87.540001, 89.230003}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-08-1"),
                        y = new List<double>{ 90.75, 97.480003, 86.699997, 94.790001}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-01-25"),
                        y = new List<double>{ 94.809998, 102.220001, 93.339996, 101.580002}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-01-15"),
                        y = new List<double>{ 101, 101.790001, 94.5, 97.660004}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-01-22"),
                        y = new List<double>{ 97.199997, 102.410004, 96.43, 101.120003}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-01-29"),
                        y = new List<double>{ 101.150002, 102.099998, 97.07, 98.360001}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-02-7"),
                        y = new List<double>{ 98.339996, 105.790001, 97.82, 105.699997}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-02-14"),
                        y = new List<double>{105.900002, 106.440002, 102.82, 103.809998}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-02-21"),
                        y = new List<double>{104.040001, 111.849998, 102.209999, 111.510002}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-02-28"),
                        y = new List<double>{109.900002, 110.699997, 93.139999, 95.900002}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-03-4"),
                        y = new List<double>{95.699997, 95.75, 88.209999, 90.029999}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-03-11"),
                        y = new List<double>{90.410004, 93.25, 88.110001, 90.839996}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-03-18"),
                        y = new List<double>{90.730003, 93.25, 85.739998, 87.879997}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-03-25"),
                        y = new List<double>{87.559998, 93.279999, 86.150002, 92.489998}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-04-2"),
                        y = new List<double>{92.980003, 104, 92.849998, 103.300003}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-04-9"),
                        y = new List<double>{102.949997, 103.449997, 98.529999, 99.589996}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-04-16"),
                        y = new List<double>{100.290001, 101.629997, 93.279999, 93.75}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-04-23"),
                        y = new List<double>{95.019997, 97.199997, 93.25, 94.449997}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-04-30"),
                        y = new List<double>{95.220001, 95.879997, 87.209999, 88.440002}
                    },
                    new CanvasJsCandleStickModel
                    {
                        x = Convert.ToDateTime("2016-05-6"),
                        y = new List<double>{87.879997, 97, 84.809998, 96.669998}
                    },
                };
            return View(model);
        }

        public IActionResult SplineChart()
        {
            CanvasJsSplineChartResponseModel model = new CanvasJsSplineChartResponseModel
            {
                Title = "Music Album Sales by Year",
                AxisYTitle = "Units Sold",
                DataPoints = new List<CanvasJsSplineChartModel>
                {
                    new CanvasJsSplineChartModel { X = new DateTime(2002, 1, 1), Y = 2506000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2003, 1, 1), Y = 2798000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2004, 1, 1), Y = 3386000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2005, 1, 1), Y = 6944000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2006, 1, 1), Y = 6026000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2007, 1, 1), Y = 2394000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2008, 1, 1), Y = 1872000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2009, 1, 1), Y = 2140000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2010, 1, 1), Y = 7289000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2011, 1, 1), Y = 4830000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2012, 1, 1), Y = 2009000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2013, 1, 1), Y = 2840000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2014, 1, 1), Y = 2396000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2015, 1, 1), Y = 1613000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2016, 1, 1), Y = 2821000 },
                    new CanvasJsSplineChartModel { X = new DateTime(2017, 1, 1), Y = 2000000 }
                }
            };
            return View(model);
        }

		public IActionResult SimpleLineChart()
		{
			CanvasJsSimpleLineChartResponseModel model = new CanvasJsSimpleLineChartResponseModel
			{
				DataPoints = new List<CanvasJsSimpleLineChartModel>
				{
					new CanvasJsSimpleLineChartModel { Y = 450 },
					new CanvasJsSimpleLineChartModel { Y = 414 },
					new CanvasJsSimpleLineChartModel { Y = 520, IndexLabel = "\u2191 highest", MarkerColor = "red", MarkerType = "triangle" },
					new CanvasJsSimpleLineChartModel { Y = 460 },
					new CanvasJsSimpleLineChartModel { Y = 450 },
					new CanvasJsSimpleLineChartModel { Y = 500 },
					new CanvasJsSimpleLineChartModel { Y = 480 },
					new CanvasJsSimpleLineChartModel { Y = 480 },
					new CanvasJsSimpleLineChartModel { Y = 410, IndexLabel = "\u2193 lowest", MarkerColor = "DarkSlateGrey", MarkerType = "cross" },
					new CanvasJsSimpleLineChartModel { Y = 500 },
					new CanvasJsSimpleLineChartModel { Y = 480 },
					new CanvasJsSimpleLineChartModel { Y = 510 }
				},
				ChartTitle = "Simple Line Chart",
				XAxisTitle = "X Axis Label",
				YAxisTitle = "Y Axis Label"
			};
			return View(model);
		}

		public IActionResult AreaChart()
		{
			List<CanvasJsChartAreaChartModel> areaChartList = new List<CanvasJsChartAreaChartModel>()
			{
				new CanvasJsChartAreaChartModel(){Date=new DateTime(2023,12,25),EmailRecieved=30,EmailSent=20},
				new CanvasJsChartAreaChartModel(){Date=new DateTime(2023,12,26),EmailRecieved=50,EmailSent=30},
				new CanvasJsChartAreaChartModel(){Date=new DateTime(2023,12,27),EmailRecieved=20,EmailSent=25},
				new CanvasJsChartAreaChartModel(){Date=new DateTime(2023,12,28),EmailRecieved=15,EmailSent=5},
				new CanvasJsChartAreaChartModel(){Date=new DateTime(2023,12,29),EmailRecieved=70,EmailSent=44},
				new CanvasJsChartAreaChartModel(){Date=new DateTime(2023,12,30),EmailRecieved=18,EmailSent=120},
				new CanvasJsChartAreaChartModel(){Date=new DateTime(2023,12,31),EmailRecieved=150,EmailSent=100},

			};

			CanvasJsChartAreaChartResponseModel model = new CanvasJsChartAreaChartResponseModel()
			{
				MinimumDate = new DateTime(2023, 12, 25),
				MaximumDate = new DateTime(2023, 12, 31),
				Data = areaChartList
			};
			return View(model);
		}

        public IActionResult ErrorLineChart()
        {
            CanvasJsErrorLineChartResponseModel model = new CanvasJsErrorLineChartResponseModel
            {
                predictedData = new List<CanvasJsErrorLineChartForPredictedModel>
                {
                    new CanvasJsErrorLineChartForPredictedModel { y= 3.69, label= "Jan" },
                    new CanvasJsErrorLineChartForPredictedModel { y= 3.69, label= "Jan" },
                    new CanvasJsErrorLineChartForPredictedModel { y= 4.08, label= "Mar" },
                    new CanvasJsErrorLineChartForPredictedModel { y= 4.06, label="Apr" },
                    new CanvasJsErrorLineChartForPredictedModel { y= 4.48, label="May" },
                    new CanvasJsErrorLineChartForPredictedModel { y= 3.45, label= "Jun" },
                    new CanvasJsErrorLineChartForPredictedModel { y= 4.17, label= "Jul" },
                    new CanvasJsErrorLineChartForPredictedModel { y= 4.05, label= "Aug" },
                    new CanvasJsErrorLineChartForPredictedModel { y= 4.05, label= "Sep" },
                    new CanvasJsErrorLineChartForPredictedModel { y= 3.5, label= "Oct" },
                    new CanvasJsErrorLineChartForPredictedModel { y=4.0, label="Nov" },
                    new CanvasJsErrorLineChartForPredictedModel { y= 3.86, label="Dec" }
                },

                errors = new List<CanvasJsErrorLineChartForErrorModel>
                {
                    new CanvasJsErrorLineChartForErrorModel{y=new List<double>{3.6, 3.8 },label="Jan"},
                    new CanvasJsErrorLineChartForErrorModel{y=new List<double>{3.0, 3.4},label="Feb" },
                    new CanvasJsErrorLineChartForErrorModel{y=new List<double>{3.8, 4.3},label="Mar" },
                    new CanvasJsErrorLineChartForErrorModel{y=new List<double>{3.9, 4.2},label="Apr" },
                    new CanvasJsErrorLineChartForErrorModel{y=new List<double>{4.3, 4.6},label="May" },
                    new CanvasJsErrorLineChartForErrorModel{y=new List<double>{3.3, 3.6},label="Jun" },
                    new CanvasJsErrorLineChartForErrorModel{y=new List<double>{4.0, 4.4},label="Jul" },
                    new CanvasJsErrorLineChartForErrorModel{y=new List<double>{3.9, 4.3},label="Aug" },
                    new CanvasJsErrorLineChartForErrorModel{y=new List<double>{3.8, 4.2},label="Sep" },
                    new CanvasJsErrorLineChartForErrorModel{y=new List<double>{3.4, 3.7},label="Oct" },
                    new CanvasJsErrorLineChartForErrorModel{y=new List<double>{3.8, 4.2},label="Nov" },
                    new CanvasJsErrorLineChartForErrorModel{y=new List<double>{3.7, 4.0},label="Dec" }
                }
            };
            return View(model);
        }
		public IActionResult DoughnutChart()
        {
            CanvasJsDoughnutChartResponseModel model = new CanvasJsDoughnutChartResponseModel()
            {
                DataPoints = new List<CanvasJsDoughnutChartModel>
                {
                    new CanvasJsDoughnutChartModel {x = 67, lable = "Inbox"},
                    new CanvasJsDoughnutChartModel {x = 28, lable = "Archives"},
                    new CanvasJsDoughnutChartModel {x = 10, lable = "Labels"},
                    new CanvasJsDoughnutChartModel {x = 7, lable = "Drafts"},
                    new CanvasJsDoughnutChartModel {x = 15, lable = "Trash"},
                    new CanvasJsDoughnutChartModel {x = 6, lable = "Spam"},
                }
            };
            return View(model);
        }

		public IActionResult LineChartWithAxis()
		{
			CanvasJsLineChartWithAxisResponseModel model = new CanvasJsLineChartWithAxisResponseModel
			{
				//Type = "line",
				//      XValueFormatString = "DD MMM",
				//      Color = "#F08080",
				DataPoints = new List<CanvasJsLineChartWithAxisModel>
				{
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 1) ,y = 610 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 2) ,y = 680 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 3) ,y = 690 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 4) ,y = 700 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 5) ,y = 710 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 6) ,y = 658 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 7) ,y = 734 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 8) ,y = 963 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 9) ,y = 1850 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 10) ,y = 1905 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 11) ,y = 1858 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 12) ,y = 1034 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 13) ,y = 847 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 14) ,y = 853 },
					new CanvasJsLineChartWithAxisModel {x = new DateTime(2017, 1, 15) ,y = 750 }
				}
			};
			return View(model);
		}

		public IActionResult ErrorBarChart()
		{
			CanvasJsErrorBarChartResponseModel model = new CanvasJsErrorBarChartResponseModel
			{
				Datapoints1 = new List<CanvasJsErrorBarChartModel>
				{
					new CanvasJsErrorBarChartModel { y = 94, label = "Order Accuracy" },
					new CanvasJsErrorBarChartModel { y = 74, label = "Packaging" },
					new CanvasJsErrorBarChartModel { y = 80, label = "Quantity" },
					new CanvasJsErrorBarChartModel { y = 88, label = "Quality" },
					new CanvasJsErrorBarChartModel { y = 76, label = "Delivery" }
				},
				Datapoints2 = new List<CanvasJsErrorBarChartModel>
				{
					new CanvasJsErrorBarChartModel { y2 = new List<int> {92, 98}, label2 = "Order Accuracy" },
					new CanvasJsErrorBarChartModel { y2 = new List<int> {70, 78}, label2 = "Packaging" },
					new CanvasJsErrorBarChartModel { y2 = new List<int> {78, 75}, label2 = "Quantity" },
					new CanvasJsErrorBarChartModel { y2 = new List<int> {85, 92}, label2 = "Quality" },
					new CanvasJsErrorBarChartModel { y2 = new List<int> {72, 78}, label2 = "Delivery" }
				}
			};
			return View(model);
		}

        public IActionResult DynamicLineChart()
        {
            return View();
        }

	}
}

	


