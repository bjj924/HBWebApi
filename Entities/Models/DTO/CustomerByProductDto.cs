namespace HBWebApi.Entities.Models.DTO
{
    public class CustomerByProductDto
    {
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        public int OrderId { get; set; } = 0;
        public string DateCreated { get; set; } = string.Empty;
        public string MethodofPurchase { get; set; } = string.Empty;
        public int ProductNumber { get; set; } = 0;
        public string ProductOrigin { get; set; } = string.Empty;
    }
}
