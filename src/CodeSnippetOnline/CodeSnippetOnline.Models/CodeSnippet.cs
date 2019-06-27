using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using CodeSnippetOnline.Core;
using CodeSnippetOnline.Core.Enums;
using Yunyong.Core;

namespace CodeSnippetOnline.Models
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

        public string IsPrivate { get; set; }
        public Guid CategoryId { get; set; }
    }

    [Table(nameof(SnippetTagMap))]
    public class SnippetTagMap : Entity
    {
        public Guid SnippetId { get; set; }
        public Guid TagId { get; set; }
    }

    [Table(nameof(SnippetCategory))]
    public class SnippetCategory : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? ParentId { get; set; }
    }
}