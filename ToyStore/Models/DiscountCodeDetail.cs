//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SourceCode.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiscountCodeDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiscountCodeDetail()
        {
            this.UserDiscountCodes = new HashSet<UserDiscountCode>();
        }
    
        public int ID { get; set; }
        public Nullable<int> DiscountCodeID { get; set; }
        public string Code { get; set; }
        public Nullable<bool> IsUsed { get; set; }
        public Nullable<bool> IsOwned { get; set; }
    
        public virtual DiscountCode DiscountCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserDiscountCode> UserDiscountCodes { get; set; }
    }
}