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
    
    public partial class clinipro_Users
    {
        public System.Guid UserId { get; set; }
        public string CliniProID { get; set; }
        public Nullable<int> CPSiteId { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<bool> MustChangePW { get; set; }
        public bool IsApproved { get; set; }
        public int LoginCount { get; set; }
        public bool IsFreeUser { get; set; }
        public Nullable<bool> MVCEligible { get; set; }
        public string IsNotApprovedReason { get; set; }
    
        public virtual aspnet_Users aspnet_Users { get; set; }
    }
}