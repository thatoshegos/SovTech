using Datalayer.Interfaces;
using Datalayer.Repositories;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Businesslayer.Services
{
    public class SearchService
    {
        private readonly IPeopleRepository _peopleRepository;
        private readonly IChuckRepository _chuckRepository;

        public SearchService()
        {
            _peopleRepository = new PeopleRepository();
            _chuckRepository = new ChuckRepository();
        }

        /// <summary>
        ///  Search both Chuck and People using a phrase.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public ExpandoObject SearchByPhrase(string query)
        {
            try
            {
                dynamic result = new ExpandoObject();

                result = _chuckRepository.SearchByQuery(query);

                if (result.total == 0)
                {
                    result = _peopleRepository.SearchByQuery(query);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"SearchByPhrase - {ex.Message}");
            }
        }
    }
}
