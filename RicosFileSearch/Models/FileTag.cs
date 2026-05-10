using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RicosFileSearch.Models;

namespace RicosFileSearch.Models
{
    public class FileTag : BaseEntity
    {
        public string FileTagName { get; set; } = string.Empty;
        public string Color { get; set; } = "#808080";
        public List<FileEntry> FileEntries { get; set; } = new();
    }
}
