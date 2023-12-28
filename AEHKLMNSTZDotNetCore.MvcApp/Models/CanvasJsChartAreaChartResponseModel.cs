namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class CanvasJsChartAreaChartResponseModel
    {
        public DateTime MinimumDate { get; set; }
        public DateTime MaximumDate { get; set; }
        public List<CanvasJsChartAreaChartModel> Data { get; set; }
    }
}
