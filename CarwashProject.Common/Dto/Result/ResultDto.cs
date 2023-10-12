namespace CarwashProject.Common.Dto.Result
{
    public class ResultDto
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public int StatusCode { get; set; }
    }

    public class ResultDto<T> : ResultDto where T : class
    {
        public T Data { get; set; }
    }
}