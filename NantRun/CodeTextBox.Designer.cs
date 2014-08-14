using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace NantRun
{
    partial class CodeTextBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Name = "CodeTextBox";
        }

        #endregion

        /// <summary>
        /// Textbox content.
        /// </summary>
        public string Content
        {
            get{ return Text;}
            set
            {
                Text = StackedAddition(value);
            }
        }

        /// <summary>
        /// Uses a stack to create a properly tabbed xml string.
        /// </summary>
        /// <param name="value">xml string to format</param>
        /// <returns>formatted xml string</returns>
        private string StackedAddition(string value)
        {
            stack.Clear();
            StringBuilder builder = new StringBuilder();
            LineReader lineReader = null;
            try
            {
                using (lineReader = new LineReader(value))
                {
                    string line = string.Empty;
                    while (!((line = lineReader.ReadLine()).CompareTo("") == 0))
                    {
                        if (IsComment(line))
                        {
                            builder.AppendLine(Spacer(stack.Count) + line);
                        }
                        else
                        {
                            string[] nodeData = line.Split(' ');
                            foreach (string s in nodeData)
                            {
                                if (s.CompareTo("") == 0)
                                    goto end;
                                if (s[0].CompareTo('<') == 0)
                                {
                                    if (s.Contains("/>"))
                                    {
                                        builder.AppendLine(Spacer(stack.Count) + line);
                                        break;
                                    }
                                    else if (!s.StartsWith("</"))
                                    {
                                        builder.AppendLine(Spacer(stack.Count) + line);
                                        stack.Add(s.TrimStart('<').TrimEnd('>'));
                                    }
                                }
                                if (s[s.Length - 1].CompareTo('>') == 0)
                                {
                                    //int count = GetStackCount(TrimClosingTags(s));
                                    if (s.CompareTo("/>") == 0)
                                    {
                                        Pop();
                                    }
                                    else if (stack.Contains(TrimClosingTags(s)) && s.StartsWith("</"))
                                    {
                                        Pop();
                                        builder.AppendLine(Spacer(stack.Count) + line);
                                    }
                                }
                                end:
                                ;
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                
            }
            return builder.ToString();
        }

        private int GetStackCount(string item)
        {
            int count = 0;
            foreach(string s in stack)
            {
                if(s.ToLower().CompareTo(item) == 0)
                {
                    count++;
                }
            }
            return count;
        }

        private string TrimClosingTags(string value)
        {
            if (value != null)
                return value.TrimEnd('>').TrimStart('<','/');
            return null;
        }

        private void Pop()
        {
            if(stack.Count > 0)
                stack.RemoveAt(stack.Count - 1);
        }

        private string Spacer(int length)
        {
            string result = string.Empty;
            for(int i = 0;i < length;i++)
            {
                //result += "\t";
                result += "   ";
            }
            return result;
        }


        /// <summary>
        /// XML Line Reader Class
        /// </summary>
        public class LineReader : object, System.IDisposable
        {
            private string content;
            private int index;
            public LineReader(string value)
            {
                this.content = value;
            }

            public string ReadLine()
            {
                StringBuilder stringBuilder = new StringBuilder();
                bool lineComplete = false;
                for (; index < content.Length; index++)
                {
                    switch (content[index])
                    {
                        case '>':
                            stringBuilder.Append(content[index]);
                            index++;
                            lineComplete = true;
                            break;
                        default:
                            stringBuilder.Append(content[index]);
                            break;
                    }
                    if(lineComplete)
                        break;

                }
                return stringBuilder.ToString();
            }

            public void Dispose()
            {
                content = null;
            }
        }
    }
}