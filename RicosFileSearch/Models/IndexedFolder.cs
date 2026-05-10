using iText.StyledXmlParser.Jsoup.Select;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicosFileSearch.Models
{
    public class IndexedFolder : BaseEntity,ISearchable
    {
        required public string IndexedFolderPath { get; set;}
        required public string IndexedFolderName { get; set; }
        public DateTime LastTimeScanned { get; set; }
        public bool Active { get; set; }
        public bool IsRootDrive { get; set; }
        public List<string>? IgnoredSubfolders { get; set; }

        public bool MatchesQuery(string query)
        {
            return IndexedFolderName.Contains(query, StringComparison.OrdinalIgnoreCase);
        }
    }
}
