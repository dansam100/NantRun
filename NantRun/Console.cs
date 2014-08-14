using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NantRun
{
    public partial class Console : Form
    {
        private StringBuilder content = new StringBuilder();

        public Console()
        {
            InitializeComponent();
        }

      public delegate void WriteLineDelegate(string value);

      public delegate void WriteLineFormatDelegate(string format, params string[] args);

      public delegate void WriteLineObjectDelegate(object value);

      public delegate void WriteLineEmptyDelegate();

      public void WriteLine()
      {
        try { this.Invoke(new WriteLineEmptyDelegate(Write)); }
        catch (Exception){}
      }

      public void WriteLine(string format, params string[] args)
      {
        try { this.Invoke(new WriteLineFormatDelegate(Write)); }
        catch (Exception) { }
      }

      public void WriteLine(string value)
      {
        try { this.Invoke(new WriteLineDelegate(Write)); }
        catch (Exception) { }
      }

      public void WriteLine(object value)
      {
        try { this.Invoke(new WriteLineObjectDelegate(Write)); }
        catch (Exception) { }
      }


        private void Write(string value)
        {
            content.AppendLine(value);
            this.Text = content.ToString();

        }


        private void Write(string format, params string[] args)
        {
            content.AppendFormat(format, args);
            this.Text = content.ToString();
        }

        private void Write()
        {
            content.AppendLine();
            this.Text = content.ToString();
        }

        private void Write(object value)
        {
            content.AppendLine(value.ToString());
            this.Text = content.ToString();

        }

        
    }
}
