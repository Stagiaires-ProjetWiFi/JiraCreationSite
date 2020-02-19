using System.Collections.Generic;

namespace JiraCreationSite
{
    public class Suggestion
    {
        public string Label { get; set; }
        public string Html { get; set; }
    }

    public class SuggestionListStruct
    {
        public string Token { get; set; }
        public List<Suggestion> Suggestions { get; set; }
    }
}
