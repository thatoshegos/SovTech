using Datalayer.Interfaces;
using Datalayer.Repositories;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Businesslayer.Services
{
    public class ChuckService
    {
        private readonly IChuckRepository _chuckRepository;
        public ChuckService()
        {
            _chuckRepository = new ChuckRepository();
        }

        public List<string> RetrieveCategories()
        {
            try
            {
                var categories = _chuckRepository.GetCategories();
               
                return categories;
            }
            catch (Exception ex)
            {
                throw new Exception($"RetrieveCategories - {ex.Message}");
            }
        }
        public ExpandoObject GetJokeByCategory(string query)
        {
            try
            {
                dynamic joke = new ExpandoObject();

                joke = _chuckRepository.GetJokeByCategory(query);


                return joke;
            }
            catch (Exception ex)
            {
                throw new Exception($"GetJokeByCategory - {ex.Message}");
            }
        }
    }
}
