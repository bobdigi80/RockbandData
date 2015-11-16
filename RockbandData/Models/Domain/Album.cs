using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockbandData.Models.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Album
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public int Year { get; set; }
    }
}