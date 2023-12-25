namespace AEHKLMNSTZDotNetCore.MvcApp.Models
{
    public class CanvasJsCandleStickResponseModel
    {
        public string Text { get; set; }
        public CandleStickAxisXModel AxisX { get; set; }
        public CandleStickAxisYModel AxisY { get; set; }
        public List<CanvasJsCandleStickModel> Data { get; set; }
    }
}
