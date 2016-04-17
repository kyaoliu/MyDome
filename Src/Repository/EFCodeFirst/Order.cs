using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.EFCodeFirst
{
    public class Order
    {
        [Key]
        public string OrderList { get; set; }
        public long UserId { get; set; }
        public string ShopName { get; set; }
        public string ShopId { get; set; }
        public long Amount { get; set; }
        public long ActualAmount { get; set; }
        public long PaymentAmount { get; set; }
        public int OrderType { get; set; }
        public int OrderState { get; set; }
        public string Remarks { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
