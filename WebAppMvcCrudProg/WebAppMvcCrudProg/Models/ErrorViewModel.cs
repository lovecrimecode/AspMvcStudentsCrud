namespace WebAppMvcCrudMainProg.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        //comment
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
