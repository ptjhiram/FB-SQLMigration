//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuLibrary.Migration.Test.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class users_Sessions_Test
    {
        public System.Guid UserId { get; set; }
        public string SessionId { get; set; }
        public System.DateTime LastActivity { get; set; }
    
        public virtual aspnet_Users_Test aspnet_Users_Test { get; set; }
    }
}
