﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace NuLibrary.Migration.Mappings
{
    public class SqlTableStats
    {
        public SqlTableStats()
        {
        }

        public string Tablename { get; set; }
        public int PreSaveCount { get; set; }
        public int PostSaveCount { get; set; }


        public override string ToString()
        {
            return $"{Tablename} Presave={PreSaveCount} - Postsave={PostSaveCount} Difference={PostSaveCount - PreSaveCount}";
        }
    }
}