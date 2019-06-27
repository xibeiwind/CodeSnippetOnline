using System;
using System.ComponentModel.DataAnnotations.Schema;
using Yunyong.Core;

namespace CodeSnippetOnline.Models
{
    [Table(nameof(SnippetArgument))]
    public class SnippetArgument : Entity
    {
        public Guid CodeSnippetId { get; set; }
        public bool Editable { get; set; }
        public string IdString { get; set; }
        public string Tooltip { get; set; }
        public string Detail { get; set; }
        public string Function { get; set; }
    }
}