namespace HBWebApi.Entities.Models
{
    public class CharArrayResponse
    {
        public string Result { get; set; } = string.Empty;
        public int StatusCode { get; set; } = 0;
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
