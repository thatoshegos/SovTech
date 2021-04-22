using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Datalayer.Interfaces
{
    public interface IChuckRepository
    {
        List<string> GetCategories();
        ExpandoObject SearchByQuery(string query);
        ExpandoObject GetJokeByCategory(string query);
    }
}
