namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class HighChartLineChartResponseModel
    {
        public string Title { get; set; }

        public string YAxisTitle { get; set; }

        public string RangeDescription { get; set; }

        public int PointStart { get; set; }

        public List<HighChartLineChartModel> Datas{ get; set; }

     }

}
