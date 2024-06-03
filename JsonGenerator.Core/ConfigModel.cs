using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonGenerator.Core
{
    public class ConfigModel
    {
        public string? BaseDirectory { get; set; }
        public string? BaseFolderName { get; set; }
        public string? ClassesFolderName { get; set; }
        public string? JsonsFolderName { get; set; }
        public string? SchemasFolderName { get; set; }
    }
}
