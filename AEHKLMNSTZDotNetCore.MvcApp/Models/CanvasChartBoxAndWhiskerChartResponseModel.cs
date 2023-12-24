namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class CanvasChartBoxAndWhiskerChartResponseModel
	{
		public string XAxisTitle { get; set; }

		public string XAxisFormatting { get; set; }

		public string YAxisTitle { get; set;}

		public List<CanvasChartBoxAndWhiskerChartModel> Data {  get; set; }
	}
}
