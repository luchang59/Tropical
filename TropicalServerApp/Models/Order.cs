using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TropicalServerApp.Models
{
    public class Order
    {
        public int? OrderID { get; set; }
        public string OrderTrackingNumber { get; set; }
        public int? OrderRouteNumber { get; set; }
        public int? OrderCustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string OrderGroupNumber { get; set; }
        public int? OrderCaseNumbers { get; set; }
        public int? OrderItemNumber { get; set; }
        public decimal? OrderPromoNumber { get; set; }
        public int? OrderItemQty { get; set; }
        public decimal? ItemUnitPrice { get; set; }
        public decimal? ItemTotalPrice { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string UserID { get; set; }
        public string TabletID { get; set; }
        public DateTime? DataSyncDateTime { get; set; }
        public int? OrderConfirmFlag { get; set; }
        public int? ItemType { get; set; }
        public decimal? PerPoundItemsWeight { get; set; }
    }
}