namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
	public class CanvasChartBoxAndWhiskerChartResponseModel
	{
		public string XAxisTitle { get; set; }

		public string XAxisFormatting { get; set; }

		public string YAxisTitle { get; set;}

		public List<CanvasChartBoxAndWhiskerChartModel> Datas {  get; set; }
	}

	public class CanvasChartBoxAndWhiskerChartModel
	{
		public DateTime x {  get; set; }

		public double[] y { get; set; }
	}
}
