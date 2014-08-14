using System;
using System.Collections;
using System.Windows.Forms;
using NantRun.Document.Components;
using NantRun.Document.Components.Items;
using NantRun.Engine;

namespace NantRun
{
    partial class NantRunUI
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Targets", System.Windows.Forms.HorizontalAlignment.Left);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutNantRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.projectList = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.propertyLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.propertyList = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.projectLabel = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.targetPropLabel = new System.Windows.Forms.Label();
            this.targetPropBox = new System.Windows.Forms.ComboBox();
            this.codeTextBox = new NantRun.CodeTextBox();
            this.targetListView = new System.Windows.Forms.ListView();
            this.targetColumn = new System.Windows.Forms.ColumnHeader();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.attributeLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.attributeListBox = new System.Windows.Forms.ListBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.paramLabel = new System.Windows.Forms.Label();
            this.paramTextBox = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.runBtn = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(745, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.closeFileToolStripMenuItem.Text = "Close file...";
            this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutNantRunToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutNantRunToolStripMenuItem
            // 
            this.aboutNantRunToolStripMenuItem.Name = "aboutNantRunToolStripMenuItem";
            this.aboutNantRunToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutNantRunToolStripMenuItem.Text = "About NantRun...";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.93288F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.06712F));
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.panel12, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.panel6, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.panel9, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.panel11, 1, 3);
            this.mainTableLayoutPanel.Controls.Add(this.panel15, 0, 3);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.44592F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.55408F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(745, 481);
            this.mainTableLayoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 97);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.projectList, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(365, 97);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // projectList
            // 
            this.projectList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.projectList.BackColor = System.Drawing.SystemColors.Info;
            this.projectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectList.FormattingEnabled = true;
            this.projectList.Location = new System.Drawing.Point(73, 32);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(289, 27);
            this.projectList.TabIndex = 0;
            this.projectList.SelectionChangeCommitted += new System.EventHandler(this.projectList_SelectionChangeCommitted);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(73, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 23);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.propertyLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(64, 30);
            this.panel4.TabIndex = 2;
            // 
            // propertyLabel
            // 
            this.propertyLabel.AutoSize = true;
            this.propertyLabel.Location = new System.Drawing.Point(6, 0);
            this.propertyLabel.Name = "propertyLabel";
            this.propertyLabel.Size = new System.Drawing.Size(57, 13);
            this.propertyLabel.TabIndex = 0;
            this.propertyLabel.Text = "Properties:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.propertyList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(73, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(289, 30);
            this.panel5.TabIndex = 3;
            // 
            // propertyList
            // 
            this.propertyList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.propertyList.BackColor = System.Drawing.SystemColors.Info;
            this.propertyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyList.FormattingEnabled = true;
            this.propertyList.Location = new System.Drawing.Point(0, 0);
            this.propertyList.Name = "propertyList";
            this.propertyList.Size = new System.Drawing.Size(289, 27);
            this.propertyList.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.projectLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 26);
            this.panel3.TabIndex = 1;
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(7, 6);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(48, 13);
            this.projectLabel.TabIndex = 0;
            this.projectLabel.Text = "Projects:";
            // 
            // panel12
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.panel12, 2);
            this.panel12.Controls.Add(this.tableLayoutPanel7);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 141);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(739, 296);
            this.panel12.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.panel13, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.targetListView, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(739, 296);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.tableLayoutPanel5);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(374, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(362, 290);
            this.panel13.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.codeTextBox, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(362, 290);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.targetPropBox, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(356, 36);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.targetPropLabel);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(89, 30);
            this.panel14.TabIndex = 0;
            // 
            // targetPropLabel
            // 
            this.targetPropLabel.AutoSize = true;
            this.targetPropLabel.Location = new System.Drawing.Point(-3, 5);
            this.targetPropLabel.Name = "targetPropLabel";
            this.targetPropLabel.Size = new System.Drawing.Size(91, 13);
            this.targetPropLabel.TabIndex = 1;
            this.targetPropLabel.Text = "Target Properties:";
            // 
            // targetPropBox
            // 
            this.targetPropBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.targetPropBox.BackColor = System.Drawing.SystemColors.Info;
            this.targetPropBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetPropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetPropBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetPropBox.FormattingEnabled = true;
            this.targetPropBox.Location = new System.Drawing.Point(98, 3);
            this.targetPropBox.Name = "targetPropBox";
            this.targetPropBox.Size = new System.Drawing.Size(255, 27);
            this.targetPropBox.TabIndex = 1;
            // 
            // codeTextBox
            // 
            this.codeTextBox.AcceptsReturn = true;
            this.codeTextBox.AcceptsTab = true;
            this.codeTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.codeTextBox.Content = "";
            this.codeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.HideSelection = false;
            this.codeTextBox.Location = new System.Drawing.Point(3, 45);
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.codeTextBox.Size = new System.Drawing.Size(356, 242);
            this.codeTextBox.TabIndex = 1;
            this.codeTextBox.WordWrap = false;
            // 
            // targetListView
            // 
            this.targetListView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.targetListView.AutoArrange = false;
            this.targetListView.BackColor = System.Drawing.SystemColors.Info;
            this.targetListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.targetColumn});
            this.targetListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetListView.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetListView.FullRowSelect = true;
            this.targetListView.GridLines = true;
            listViewGroup1.Header = "Targets";
            listViewGroup1.Name = "targetGrp";
            this.targetListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.targetListView.HideSelection = false;
            this.targetListView.Location = new System.Drawing.Point(3, 3);
            this.targetListView.Name = "targetListView";
            this.targetListView.ShowGroups = false;
            this.targetListView.Size = new System.Drawing.Size(365, 290);
            this.targetListView.TabIndex = 0;
            this.targetListView.UseCompatibleStateImageBehavior = false;
            this.targetListView.View = System.Windows.Forms.View.Details;
            this.targetListView.SelectedIndexChanged += new System.EventHandler(this.targetListView_SelectedIndexChanged);
            this.targetListView.DoubleClick += new System.EventHandler(this.targetListView_DoubleClick);
            // 
            // targetColumn
            // 
            this.targetColumn.Text = "Targets";
            this.targetColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.targetColumn.Width = 360;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(374, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(368, 97);
            this.panel6.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(368, 97);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(362, 19);
            this.panel7.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.attributeLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 19);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // attributeLabel
            // 
            this.attributeLabel.AutoSize = true;
            this.attributeLabel.Location = new System.Drawing.Point(153, 0);
            this.attributeLabel.Name = "attributeLabel";
            this.attributeLabel.Size = new System.Drawing.Size(51, 13);
            this.attributeLabel.TabIndex = 1;
            this.attributeLabel.Text = "Attributes";
            this.attributeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.attributeListBox);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 28);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(362, 66);
            this.panel8.TabIndex = 1;
            // 
            // attributeListBox
            // 
            this.attributeListBox.BackColor = System.Drawing.SystemColors.Info;
            this.attributeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributeListBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributeListBox.FormattingEnabled = true;
            this.attributeListBox.ItemHeight = 18;
            this.attributeListBox.Location = new System.Drawing.Point(0, 0);
            this.attributeListBox.Name = "attributeListBox";
            this.attributeListBox.Size = new System.Drawing.Size(362, 58);
            this.attributeListBox.Sorted = true;
            this.attributeListBox.TabIndex = 0;
            // 
            // panel9
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.panel9, 2);
            this.panel9.Controls.Add(this.tableLayoutPanel4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 106);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(739, 29);
            this.panel9.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.paramTextBox, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(739, 29);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.paramLabel);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(94, 23);
            this.panel10.TabIndex = 0;
            // 
            // paramLabel
            // 
            this.paramLabel.AutoSize = true;
            this.paramLabel.Location = new System.Drawing.Point(7, 3);
            this.paramLabel.Name = "paramLabel";
            this.paramLabel.Size = new System.Drawing.Size(82, 13);
            this.paramLabel.TabIndex = 0;
            this.paramLabel.Text = "Set Parameters:";
            // 
            // paramTextBox
            // 
            this.paramTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.paramTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paramTextBox.Location = new System.Drawing.Point(103, 3);
            this.paramTextBox.Multiline = true;
            this.paramTextBox.Name = "paramTextBox";
            this.paramTextBox.Size = new System.Drawing.Size(633, 23);
            this.paramTextBox.TabIndex = 1;
            this.paramTextBox.Click += new System.EventHandler(this.OnTextBoxClicked);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.runBtn);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(374, 443);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(368, 35);
            this.panel11.TabIndex = 3;
            // 
            // runBtn
            // 
            this.runBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.runBtn.Location = new System.Drawing.Point(256, 0);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(112, 35);
            this.runBtn.TabIndex = 0;
            this.runBtn.Text = "Run Selected";
            this.runBtn.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(3, 443);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(365, 35);
            this.panel15.TabIndex = 6;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "build";
            this.openFileDialog.Filter = "All Files (*.*)|*.*|Build Files(*.nant;*.build;*.include,*.xml)|*.nant;*.build;*." +
                "include;*.xml";
            this.openFileDialog.FilterIndex = 2;
            this.openFileDialog.InitialDirectory = "C:\\Documents and Settings\\samuel.martey\\My Documents";
            this.openFileDialog.SupportMultiDottedExtensions = true;
            this.openFileDialog.Title = "Select build file...";
            // 
            // NantRunUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 505);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "NantRunUI";
            this.Text = "NantRun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NantRunUI_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void NantRunUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExecuteUnLoad();
        }


        private Collection<Target> GetSelectedTargets()
        {
            Collection<Target> targets = new Collection<Target>();
            
            IEnumerator iEnum = this.targetListView.SelectedItems.GetEnumerator();

            while (iEnum.MoveNext())
            {
                string targetSelected = ((ListViewItem)iEnum.Current).Text;
                foreach (Target target in LoadedTargets)
                {
                    if (targetSelected.CompareTo(target.Name) == 0)
                    {
                        targets.AddItem(target);
                    }
                }
            }
            return targets;
        }


        void projectList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeAttributes();
            PopulateTargets();
        }

        private void ChangeAttributes()
        {
            this.attributeListBox.Items.Clear();
            foreach(var project in document.Projects)
            {
                if(project.Name == projectList.SelectedItem.ToString())
                {
                    foreach(string attribute in project.Attribute)
                    {
                        this.attributeListBox.Items.Add(attribute);
                    }
                }
            }
        }

        void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteUnLoad();
        }

        void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SelectedFileName = openFileDialog.FileName;
                ExecuteLoader();
            }
        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutNantRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox projectList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label propertyLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox propertyList;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label paramLabel;
        private System.Windows.Forms.TextBox paramTextBox;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ListView targetListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label attributeLabel;
        private System.Windows.Forms.ColumnHeader targetColumn;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label targetPropLabel;
        private System.Windows.Forms.ComboBox targetPropBox;
        private CodeTextBox codeTextBox;
        private ListBox attributeListBox;
        private Panel panel15;
        private TableLayoutPanel tableLayoutPanel7;
    }
}

