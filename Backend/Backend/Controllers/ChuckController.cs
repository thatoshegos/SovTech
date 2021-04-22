using Businesslayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [ApiController]
    public class ChuckController : Controller
    {
        private ChuckService _chuckService;
        public ChuckController()
        {
           _chuckService  = new ChuckService();
        }

        [HttpGet]
        [Route("api/chuck/categories")]
        public ActionResult GetCategories()
        {

            _chuckService.RetrieveCategories();

            //if (!String.IsNullOrWhiteSpace(city))
            //{
            //    _chuckService.RetrieveCategories();

            //    if (result.Weather != null)
            //    {
            //        return Ok(result);
            //    }
            //    return NotFound();
            //}
            return Ok();
        }
    }
}
