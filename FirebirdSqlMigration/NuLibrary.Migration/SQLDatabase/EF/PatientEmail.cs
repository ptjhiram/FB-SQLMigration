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
    
    public partial class PatientEmail
    {
        public int EmailId { get; set; }
        public string Email { get; set; }
        public string LoweredEmail { get; set; }
        public string PatientId { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
