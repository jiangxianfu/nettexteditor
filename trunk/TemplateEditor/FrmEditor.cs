using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using System.Diagnostics;
using System.IO;

namespace TemplateEditor
{
    public partial class FrmEditor : WinFormsUI.Docking.DockContent
    {
        public FrmEditor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 是否有修改
        /// </summary>
        private bool txtHasChanged = false;
        public virtual bool TxtHasChanged
        {
            get { return txtHasChanged; }
            set
            {
                txtHasChanged = value;
                if (value)
                {
                    this.TabText = this.TabText + "*";
                }
                else
                {
                    this.TabText = this.Text.TrimEnd('*');
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            //if (!DesignMode)
            //{
            //    this.TabText = null;
            //}
            this.DockState = WinFormsUI.Docking.DockState.Document;

            this.txtEditor.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
            this.txtEditor.Document.TextEditorProperties.Font = new System.Drawing.Font("新宋体", 9);
            this.txtEditor.TextChanged += new EventHandler(txtEditor_TextChanged);
            base.OnLoad(e);
        }

        void txtEditor_TextChanged(object sender, EventArgs e)
        {
            if (!TxtHasChanged)
            {
                TxtHasChanged = true;
            }
        }
        public void Save()
        {
            if (txtHasChanged)
            {
                string fullfilename = this.Text;
                this.txtEditor.SaveFile(fullfilename);
                this.TabText = this.TabText.TrimEnd('*');
                this.txtHasChanged = false;
                
            }
        }

        private void FrmEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.txtHasChanged)
            {
                FrmSaveChanged frmChanged = new FrmSaveChanged();
                frmChanged.TstringListBox.Items.Add(this.Text);
                switch (frmChanged.ShowDialog())
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        Save();
                        break;
                    default:
                        break;
                }
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            Save();
        }


        public void Open(string filename)
        {
            this.TabText = filename;
            this.Text = filename;
            this.txtEditor.LoadFile(filename);
            
        }
        private void menuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void txtEditor_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
        //    {
        //        e.Effect = DragDropEffects.All;
        //    }
        //}
        //private void txtEditor_DragDrop(object sender, DragEventArgs e)
        //{
        //    string filename = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        //    FrmEditor formEditor = new FrmEditor();
        //    formEditor.Tag = this.Tag;
        //    formEditor.Open(filename);
        //    formEditor.Show(this.DockPanel);
        //}

        //private void FrmEditor_DragDrop(object sender, DragEventArgs e)
        //{

        //}

        //private void FrmEditor_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
        //    {
        //        e.Effect = DragDropEffects.All;
        //    }
        //}        

    }
}
