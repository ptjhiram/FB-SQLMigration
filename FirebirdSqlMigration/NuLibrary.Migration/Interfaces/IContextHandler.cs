﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuLibrary.Migration.Interfaces
{
    public interface IContextHandler
    {
        void AddToContext();
        void SaveChanges();
    }
}