namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class CanvasJsBubbleChartResponseModel
    {
        public string Title { get; set; }
        public string XAxisTitle { get; set; }
        public string YAxisTitle { get; set; }
        public List<CanvasJsBubbleChartModel> Data { get; set; }
    }
}
