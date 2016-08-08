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
    
    public partial class MeterReading
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MeterReading()
        {
            this.BolusDeliveries = new HashSet<BolusDelivery>();
            this.MeterReadingErrors = new HashSet<MeterReadingError>();
            this.MeterReadingEvents = new HashSet<MeterReadingEvent>();
            this.TotalDailyDeliveries = new HashSet<TotalDailyDelivery>();
        }
    
        public int ReadingId { get; set; }
        public int Sequence { get; set; }
        public string ReadingType { get; set; }
        public int DatetimeKey { get; set; }
        public System.DateTime ReadingDateTime { get; set; }
        public string Units { get; set; }
        public string Value { get; set; }
        public string ReadingNote { get; set; }
        public int DownloadKedyId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BolusDelivery> BolusDeliveries { get; set; }
        public virtual DeviceData DeviceData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MeterReadingError> MeterReadingErrors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MeterReadingEvent> MeterReadingEvents { get; set; }
        public virtual MeterReadingHeader MeterReadingHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TotalDailyDelivery> TotalDailyDeliveries { get; set; }
    }
}
