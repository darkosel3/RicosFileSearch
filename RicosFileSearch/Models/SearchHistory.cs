using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicosFileSearch.Models
{
    public class SearchHistory : BaseEntity
    {
        public string SearchQuery { get; set; } = string.Empty;
        public DateTime SearchedAt { get; set; } = DateTime.Now;
        public int ResultCount { get; set; }
        public string? ExtensionFilter { get; set; }
    }
}
