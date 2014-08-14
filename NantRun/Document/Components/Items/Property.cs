using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NantRun.Document.Components.Items
{
    public class Property
    {
        public static readonly string[] AttributeNames = new[]
                                                         {
                                                             "name",
                                                             "value",
                                                             "dynamic",
                                                             "readonly",
                                                             "failonerror",
                                                             "if",
                                                             "verbose",
                                                             "overwrite",
                                                             "unless",
                                                         };
        public string Attributes { get; set; }
        public List<string> Attribute { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string If { get; set; }
        public string Unless { get; set; }

        public string Dynamic { get; set; }
        public string ReadOnly { get; set; }
        public string FailOnError { get; set; }
        public string Verbose { get; set; }
        public string Overwrite { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}