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
    
    public partial class tblPriceGroup
    {
        public int PriceGroupID { get; set; }
        public Nullable<int> PriceGroupNumber { get; set; }
        public Nullable<int> ItemNumber { get; set; }
        public Nullable<int> RouteNumber { get; set; }
        public Nullable<System.DateTime> BeginDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<decimal> EffectivePrice { get; set; }
    }
}
