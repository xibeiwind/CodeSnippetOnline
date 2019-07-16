using System;
using System.ComponentModel.DataAnnotations.Schema;
using Yunyong.Core;

namespace CodeSnippet.Online.Models
{
    [Table(nameof(SnippetTagMap))]
    public class SnippetTagMap : Entity
    {
        public Guid SnippetId { get; set; }
        public Guid TagId { get; set; }
    }
}