using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using NantRun.Document;
using NantRun.Document.Components;
using NantRun.Document.Components.Items;

namespace NantRun.Loader
{
    class ThreadLoader
    {
        private FileInfo fileInfo = null;
        public static void Load(object obj)
        {
            string filename = (string)obj;
            try
            {
                FileInfo file = new FileInfo(filename);
                if (file.Exists)
                {
                    DocumentLoader.Document = new ThreadLoader().Load(file.FullName);
                }
                else throw new FileNotFoundException("Invalid file specified");
            }
            catch { }//file does not exist.
        }

        private LoadedDocument Load(string file)
        {
            fileInfo = new FileInfo(file);
            return LoadProjects(fileInfo);
        }

        private static Collection<LoadedDocument> LoadIncludedProjects(XmlNode project, string fileName)
        {
            IEnumerable<XmlNode> includedProjs = GetNodeList(project, "include");
            Collection<LoadedDocument> projContainer = new Collection<LoadedDocument>();
            if (includedProjs == null)
                return projContainer;


            foreach (XmlElement file in includedProjs)
            {
                FileInfo fileInfo = new FileInfo(GetPath(GetAttribute("buildfile", file), fileName));
                LoadedDocument doc = new ThreadLoader().Load(fileInfo.FullName);
                if (!projContainer.Contains(doc))
                    projContainer.Add(doc);
            }
            return projContainer;
        }

        private static string GetPath(string path, string relative)
        {
            if (Path.IsPathRooted(path))
            {
                FileInfo file = new FileInfo(path);
                return file.FullName;
            }
            else
            {
                DirectoryInfo dirInfo = new DirectoryInfo(relative);
                FileInfo file = new FileInfo(Path.Combine(dirInfo.FullName, path));
                return file.FullName;
            }
        }

        private static LoadedDocument LoadProjects(FileSystemInfo fileInfo)
        {
            XmlDocument xmlDocument = new XmlDocument();
            const string projectSelectString = "/*";
            xmlDocument.Load(fileInfo.FullName);
            XmlNodeList projects = xmlDocument.SelectNodes(projectSelectString);
            //XmlNodeList includedDocuments = xmlDocument.SelectNodes("/project//include");
            LoadedDocument document = new LoadedDocument
              {
                  FileName = fileInfo.FullName,
                  Projects = new Projects(),
                  IncludedDocuments = new Collection<LoadedDocument>()
              };

            if (projects == null)
                return null;
           
            foreach (XmlNode proj in projects)
            {
                document.IncludedDocuments = LoadIncludedProjects(proj, fileInfo.FullName);
                Project project = new Project
                                      {
                                          BaseDirectory = GetAttribute("basedir", proj),
                                          DefaultTarget = GetAttribute("default", proj),
                                          XmlNameSpace = GetAttribute("xmlns", proj),
                                          Name = GetAttribute("name", proj),
                                          Properties = LoadProperties(proj),
                                          Targets = LoadTargets(proj),
                                          Tasks = LoadTasks(proj),
                                          Attribute = CreateAttributeList(proj),
                                          Attributes = CreateToString(proj),
                                      };

                project.AllProperties = project.Properties;
                project.AllTargets = project.Targets;
                document.Projects.AddItem(project);
                CopyOver(document.IncludedDocuments, ref project);
            }
            return document;
        }

        /// <summary>
        /// Copy over values from 'a' to 'b'
        /// </summary>
        /// <param name="a">a collection of loaded documents</param>
        /// <param name="b">a project</param>
        public static void CopyOver(Collection<LoadedDocument> a, ref Project b)
        {
            foreach(LoadedDocument document in a)
            {
                foreach(Project proj in document.Projects)
                {
                    foreach(Property property in proj.AllProperties)
                    {
                        b.AllProperties.AddItem(property);
                    }
                    foreach (Target target in proj.AllTargets)
                    {
                        b.AllTargets.AddItem(target);
                    }
                }
            }
        }


        public static string GetAttribute(string attName, XmlNode node)
        {
            return (node != null && node.Attributes[attName] != null) ? node.Attributes[attName].Value : null;
        }


        public static string GetAttribute(string attName, XElement node)
        {
            return (from item in node.Attributes()
                    where item.Name.LocalName.CompareTo(attName) == 0
                    select item.Value).FirstOrDefault();
        }

        private static Collection<Property> LoadProperties(XmlNode node)
        {
            IEnumerable<XmlNode> properties = GetNodeList(node, "property");
            Collection<Property> propContainer = new Collection<Property>();
            if(properties == null)
                return propContainer;
           
            foreach (XmlElement prop in properties)
            {
                Property property = new Property
                                        {
                                            Name = GetAttribute("name", prop),
                                            Dynamic = GetAttribute("dynamic", prop),
                                            FailOnError = GetAttribute("failonerror", prop),
                                            If = GetAttribute("if", prop),
                                            Overwrite = GetAttribute("overwrite", prop),
                                            ReadOnly = GetAttribute("readonly", prop),
                                            Unless = GetAttribute("unless", prop),
                                            Value = GetAttribute("value", prop),
                                            Verbose = GetAttribute("verbose", prop),
                                            Attribute = CreateAttributeList(prop),
                                            Attributes = CreateToString(prop)
                                        };
                if(!propContainer.Contains(property.Name))
                    propContainer.Add(property);
            }
            return propContainer;
        }


        private static List<string> CreateAttributeList(XmlNode property)
        {
            List<string> list = new List<string>();
            foreach (XmlAttribute attribute in property.Attributes)
            {
                list.Add(string.Format("{0} = {1}", attribute.Name, attribute.Value));
            }
            return list;
        }


        private static Collection<Target> LoadTargets(XmlNode project)
        {
            IEnumerable<XmlNode> properties = GetNodeList(project, "target");
            Collection<Target> targetContainer = new Collection<Target>();
            if (properties == null)
                return targetContainer;

            foreach (XmlNode targ in properties)
            {
                Target target = new Target
                                    {
                                        Name = GetAttribute("name", targ),
                                        Depends = GetAttribute("depends", targ),
                                        If = GetAttribute("if", targ),
                                        Unless = GetAttribute("unless", targ),
                                        Description = GetAttribute("description", targ),
                                        Properties = LoadProperties(targ),
                                        Tasks = LoadTasks(targ),
                                        NodeString = targ.OuterXml,
                                        Attributes = CreateToString(targ)
                };

                targetContainer.Add(target);
            }
            return targetContainer;
        }


        private static string CreateToString(XmlNode node)
        {
            string toString = string.Empty;
            foreach (XmlAttribute attribute in node.Attributes)
            {
                toString += string.Format("{0} = {1}\r", attribute.Name, attribute.Value);
            }
            return toString;
        }


        private static IEnumerable<XmlNode> GetNodeList(XmlNode node, string nodeName)
        {
            List<XmlNode> nodeList = new List<XmlNode>();
            foreach(XmlNode childNode in node)
            {
                if(childNode.Name.CompareTo(nodeName) == 0 )
                {
                    nodeList.Add(childNode);
                }
            }
            return nodeList;
        }

        
        //TODO: Complete this.
        private static Collection<Task> LoadTasks(XmlNode node)
        {
            const string propSelectString = "//tasks";
            XmlNodeList properties = node.SelectNodes(propSelectString);
            IEnumerable<XmlNode> tasks = GetNodeList(node, "task");
            Collection<Task> taskContainer = new Collection<Task>();
            if (properties == null)
                return taskContainer;
            foreach (XmlNode targ in properties)
            {
                Task target = new Task
                {
                    /*Name = GetAttribute("name", targ),
                    Depends = GetAttribute("depends", targ),
                    If = GetAttribute("if", targ),
                    Unless = GetAttribute("unless", targ),
                    Description = GetAttribute("description", targ),
                    Properties = LoadProperties(targ),
                    Tasks = LoadTasks(targ),
                    Attributes = CreateToString(targ)*/
                };

                taskContainer.Add(target);
            }
            return taskContainer;
        }
    }
}
