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
    
    public partial class ShopAccount
    {
        public System.Guid Id { get; set; }
        public string ReferenceId { get; set; }
        public string Email { get; set; }
        public string WebsiteId { get; set; }
        public string Fields { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ShopAccountType { get; set; }
        public bool Activated { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> LastVisitDate { get; set; }
    }
}
