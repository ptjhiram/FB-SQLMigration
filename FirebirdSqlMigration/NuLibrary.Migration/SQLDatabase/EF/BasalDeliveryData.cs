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
    
    public partial class BasalDeliveryData
    {
        public int DataId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int BasalDeliveryId { get; set; }
    
        public virtual BasalDelivery BasalDelivery { get; set; }
    }
}
