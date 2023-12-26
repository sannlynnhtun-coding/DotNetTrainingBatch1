using System.Collections.Generic;

namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
	public class CanvasJsSimpleLineChartResponseModel
	{
		public List<CanvasJsSimpleLineChartModel> DataPoints { get; set; }
		public string ChartTitle { get; set; }
		public string XAxisTitle { get; set; }
		public string YAxisTitle { get; set; }
	}
}
