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
    
    public partial class insulet_Regions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public insulet_Regions()
        {
            this.insulet_LocationRegions = new HashSet<insulet_LocationRegions>();
            this.insulet_PeopleRegions = new HashSet<insulet_PeopleRegions>();
        }
    
        public long RegionId { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<insulet_LocationRegions> insulet_LocationRegions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<insulet_PeopleRegions> insulet_PeopleRegions { get; set; }
    }
}