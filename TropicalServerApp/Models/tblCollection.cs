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
    
    public partial class tblCollection
    {
        public int CollectionID { get; set; }
        public Nullable<System.DateTime> CollectionDate { get; set; }
        public Nullable<decimal> CollectionAmount { get; set; }
        public string CollectionCheckNumber { get; set; }
        public string CollectionCashYesNo { get; set; }
        public Nullable<int> CollectionForCustomerNumber { get; set; }
        public Nullable<int> OrderConfirmFlag { get; set; }
    }
}
