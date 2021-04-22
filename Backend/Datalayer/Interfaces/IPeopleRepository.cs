using Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Datalayer.Interfaces
{
    public interface IPeopleRepository
    {
        ExpandoObject GetPeople();
        ExpandoObject SearchByQuery(string query);
    }
}
