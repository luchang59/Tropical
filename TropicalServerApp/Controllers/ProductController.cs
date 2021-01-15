using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TropicalServer.BLL;
using TropicalServerApp.Models;
using TropicalServerApp.ViewModel;

namespace TropicalServerApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Product()
        {
            /*DataSet a = new ReportsBLL().GetItemTypeID_BLL();
            Console.WriteLine("The SqlConnection is open.");
            ViewData["sample"] = a.Tables[0].Rows[0].ToString();
            Console.WriteLine(a.Tables);
            foreach (DataTable table in a.Tables){
                Console.WriteLine(table);
            }
            Console.WriteLine("The SqlConnection is closed.");*/
            return View();
        }

        public ActionResult Orders()
        {
            OrderViewModel obj = new OrderViewModel();
            obj.order = new Order();
            DataSet data = new ReportsBLL().GetAllOrders_BLL();
            var rows = data.Tables[0].AsEnumerable()
                .Select(dataRow => new Order
                {   
                    OrderID = dataRow.Field<int?>("OrderID"),
                    OrderTrackingNumber = dataRow.Field<string>("OrderTrackingNumber"),
                    OrderDate = dataRow.Field<DateTime?>("OrderDate"),
                    OrderCustomerNumber = dataRow.Field<int?>("OrderCustomerNumber"),
                    CustomerName = dataRow.Field<string>("CustName"),
                    CustomerAddress = dataRow.Field<string>("CustOfficeAddress1"),
                    OrderRouteNumber = dataRow.Field<int?>("OrderRouteNumber"),
                    OrderGroupNumber = dataRow.Field<string>("OrderGroupNumber"),
                    OrderCaseNumbers = dataRow.Field<int?>("OrderCaseNumbers"),
                    OrderItemNumber = dataRow.Field<int?>("OrderItemNumber"),
                    OrderPromoNumber = dataRow.Field<decimal?>("OrderPromoNumber"),
                    OrderItemQty = dataRow.Field<int?>("OrderItemQty"),
                    ItemUnitPrice = dataRow.Field<decimal?>("ItemUnitPrice"),
                    ItemTotalPrice = dataRow.Field<decimal?>("ItemTotalPrice"),
                    DeliveryDate = dataRow.Field<DateTime?>("DeliveryDate"),
                    UserID = dataRow.Field<string>("UserID"),
                    TabletID = dataRow.Field<string>("TabletID"),
                    DataSyncDateTime = dataRow.Field<DateTime?>("DataSyncDateTime"),
                    OrderConfirmFlag = dataRow.Field<int?>("OrderConfirmFlag"),
                    ItemType = dataRow.Field<int?>("ItemType"),
                    PerPoundItemsWeight = dataRow.Field<decimal?>("PerPoundItemsWeight"),
                }).ToList();
            obj.orders = rows;
            ViewData["test"] = obj.orders.Count;
            return View(obj);
        }

        public ActionResult Detail(Order order)
        {
            return View(order);
        }
    }
}