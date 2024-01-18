
using Newtonsoft.Json;

namespace KoRegex
{
    public class RegexOptionsJson
    {
        public string Name { get; set; }
        public string FileType { get; set; }
        public List<RegexItem> RegexItems { get; set; }
        
    }
}
