namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class HighChartStackedBarResponseModel
    {
        public string Title { get; set; }
        public List<string> Categories { get; set; }
        public string Ytitle { get; set; }
        public List<HighChartStackedBarModel> Series { get; set; }
    }

    public class HighChartStackedBarModel
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
    }
}
