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
    
    public partial class aspnet_Paths_Test
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public aspnet_Paths_Test()
        {
            this.aspnet_PersonalizationPerUser_Test = new HashSet<aspnet_PersonalizationPerUser_Test>();
        }
    
        public System.Guid ApplicationId { get; set; }
        public System.Guid PathId { get; set; }
        public string Path { get; set; }
        public string LoweredPath { get; set; }
    
        public virtual aspnet_Applications_Test aspnet_Applications_Test { get; set; }
        public virtual aspnet_PersonalizationAllUsers_Test aspnet_PersonalizationAllUsers_Test { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_PersonalizationPerUser_Test> aspnet_PersonalizationPerUser_Test { get; set; }
    }
}
