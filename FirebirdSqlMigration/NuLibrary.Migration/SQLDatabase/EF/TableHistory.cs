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
    
    public partial class TableHistory
    {
        public int TableMigrationId { get; set; }
        public string TableName { get; set; }
        public long FirebirdRecordCount { get; set; }
        public long MigratedRecordCount { get; set; }
        public System.DateTime LastMigrationDate { get; set; }
        public System.DateTime PreviousMigrationDate { get; set; }
        public int MigrationId { get; set; }
    
        public virtual DatabaseHistory DatabaseHistory { get; set; }
    }
}
