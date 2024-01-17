
using Newtonsoft.Json;

namespace CsFileProcessor
{
    public class RegexOptionsJson
    {
        public string Name { get; set; }
        public string FileType { get; set; }
        public List<RegexItem> RegexItems { get; set; }
        
    }
}
