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
    
    public partial class PumpCorrectionFactor
    {
        public int FactorId { get; set; }
        public int CorrectionFactorValue { get; set; }
        public System.TimeSpan CorrectionFactorStart { get; set; }
        public System.TimeSpan CorrectionFactorStop { get; set; }
        public int PumpId { get; set; }
    
        public virtual Pump Pump { get; set; }
    }
}
