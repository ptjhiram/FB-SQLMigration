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
    
    public partial class DeviceData
    {
        public int DataSetId { get; set; }
        public string DataSet { get; set; }
    
        public virtual MeterReading MeterReading { get; set; }
        public virtual MeterReadingHeader MeterReadingHeader { get; set; }
    }
}
