namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class ApexChartBubbleChartModel
    {
        public List<BubbleChartDataItem> Data { get; set; }
    }

    public class BubbleChartDataItem
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public string? Label { get; set; }
    }
}
