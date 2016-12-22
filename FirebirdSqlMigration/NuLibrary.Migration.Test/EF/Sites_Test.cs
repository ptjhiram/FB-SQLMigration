//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuLibrary.Migration.Test.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sites_Test
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sites_Test()
        {
            this.insulet_Contacts_Test = new HashSet<insulet_Contacts_Test>();
            this.Locations_Test = new HashSet<Locations_Test>();
        }
    
        public System.Guid SiteId { get; set; }
        public System.Guid Parent_Corp { get; set; }
        public string Site_Name { get; set; }
        public Nullable<bool> HasFreeSubs { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
    
        public virtual Corporations_Test Corporations_Test { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<insulet_Contacts_Test> insulet_Contacts_Test { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locations_Test> Locations_Test { get; set; }
    }
}
