using Datalayer.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Datalayer.Repositories
{
    public class ChuckRepository : IChuckRepository
    {
       public List<string> GetCategories()
        {
            try
            {
                var client = new RestClient($"https://api.chucknorris.io/jokes/categories");
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                List<string> categories = new List<string>();

                if (response.IsSuccessful)
                {
                    var content = JsonConvert.DeserializeObject<List<string>>(response.Content);
                   return content;
                }
               return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error - {ex.Message}");
            }
        }

        public ExpandoObject GetJokeByCategory(string query)
        {
            try
            {
                var client = new RestClient($"https://api.chucknorris.io/jokes/random?category={query}");
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
                throw new Exception($"GetJokeByCategoty - {ex.Message}");
            }
        }

        public ExpandoObject SearchByQuery(string query)
        {
            try
            {
                var client = new RestClient($"https://api.chucknorris.io/jokes/search?query={query}");
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
