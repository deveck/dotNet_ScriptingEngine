namespace DevEck.ScriptingEngine.Tests
{
    partial class TestForm
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
            Fireball.Windows.Forms.LineMarginRender lineMarginRender2 = new Fireball.Windows.Forms.LineMarginRender();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.codeEditorControl1 = new Fireball.Windows.Forms.CodeEditorControl();
            this.syntaxDocument1 = new Fireball.Syntax.SyntaxDocument(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._buttonRun = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this._textCompileErrors = new System.Windows.Forms.TextBox();
            this._textOutput = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeEditorControl1
            // 
            this.codeEditorControl1.ActiveView = Fireball.Windows.Forms.CodeEditor.ActiveView.BottomRight;
            this.codeEditorControl1.AutoListPosition = null;
            this.codeEditorControl1.AutoListSelectedText = "a123";
            this.codeEditorControl1.AutoListVisible = false;
            this.codeEditorControl1.CopyAsRTF = false;
            this.codeEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeEditorControl1.Document = this.syntaxDocument1;
            this.codeEditorControl1.InfoTipCount = 1;
            this.codeEditorControl1.InfoTipPosition = null;
            this.codeEditorControl1.InfoTipSelectedIndex = 1;
            this.codeEditorControl1.InfoTipVisible = false;
            lineMarginRender2.Bounds = new System.Drawing.Rectangle(19, 0, 19, 16);
            this.codeEditorControl1.LineMarginRender = lineMarginRender2;
            this.codeEditorControl1.Location = new System.Drawing.Point(0, 0);
            this.codeEditorControl1.LockCursorUpdate = false;
            this.codeEditorControl1.Name = "codeEditorControl1";
            this.codeEditorControl1.Saved = false;
            this.codeEditorControl1.ShowScopeIndicator = false;
            this.codeEditorControl1.Size = new System.Drawing.Size(855, 260);
            this.codeEditorControl1.SmoothScroll = false;
            this.codeEditorControl1.SplitviewH = -4;
            this.codeEditorControl1.SplitviewV = -4;
            this.codeEditorControl1.TabGuideColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.codeEditorControl1.TabIndex = 0;
            this.codeEditorControl1.Text = "codeEditorControl1";
            this.codeEditorControl1.WhitespaceColor = System.Drawing.SystemColors.ControlDark;
            // 
            // syntaxDocument1
            // 
            this.syntaxDocument1.Lines = new string[] {
        "Writer.WriteLine(\"Hello from userscript {0}\", Bar)\r",
        "Foo(\"Text\")"};
            this.syntaxDocument1.MaxUndoBufferSize = 1000;
            this.syntaxDocument1.Modified = false;
            this.syntaxDocument1.UndoStep = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStripContainer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(855, 430);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 1;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.codeEditorControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(855, 260);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(855, 285);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._buttonRun});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(33, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // _buttonRun
            // 
            this._buttonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._buttonRun.Image = ((System.Drawing.Image)(resources.GetObject("_buttonRun.Image")));
            this._buttonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._buttonRun.Name = "_buttonRun";
            this._buttonRun.Size = new System.Drawing.Size(23, 22);
            this._buttonRun.Text = "toolStripButton1";
            this._buttonRun.Click += new System.EventHandler(this._buttonRun_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this._textCompileErrors);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this._textOutput);
            this.splitContainer2.Size = new System.Drawing.Size(855, 141);
            this.splitContainer2.SplitterDistance = 424;
            this.splitContainer2.TabIndex = 0;
            // 
            // _textCompileErrors
            // 
            this._textCompileErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textCompileErrors.Location = new System.Drawing.Point(0, 0);
            this._textCompileErrors.Multiline = true;
            this._textCompileErrors.Name = "_textCompileErrors";
            this._textCompileErrors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._textCompileErrors.Size = new System.Drawing.Size(424, 141);
            this._textCompileErrors.TabIndex = 0;
            // 
            // _textOutput
            // 
            this._textOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textOutput.Location = new System.Drawing.Point(0, 0);
            this._textOutput.Multiline = true;
            this._textOutput.Name = "_textOutput";
            this._textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._textOutput.Size = new System.Drawing.Size(427, 141);
            this._textOutput.TabIndex = 1;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 430);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TestForm";
            this.Text = "Script Editor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Fireball.Windows.Forms.CodeEditorControl codeEditorControl1;
        private Fireball.Syntax.SyntaxDocument syntaxDocument1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox _textCompileErrors;
        private System.Windows.Forms.TextBox _textOutput;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _buttonRun;
    }
}

