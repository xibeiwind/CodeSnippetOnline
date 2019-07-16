using System;
using System.ComponentModel.DataAnnotations.Schema;
using Yunyong.Core;

namespace CodeSnippet.Online.Models
{
    [Table(nameof(SnippetCategory))]
    public class SnippetCategory : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? ParentId { get; set; }
    }
}