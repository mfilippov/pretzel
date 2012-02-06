using System;
using System.Collections.Generic;

namespace Pretzel.Logic.Templating.Context
{
    public class Page
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime Date { get; set; }
        public string Id { get; set; }
        public IEnumerable<string> Categories { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public string Content { get; set; }
        public string Filepath { get; set; }
        public IDictionary<string, object> Bag { get; set; }
        public string File { get; set; }
    }

    public class NonProcessedPage : Page
    {
    }
}