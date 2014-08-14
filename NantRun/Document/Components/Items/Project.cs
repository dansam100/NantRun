using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NantRun.Document.Components;
using NantRun.Document.Components.Items;

namespace NantRun.Document
{
    public class Project
    {
        /// <summary>
        /// Collection of properties in the current project file only.
        /// </summary>
        public Collection<Property> Properties { get; set; }
        /// <summary>
        /// Collection of targets in the current project file only.
        /// </summary>
        public Collection<Target> Targets { get; set; }
        /// <summary>
        /// Collection of tasks in the current project file only.
        /// </summary>
        public Collection<Task> Tasks { get; set; }

        /// <summary>
        /// Collection of all properties, including "included" files.
        /// </summary>
        public Collection<Property> AllProperties { get; set; }

        /// <summary>
        /// Collection of all targets, including "included" files.
        /// </summary>
        public Collection<Target> AllTargets { get; set; }

        public string Name { get; set; }
        public string DefaultTarget { get; set; }
        public string BaseDirectory { get; set; }
        public string XmlNameSpace { get; set; }
        public string Attributes { get; set; }
        public List<string> Attribute { get; set; }

        public override string ToString()
        {
            return Attributes;
        }
    }
}
