//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuLibrary.Migration.SQLDatabase.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Institution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Institution()
        {
            this.Clinicians = new HashSet<Clinician>();
            this.Patients = new HashSet<Patient>();
        }
    
        public System.Guid InstitutionId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string ContactFirstname { get; set; }
        public string ContactLastname { get; set; }
        public string ContactEmail { get; set; }
        public System.Guid UserId { get; set; }
        public int LegacySiteId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clinician> Clinicians { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
