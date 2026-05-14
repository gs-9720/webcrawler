namespace Portal.Domain.Models
{
    public class Pagination
    {
        public string SearchValue { get; set; }
        public string SearchBy { get; set; }
        public int CurrentPage { get; set; } 
        public int PageSize { get; set; } 
        public int TotalItems { get; set; }
    }
}
