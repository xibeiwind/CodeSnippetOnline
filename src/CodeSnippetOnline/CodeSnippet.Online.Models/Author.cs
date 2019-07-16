using System.ComponentModel.DataAnnotations.Schema;
using Yunyong.Core;

namespace CodeSnippet.Online.Models
{
    [Table(nameof(Author))]
    public class Author : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
    }
}