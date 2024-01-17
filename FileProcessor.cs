using System;
using System.Text.RegularExpressions;

namespace CsFileProcessor
{
    public partial class FileProcessor
    {
       
        public static string ModifyFileContent(string content, RegexOptionsJson regexOptions)
        {            
            foreach (var regexPattern in regexOptions.RegexItems) 
            {
                string pattern = regexPattern.Pattern;
                string replacement = regexPattern.Replacement;
                content = Regex.Replace(content, pattern, replacement, RegexOptions.Multiline);
            }

            return content;
        }
    }
}
