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
  public partial class NantRunMain : Form
  {
    private int childFormNumber = 0;

    public NantRunMain()
    {
      InitializeComponent();
    }

    private void ShowNewForm(object sender, EventArgs e)
    {
      Form childForm = new Form();
      childForm.MdiParent = this;
      childForm.Text = "Window " + childFormNumber++;
      childForm.Show();
    }

    private void OpenFile(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();

      // 
      // openFileDialog
      // 
      openFileDialog.DefaultExt = "build";
      openFileDialog.Filter = "All Files (*.*)|*.*|Build Files(*.nant;*.build;*.include,*.xml)|*.nant;*.build;*." +
          "include;*.xml";
      openFileDialog.FilterIndex = 2;
      openFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      openFileDialog.SupportMultiDottedExtensions = true;
      openFileDialog.Title = "Select build file...";

      if (openFileDialog.ShowDialog(this) == DialogResult.OK)
      {
        NantRunUI.SelectedFileName = openFileDialog.FileName;
      }
    }

    private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void CutToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.Cascade);
    }

    private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileVertical);
    }

    private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.ArrangeIcons);
    }

    private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (Form childForm in MdiChildren)
      {
        childForm.Close();
      }
    }

  }
}
