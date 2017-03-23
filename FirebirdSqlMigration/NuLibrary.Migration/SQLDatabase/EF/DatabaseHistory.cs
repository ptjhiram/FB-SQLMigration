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
    
    public partial class DatabaseHistory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatabaseHistory()
        {
            this.PatientHistories = new HashSet<PatientHistory>();
            this.TableHistories = new HashSet<TableHistory>();
        }
    
        public int MigrationId { get; set; }
        public string InstitutionName { get; set; }
        public int SiteId { get; set; }
        public System.DateTime LastMigrationDate { get; set; }
        public System.DateTime PreviousMigrationDate { get; set; }
        public string FbConnectionStringUsed { get; set; }
        public string MigrationLog { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientHistory> PatientHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableHistory> TableHistories { get; set; }
    }
}
