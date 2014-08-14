using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using NantRun.Document;
using NantRun.Document.Components.Items;
using NantRun.Document.Components;
using NantRun.Engine;

namespace NantRun
{
    public partial class NantRunUI : Form
    {
        public static string SelectedFileName = string.Empty;
        private LoadedDocument document = null;
        private Projects LoadedProjects = null;
        private Collection<Target> LoadedTargets = null;
        private readonly RuntimeAllocator runtimeAllocator = null;

        Thread loadThread = null;
        Thread runThread = null;

        public NantRunUI()
        {
            InitializeComponent();
            runtimeAllocator = new RuntimeAllocator();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ExecuteLoader()
        {
            if(string.IsNullOrEmpty(SelectedFileName))
                return;
            //TODO: make it do some loading on a separate thread.
            Clear();
            ThreadStart loader = Generate;
            loadThread = new Thread(loader);
            document = DocumentLoader.Load(SelectedFileName);
            Load();
        }


        private new void Load()
        {
            loadThread.IsBackground = true;
            loadThread.Start();
            ThreadStart runStart = runtimeAllocator.Run;
            runThread = new Thread(runStart);
            runThread.SetApartmentState(ApartmentState.MTA);
            runThread.IsBackground = true;
            runThread.Start();
        }


        void targetListView_DoubleClick(object sender, EventArgs e)
        {
            //run the target.
            runtimeAllocator.Parameter = GetRunParameters();
            runtimeAllocator.Target = GetSelectedTargets();
            runtimeAllocator.AddedNew = true;
        }

        private void PopulateTargets()
        {
            this.targetListView.Items.Clear();
            string target = (string)this.projectList.SelectedItem;
            if (document == null)
                return;
            if (target == null && this.projectList.Items.Count > 0)
                target = (this.projectList.Items[0]).ToString();

            foreach (Project project in document.Projects)
            {
                if (project.Name.CompareTo(target) == 0)
                {
                    LoadedTargets = project.AllTargets;
                    break;
                }
            }
            foreach (Target targ in LoadedTargets)
            {
                this.targetListView.Items.Add(targ.Name);
            }
            if (LoadedTargets.Count > 0)
            {
                foreach (Property property in LoadedTargets[0].Properties)
                    this.targetPropBox.Items.Add(property.Name);
                this.codeTextBox.Content = LoadedTargets[0].NodeString;
            }

        }

        private void PopulateProperties()
        {
            Collection<Property> properties = new Collection<Property>();
            string property = (string)this.projectList.SelectedItem;
            if(document == null)
                return;
            if(property == null && this.projectList.Items.Count > 0)
                property = (this.projectList.Items[0]).ToString();
            
            foreach(Project project in document.Projects)
            {
                if (project.Name.CompareTo(property) == 0)
                {
                    properties = project.AllProperties;
                    break;
                }
            }
            foreach (Property prop in properties)
            {
                this.propertyList.Items.Add(prop.Name);
            }
            if(properties.Count > 0)
            {
                this.propertyList.SelectedIndex = 0;
            }
        }

        private delegate void PopulateListDelegate();
        internal void Generate()
        {
            try{this.Invoke(new PopulateListDelegate(PopulateProjects));}
            catch(Exception)
            {
                
            }
        }

        private void PopulateProjects()
        {
            if(document == null) return;
            LoadedProjects = document.Projects;
            foreach(Project project in document.Projects)
            {
                this.projectList.Items.Add(project.Name);
            }
            if(document.Projects.Count > 0)
            {
                this.projectList.SelectedIndex = 0; 
            }
            PopulateProperties();
            PopulateTargets();
        }

        private void ExecuteUnLoad()
        {
            this.EntireClear();
            if(this.runThread != null && this.runThread.IsAlive)
                runThread.Abort();
            if(this.loadThread != null && this.loadThread.IsAlive)
                loadThread.Abort();
        }

        private void Clear()
        {
            this.propertyList.Items.Clear();
            this.projectList.Items.Clear();
            this.targetPropBox.Items.Clear();
            this.codeTextBox.Clear();
        }

        private void EntireClear()
        {
            this.document = null;
            this.attributeListBox.Items.Clear();
            this.propertyList.Items.Clear();
            this.projectList.Items.Clear();
            this.targetListView.Clear();
            this.targetPropBox.Items.Clear();
            this.codeTextBox.Clear();
            this.document = null;
            LoadedProjects = null;
            this.LoadedTargets = null;
        }

        private void targetListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.targetPropBox.Items.Clear();
            IEnumerator iEnum = this.targetListView.SelectedItems.GetEnumerator();
            
            while (iEnum.MoveNext())
            {
                string targetSelected = ((ListViewItem)iEnum.Current).Text;
                foreach (Target target in LoadedTargets)
                {
                    if (targetSelected.CompareTo(target.Name) == 0)
                    {
                        this.codeTextBox.Content = target.NodeString;
                        foreach (Property property in target.Properties)
                        {
                            this.targetPropBox.Items.Add(property.Name);
                        }
                        break;
                    }
                }
                break;
            }
            if(this.targetPropBox.Items.Count > 0)
                this.targetPropBox.SelectedIndex = 0;
        }

        private Collection<Parameter> GetRunParameters()
        {
            Collection<Parameter> parameters = new Collection<Parameter>();
            string parameterVal = this.paramTextBox.Text;
            if(parameterVal.Length > 0)
            {
                
                string[] param = parameterVal.Split(' ');
                foreach(string s in param)
                {
                    if(s.Contains("="))
                    {
                        Parameter parameter = new Parameter(s);
                        parameters.AddItem(parameter);
                    }
                    else
                    {
                        if (param.Length > 1)
                        {
                            Exceptions.Exception.ShowError("Invalid Parameters!");
                            break;
                        }
                        string property = propertyList.SelectedItem.ToString();
                        if (property.Length > 0)
                        {
                            parameterVal = string.Format("{0}={1}", property, s);
                            Parameter parameter = new Parameter(parameterVal);
                            parameters.Add(parameter);
                        }
                        else
                            parameterVal = string.Empty;
                    }
                }
            }
            return parameters;
        }

        private void OnTextBoxClicked(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox) sender;
            textBox.SelectAll();
        }
    }
}
