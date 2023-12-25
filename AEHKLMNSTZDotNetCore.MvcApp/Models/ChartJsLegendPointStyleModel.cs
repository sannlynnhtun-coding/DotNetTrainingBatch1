namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class ChartJsLegendPointStyleModel
    {
        public int DataCount { get; set; }
        public List<string> Labels { get; set; }
        public string Title { get; set; }
        public List<int> Data { get; set; }
        public string BorderColor { get; set; }
        public string BackgroundColor { get; set; }
    }

}
