namespace TemplateEditor
{
    partial class FrmEditor
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
            this.txtEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.frmEditorMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.frmEditorMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEditor
            // 
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.IsReadOnly = false;
            this.txtEditor.Location = new System.Drawing.Point(0, 0);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ShowVRuler = false;
            this.txtEditor.Size = new System.Drawing.Size(292, 273);
            this.txtEditor.TabIndex = 0;
            // 
            // frmEditorMenu
            // 
            this.frmEditorMenu.ImageScalingSize = new System.Drawing.Size(14, 14);
            this.frmEditorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave,
            this.toolStripSeparator2,
            this.menuClose});
            this.frmEditorMenu.Name = "tstringEditorMenu";
            this.frmEditorMenu.Size = new System.Drawing.Size(113, 54);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(112, 22);
            this.menuSave.Text = "保存(&S)";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(109, 6);
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuClose.ShowShortcutKeys = false;
            this.menuClose.Size = new System.Drawing.Size(112, 22);
            this.menuClose.Text = "关闭(&Q)";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // FrmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtEditor);
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmEditor";
            this.TabPageContextMenuStrip = this.frmEditorMenu;
            this.TabText = "FrmEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditor_FormClosing);
            this.frmEditorMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl txtEditor;
        private System.Windows.Forms.ContextMenuStrip frmEditorMenu;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
    }
}