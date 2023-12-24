namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
	public class CanvasJsSplineAreaChartResponseModel
	{
		public string Title { get; set; }
		public string Ytitle { get; set; }
		public List<CanvasJsSplineAreaChartModel> Datapoints { get; set; }
	}

	public class CanvasJsSplineAreaChartModel
	{
		public DateTime X { get; set; }
		public int Y { get; set; }
	}
}
