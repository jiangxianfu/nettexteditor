using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TemplateEditor
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutForm = new AboutBox();
            aboutForm.Owner = this;
            aboutForm.ShowDialog();
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            FrmEditor formEditor = new FrmEditor();
            formEditor.Tag = this;
            formEditor.TabText = "blank.cs";
            formEditor.Text = "blank.cs";
            formEditor.Show(this.dockPanelForm);
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Templete File (*.atcs)|*.atcs|CSharp Source File (*.cs)|*.cs|All Files (*.*)|*.*";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog.FileNames)
                {
                    OpenFile(filename);
                }
            }
        }
        private void menuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string fileName in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                OpenFile(fileName);
            }
        }

        private void FrmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void OpenFile(string filename)
        {
            FrmEditor formEditor = new FrmEditor();
            formEditor.Tag = this;
            formEditor.Open(filename);
            formEditor.Show(this.dockPanelForm);
        }

    }
}
