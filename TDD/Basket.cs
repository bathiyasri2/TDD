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
    
    public partial class Basket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Basket()
        {
            this.BasketLines = new HashSet<BasketLine>();
        }
    
        public System.Guid Id { get; set; }
        public string WebsiteId { get; set; }
        public string Type { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Fields { get; set; }
        public string UserKey { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasketLine> BasketLines { get; set; }
    }
}
