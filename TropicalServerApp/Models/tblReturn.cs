//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TropicalServerApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblReturn
    {
        public int ReturnID { get; set; }
        public string ReturnGroupNumber { get; set; }
        public Nullable<int> ReturnCaseNumbers { get; set; }
        public Nullable<int> ReturnItemNumber { get; set; }
        public Nullable<int> ReturnPromoNumber { get; set; }
        public Nullable<decimal> ReturnItemWeight { get; set; }
        public Nullable<int> ReturnItemUnits { get; set; }
        public Nullable<decimal> ItemUnitPrice { get; set; }
        public Nullable<int> CustomerNumber { get; set; }
        public Nullable<decimal> ItemTotalPrice { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public string UserID { get; set; }
        public string TabletID { get; set; }
        public Nullable<System.DateTime> DataSyncDateTime { get; set; }
        public Nullable<int> OrderConfirmFlag { get; set; }
        public Nullable<int> ItemType { get; set; }
    }
}
