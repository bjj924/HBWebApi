using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HBWebApi.Entities.Models.DTO
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int OrderID { get; set; } = 0;
        public int PersonID { get; set; } = 0;
        public DateTime DateCreated { get; set; } = new DateTime();
        public string MethodofPurchase { get; set; } = string.Empty;
    }
}
