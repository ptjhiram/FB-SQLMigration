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
    
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int PaymentMethod { get; set; }
        public bool PaymentApproved { get; set; }
    
        public virtual Check Check { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual PayPal PayPal { get; set; }
    }
}