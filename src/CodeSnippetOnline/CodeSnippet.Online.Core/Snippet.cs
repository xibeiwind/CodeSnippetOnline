using System.Collections.Generic;
using CodeSnippet.Online.Core.Enums;

namespace CodeSnippet.Online.Core
{
    public class Snippet
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string HelpUrl { get; set; }
        public string Kind { get; set; }
        public string Shortcut { get; set; }
        public string Delimiter { get; set; } = "$";
        public IList<string> Keywords { get; } = new List<string>();
        
        public IList<string> Imports { get; } = new List<string>();
        public IList<string> References { get; } = new List<string>();
        public Language Language { get; set; }
        public string Code { get; set; }
        public SnippetType SnippetType { get; set; }

        public IList<Literal> Literals { get; } = new List<Literal>();

        public void AddLiteral(Literal literal)
        {

        }
        public void UpdateLiteral(Literal literal)
        {
        }

        public void RemoveLiteral(Literal literal)
        {
        }
    }
}