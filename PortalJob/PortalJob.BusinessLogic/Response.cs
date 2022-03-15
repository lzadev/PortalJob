namespace PortalJob.BusinessLogic
{
    public class Response<T>
    {
        public bool Success { get; set; }
        public T Items { get; set; }
        public int Total { get; set; }
        public string? Message { get; set; }
        public string? ErrorMessage { get; set; }
        public List<string>? ErrorsDetails { get; set; }

        public static Response<T> Ok(T items, int total, string? message = null)
        {
            return new Response<T>
            {
                Success = true,
                Items = items,
                Total = total,
                Message = message,
                ErrorMessage = null,
                ErrorsDetails = null,
            };
        }

        public static Response<T> Fail(string errorMessage, List<string> errorsDetails)
        {
            return new Response<T>
            {
                Success = false,
                Message = null,
                Total = default,
                ErrorMessage = errorMessage,
                ErrorsDetails = errorsDetails,
            };
        }
    }
}
