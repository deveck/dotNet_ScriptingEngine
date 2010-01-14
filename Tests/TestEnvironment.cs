using System;
using System.Collections.Generic;
using System.Text;
using DevEck.ScriptingEngine.Environment.Basic;
using DevEck.ScriptingEngine.Environment;
using System.IO;
using System.CodeDom.Compiler;

namespace DevEck.ScriptingEngine.Tests
{

    /// <summary>
    /// ScriptingEnvironmet, which provides some extra functionality
    /// </summary>
    public class TestEnvironment:BasicEnvironment
    {

        public delegate string BarMethodDelegate();

        /// <summary>
        /// Output is written here
        /// </summary>
        private TextWriter _writer;

        public CompilerResults CompilerResults
        {
            get { return _compilerResults; }
        }
        public TestEnvironment(ScriptingLanguage language, TextWriter strWriter)
            : base(language)
        {
            _writer = strWriter;
            MethodInfo fooMethodInfo = new MethodInfo("Foo", null, new ParameterInfo("text", typeof(string)));
            MethodInfo barMethodInfo = new MethodInfo("Bar", typeof(string));

            base.GlobalMethods.Add(fooMethodInfo);
            base.SetMethod(fooMethodInfo, new Action<string>(FooMethod));

            base.GlobalMethods.Add(barMethodInfo);
            base.SetMethod(barMethodInfo, new BarMethodDelegate(BarMethod));

            ParameterInfo writerParameterInfo = new ParameterInfo("Writer", typeof(TextWriter));
            base.GlobalParameters.Add(writerParameterInfo);
            base.SetParameter(writerParameterInfo, _writer);
        }

        private void FooMethod(string text)
        {
            _writer.WriteLine("FooMethod called with text='{0}'", text);
        }


        private string BarMethod()
        {
            _writer.WriteLine("BarMethod called");
            return "bar";
        }

    }
}
