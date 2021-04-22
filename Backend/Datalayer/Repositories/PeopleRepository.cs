using Datalayer.Interfaces;
using Datalayer.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Datalayer.Repositories
{
   public class PeopleRepository : IPeopleRepository
    {
        public ExpandoObject GetPeople()
        {
            try
            {
                var client = new RestClient($"http://swapi.dev/api/people/");
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    var content = JsonConvert.DeserializeObject<ExpandoObject>(response.Content);
                    return content;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error - {ex.Message}");
            }
        }

        public ExpandoObject SearchByQuery(string query)
        {
            try
            {
                var client = new RestClient($"http://swapi.dev/api/people/?search={query}");
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    var content = JsonConvert.DeserializeObject<ExpandoObject>(response.Content);
                    return content;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"SearchByQuery - {ex.Message}");
            }
        }
    }
}
