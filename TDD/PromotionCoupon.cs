//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TDD
{
    using System;
    using System.Collections.Generic;
    
    public partial class PromotionCoupon
    {
        public System.Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string WebsiteId { get; set; }
        public string Type { get; set; }
        public bool Enabled { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> MaxUsageCount { get; set; }
        public int UsageCount { get; set; }
        public string Fields { get; set; }
    }
}
