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
    
    public partial class MiniProfiler
    {
        public int RowId { get; set; }
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> RootTimingId { get; set; }
        public System.DateTime Started { get; set; }
        public decimal DurationMilliseconds { get; set; }
        public string User { get; set; }
        public bool HasUserViewed { get; set; }
        public string MachineName { get; set; }
        public string CustomLinksJson { get; set; }
        public Nullable<int> ClientTimingsRedirectCount { get; set; }
    }
}
