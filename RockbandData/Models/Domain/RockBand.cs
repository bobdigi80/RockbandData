using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockbandData.Models.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class RockBand
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the albums.
        /// </summary>
        /// <value>
        /// The albums.
        /// </value>
        public ICollection<Album> Albums { get; set; }
        /// <summary>
        /// Gets or sets the prizes.
        /// </summary>
        /// <value>
        /// The prizes.
        /// </value>
        public ICollection<Prize> Prizes { get; set; }
    }
}