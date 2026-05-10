using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicosFileSearch.Models
{
    public interface ISearchable
    {
        bool MatchesQuery(string query);
    }
}
