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
    
    public partial class DailyTimeSlot
    {
        public int TimeSlotId { get; set; }
        public string TimeSlotDescription { get; set; }
        public System.TimeSpan TImeSlotBoundary { get; set; }
        public int CareSettingsId { get; set; }
    
        public virtual CareSetting CareSetting { get; set; }
    }
}
