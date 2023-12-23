using System.Drawing;

namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class ChartJsScatterMultiAxisChartModel
    {
        public string Label { get; set; }
        public List<Point> Data { get; set; }
        public string BorderColor { get; set; }
        public string BackgroundColor { get; set; }
        public string YAxisID { get; set; }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class ChartJsScatterMultiAxisChartResponseModel
    {
        public List<ChartJsScatterMultiAxisChartModel> Datasets { get; set; }
    }
}
