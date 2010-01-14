using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevEck.ScriptingEngine.Environment;
using DevEck.ScriptingEngine.Environment.Basic;
using System.Xml;
using System.CodeDom.Compiler;

namespace DevEck.ScriptingEngine.Tests
{
    public partial class TestForm : Form
    {

        public delegate string MethodInvokerStrDelegate();

        public TestForm()
        {
            InitializeComponent();

            Fireball.CodeEditor.SyntaxFiles.CodeEditorSyntaxLoader.SetSyntax(
                codeEditorControl1, Fireball.CodeEditor.SyntaxFiles.SyntaxLanguage.VBNET);
        }


        private void _buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                TestEnvironment env = new TestEnvironment(ScriptingLanguage.VBdotNet, Console.Out);
                _textCompileErrors.Text = "Compiling...\n";
                env.MainCode = syntaxDocument1.Text;
                env.Execute();

                if (env.CompilerResults.Errors.HasErrors == false)
                    _textCompileErrors.Text += "\nSuccessful compiled and run";
                else
                {
                    foreach (CompilerError error in env.CompilerResults.Errors)
                    {
                        _textCompileErrors.Text += "\n" + error.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                _textCompileErrors.Text += "Error running script: " + ex.ToString();
            }

        }

    }
}
