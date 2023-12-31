namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
	public class ChartJsMultiAxisLineChartModel
	{
		public string label { get; set; }
		public List<int> data { get; set; }
		public string borderColor { get; set; }
		public string backgroundColor { get; set; }
		public string yAxisID { get; set; }
	}
}
