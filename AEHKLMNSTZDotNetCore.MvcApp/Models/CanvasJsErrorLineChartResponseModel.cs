namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class CanvasJsErrorLineChartResponseModel
    {
        public List<CanvasJsErrorLineChartForPredictedModel> predictedData { get; set; }
        public List<CanvasJsErrorLineChartForErrorModel> errors { get; set; }
    }
}
