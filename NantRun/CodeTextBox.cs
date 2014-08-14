using System.Collections.Generic;
using System.Windows.Forms;

namespace NantRun
{
    public partial class CodeTextBox : TextBox
    {
        private List<string> stack = new List<string>();
        
        public CodeTextBox()
        {
            InitializeComponent();
        }

        private static bool IsComment(string line)
        {
            return (line.StartsWith("<!--") || line.EndsWith("--!>"));  
        }
    }
}
