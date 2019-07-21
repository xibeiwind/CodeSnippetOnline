using System;
using System.Collections.Generic;
using CodeSnippet.Online.Core;
using CodeSnippet.Online.Core.Enums;
using Yunyong.Core.ViewModels;

namespace CodeSnippet.Online.ViewModels
{
    public class SnippetVM : VMBase
    {
        public Guid AuthorId { get; set; }
        public bool IsPublic { get; set; }
        public string Title { get; set; }

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

        public IList<LiteralVM> Literals { get; } = new List<LiteralVM>();
    }
}