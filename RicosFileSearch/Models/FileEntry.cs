using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicosFileSearch.Models
{
    public class FileEntry : BaseEntity, ISearchable
    {
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public string FileExtension { get; set; } = string.Empty;
        public long ByteSize { get; set; }
        public DateTime LastChanged { get; set; }
        public DateTime LastIndexed { get; set; }
        public IndexedFolder? IndexedFolder { get; set; }
        public List<FileTag>? Tags { get; set; }

        public bool MatchesQuery (string query)
        {
            return FileName.Contains(query, StringComparison.OrdinalIgnoreCase);
        }

    }
}
