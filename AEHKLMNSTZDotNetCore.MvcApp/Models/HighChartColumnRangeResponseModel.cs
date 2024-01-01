namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
	public class HighChartColumnRangeResponseModel
	{
		public List<string> categories { get; set; }
		public List<HighChartColumnRangeModel> series { get; set; }
	}
}
