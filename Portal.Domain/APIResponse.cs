namespace Portal.Models
{
    public class APIResponse<T>
    {
        public string? Message { get; set; }
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public T? Data { get; set; }
    }
}
