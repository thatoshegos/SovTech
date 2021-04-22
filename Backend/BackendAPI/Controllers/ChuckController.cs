using Businesslayer.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Controllers
{
    [ApiController]
    public class ChuckController : Controller
    {
        private ChuckService _chuckService;
        public ChuckController()
        {
            _chuckService = new ChuckService();
        }


        /// <summary>
        /// Retrieves all joke categories
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/[controller]/categories")]
        public ActionResult GetCategories()
        {
            var result = _chuckService.RetrieveCategories();

            if (result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }       
    }
}
