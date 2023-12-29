namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class HighChartsPieWithLegendModel
    {
        public string Name { get; set; }
        public double Y { get; set; }
        public bool Sliced { get; set; }
        public bool Selected { get; set; }
    }
    public class HighChartsPieWithLegendDataModel
    {
        public string ChartTitle { get; set; }
        public List<HighChartsPieWithLegendModel> ChartData { get; set; }
    }
}
