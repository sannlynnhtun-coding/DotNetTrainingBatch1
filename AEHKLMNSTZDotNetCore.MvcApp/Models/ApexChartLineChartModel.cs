namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class ApexChartLineChartModel
    {
        public List<LineChartSeriesModel> Series { get; set; }
        public List<string> XAxisCategories { get; set; }
    }

    public class LineChartSeriesModel
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
    }
}