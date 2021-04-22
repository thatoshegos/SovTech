using Datalayer.Interfaces;
using Datalayer.Models;
using Datalayer.Repositories;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Businesslayer.Services
{
    public class PeopleService
    {
        private readonly IPeopleRepository _peopleRepository;
        public PeopleService()
        {
            _peopleRepository = new PeopleRepository();
        }

        /// <summary>
        /// Retrieves all People.
        /// </summary>
        /// <returns></returns>
        public ExpandoObject RetrievePeople()
        {
            try
            {
               var people = _peopleRepository.GetPeople();

                return people;
            }
            catch (Exception ex)
            {
                throw new Exception($"RetrievePeople - {ex.Message}");
            }
        }


    }
}
