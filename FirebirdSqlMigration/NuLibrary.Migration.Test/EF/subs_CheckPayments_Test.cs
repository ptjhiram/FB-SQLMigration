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
    
    public partial class subs_CheckPayments_Test
    {
        public long CheckPaymentId { get; set; }
        public string Status { get; set; }
        public string SubscriptionTimeType { get; set; }
        public int SubscriptionTimeAmount { get; set; }
        public byte MonthsPurchased { get; set; }
        public decimal Amount { get; set; }
        public string CheckNumber { get; set; }
        public Nullable<long> Code { get; set; }
        public System.Guid UserId { get; set; }
        public System.DateTime Date { get; set; }
        public bool SubscriptionTimeApplied { get; set; }
        public System.Guid AddedBy { get; set; }
    
        public virtual aspnet_Users_Test aspnet_Users_Test { get; set; }
    }
}
