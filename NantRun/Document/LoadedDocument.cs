using System.Collections.Generic;
using NantRun.Document.Components;

namespace NantRun.Document
{
    public class LoadedDocument
    {
        public string FileName { set; get; }
        public Projects Projects { get; set; }

        public Collection<LoadedDocument> IncludedDocuments { get; set; }
    }
}