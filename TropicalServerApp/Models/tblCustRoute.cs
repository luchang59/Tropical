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
    
    public partial class tblCustRoute
    {
        public int CustRouteNumberID { get; set; }
        public Nullable<int> CustRouteNumber { get; set; }
        public string CustRouteNumberDescription { get; set; }
        public Nullable<int> CustRouteUserAssignID { get; set; }
        public Nullable<System.DateTime> CustRouteAssignFrom { get; set; }
        public Nullable<System.DateTime> CustRouteAssignTo { get; set; }
        public string CustRouteRep { get; set; }
    }
}