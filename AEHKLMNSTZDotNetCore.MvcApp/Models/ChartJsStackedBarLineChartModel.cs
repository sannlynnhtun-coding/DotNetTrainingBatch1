namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class ChartJsStackedBarLineChartModel
    {
        public int DataCount { get; set; }

        public List<string> Labels { get; set; }

        public List<DataSetModel> DataSets { get; set; }

        public string BorderColor { get; set; }

        public string BackgroundColor { get; set; }

    }

    public class DataSetModel
    {
        public List<int> Datas { get; set; }

        public string Label { get; set; }

        public string BorderColor { get; set; }

        public string BackgroundColor { get; set; }

    }

}
