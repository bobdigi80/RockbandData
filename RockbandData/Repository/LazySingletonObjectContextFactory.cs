﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockbandData.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class LazySingletonObjectContextFactory : IObjectContextFactory
    {
        public InMemoryDatabaseObjectContext Create()
        {
            return InMemoryDatabaseObjectContext.Instance;
        }
    }
}