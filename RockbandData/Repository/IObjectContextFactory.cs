using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockbandData.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public interface IObjectContextFactory
    {
        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        InMemoryDatabaseObjectContext Create();
    }
}
