using Businesslayer.Services;
using Microsoft.AspNetCore.Mvc;
using System;


namespace BackendAPI.Controllers
{
    [ApiController]
    public class OpenAPIController : Controller
    {
        private readonly ChuckService _chuckService;
        private readonly PeopleService _peopleService;
        private readonly SearchService _searchService;

        public OpenAPIController()
        {
            _chuckService = new ChuckService();
            _peopleService = new PeopleService();
            _searchService = new SearchService();
        }

        /// <summary>
        /// Retrieves all joke categories
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/chuck/categories")]
        public ActionResult GetCategories()
        {
            var result = _chuckService.RetrieveCategories();

            if (result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        /// <summary>
        /// Get a joke by category
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/random/category")]
        
        public ActionResult JokeByCategory([FromQuery] string query)
        {
            if (String.IsNullOrEmpty(query))
            {
                return BadRequest("search.query: No Joke available ");
            }

            var result = _chuckService.GetJokeByCategory(query);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        /// <summary>
        /// Retrieves all people
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/swapi/people")]
        public ActionResult GetPeople()
        {
           var result =  _peopleService.RetrievePeople();

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        /// <summary>
        /// Search by phrase
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/search")]
        public ActionResult Search([FromQuery] string query)
        {
            if (String.IsNullOrEmpty(query))
            {
                return BadRequest("search.query: size must be between 3 and 120 ");
            }
            
            var result = _searchService.SearchByPhrase(query);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
