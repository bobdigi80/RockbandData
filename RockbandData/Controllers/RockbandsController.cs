using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using RockbandData.Models.Domain;
using RockbandData.Repository;

namespace RockbandData.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [EnableCors("http://localhost:57231", "*", "GET")]
    [Authorize]
    public class RockbandsController : ApiController
    {
        private IObjectContextFactory _objectContextFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="RockbandsController"/> class.
        /// </summary>
        public RockbandsController()
        {
            _objectContextFactory = new LazySingletonObjectContextFactory();
        }

        // GET: Rockbands
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RockBand> Get()
        {
            return _objectContextFactory.Create().GetAll();
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public IHttpActionResult Get(int id)
        {
            RockBand rockband = _objectContextFactory.Create().GetById(id);
            if (rockband == null)
            {
                return NotFound();
            }
            return Ok<RockBand>(rockband);
        }

        /// <summary>
        /// Gets the albums.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [Route("api/rockbands/{id:int:min(1)}/albums")]
        public IHttpActionResult GetAlbums(int id)
        {
            RockBand rockband = _objectContextFactory.Create().GetById(id);
            if (rockband == null)
            {
                return NotFound();
            }
            return Ok<IEnumerable<Album>>(rockband.Albums);
        }
    }
}
