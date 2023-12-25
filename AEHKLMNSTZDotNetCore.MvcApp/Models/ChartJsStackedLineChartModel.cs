namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class ChartJsStackedLineChartModel
    {
        public string Label { get; set; }
        public List<int> Data { get; set; }
        public string BorderColor { get; set; }
        public string BackgroundColor { get; set; }
        public bool Fill { get; set; }
    }
}