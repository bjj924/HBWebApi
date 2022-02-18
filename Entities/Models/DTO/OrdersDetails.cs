using System.ComponentModel.DataAnnotations.Schema;

namespace HBWebApi.Entities.Models.DTO
{
    [Table("OrdersDetails")]
    public class OrdersDetails
    {
        public int OrderDetailID { get; set; } = 0;
        public int OrderID { get; set; } = 0;
        public int ProductNumber { get; set; } = 0;
        public int ProductID { get; set; } = 0;
        public string ProductOrigin { get; set; } = string.Empty;
    }
}
