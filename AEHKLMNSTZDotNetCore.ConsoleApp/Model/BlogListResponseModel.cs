namespace AEHKLMNSTZDotNetCore.ConsoleApp.Model
{

    public class BlogListResponseModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<BlogDataModel> Data { get; set; }
    }
}
