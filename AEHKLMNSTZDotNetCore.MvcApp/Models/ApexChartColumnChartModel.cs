namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class ApexChartColumnChartModel
    {
        public List<ColumnChartSeriesModel> Series { get; set; }
        public List<string> XAxisCategories { get; set; }
        public List<int> YAxisCategories { get; set; }
    }

    public class ColumnChartSeriesModel
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public List<int> Data { get; set; }
    }
}
