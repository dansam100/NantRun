using System.Collections.Generic;

namespace NantRun.Document.Components.Items
{
    public class Target 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Depends { get; set; }
        public string If { get; set; }
        public string Unless { get; set; }
        public string Attributes { get; set; }
        public Collection<Property> Properties { get; set; }
        public Collection<Task> Tasks { get; set; }
        public string NodeString { get; set; }

        public override string ToString()
        {
            return Attributes;
        }
    }
}