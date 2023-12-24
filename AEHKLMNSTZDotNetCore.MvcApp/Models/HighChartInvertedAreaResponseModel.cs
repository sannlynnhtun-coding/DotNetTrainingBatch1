namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class HighChartInvertedAreaResponseModel
    {
        public string Title { get; set; }
        public string Ytitle { get; set; }
        public int Startpoint { get; set; }
        public List<HighChartInvertedAreaModel> Series { get; set; }
    }

    public class HighChartInvertedAreaModel
    {
        public string Name { get; set; }
        public List<double> Data { get; set; }
    }

}
