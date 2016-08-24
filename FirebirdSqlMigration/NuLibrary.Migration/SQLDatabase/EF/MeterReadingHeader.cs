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
    
    public partial class MeterReadingHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MeterReadingHeader()
        {
            this.MeterReadings = new HashSet<MeterReading>();
        }
    
        public int ReadingHeaderId { get; set; }
        public int DownloadKeyId { get; set; }
        public int DeviceId { get; set; }
        public System.DateTime ServerDateTime { get; set; }
        public System.DateTime MeterDateTime { get; set; }
        public int Readings { get; set; }
        public string SiteSource { get; set; }
        public System.DateTime ReviewedOn { get; set; }
        public bool IsCGMData { get; set; }
        public string PatientId { get; set; }
    
        public virtual PatientDevice PatientDevice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MeterReading> MeterReadings { get; set; }
        public virtual Pump Pump { get; set; }
    }
}