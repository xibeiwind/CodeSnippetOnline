using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using CodeSnippet.Online.Core;
using CodeSnippet.Online.Core.Enums;
using Yunyong.Core;

namespace CodeSnippet.Online.Models
{
    [Table(nameof(CodeSnippet))]
    public class CodeSnippet : Entity
    {
        public Guid AuthorId { get; set; }
        public SnippetType Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string HelpUrl { get; set; }
        public string Shortcut { get; set; }
        public string SnippetCode { get; set; }
        public List<SnippetArgument> Arguments { get; set; }
        public string Imports { get; set; }

        public string IsPrivate { get; set; }
        public Guid CategoryId { get; set; }
    }
}