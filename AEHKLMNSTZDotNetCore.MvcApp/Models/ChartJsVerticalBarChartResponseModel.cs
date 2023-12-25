namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class ChartJsVerticalBarChartResponseModel
    {
        public int DataCount { get; set; }

        public List<string> Labels { get; set; }

        public List<ChartJsVerticalBarChartModel> Charts { get; set; }
    }
}
