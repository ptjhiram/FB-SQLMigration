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
    
    public partial class PatientPhoneNumber
    {
        public int PhoneId { get; set; }
        public string Number { get; set; }
        public string Extension { get; set; }
        public int Type { get; set; }
        public bool IsPrimary { get; set; }
        public bool RecieveText { get; set; }
        public string PatientId { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
