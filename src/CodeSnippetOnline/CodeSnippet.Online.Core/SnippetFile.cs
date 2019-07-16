using System;
using System.Collections.Generic;

namespace CodeSnippet.Online.Core
{
    public class SnippetFile
    {
        public string FileName { get; }
        public List<Snippet> Snippets { get; } = new List<Snippet>();

        public SnippetFile(string fileName)
        {
            FileName = fileName;

            LoadSchema();
            LoadData();
        }

        private void LoadSchema()
        {
            throw new NotImplementedException();
        }

        private void LoadData()
        {
            throw new NotImplementedException();
        }
    }
}