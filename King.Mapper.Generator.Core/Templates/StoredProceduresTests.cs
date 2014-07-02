﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace King.Mapper.Generator.Templates
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class StoredProceduresTests : StoredProceduresTestsBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("namespace RESAAS.Test.Contracts\r\n{\r\n    using System;\r\n    using System.Data;\r\n\tu" +
                    "sing System.Linq;\r\n    using Microsoft.VisualStudio.TestTools.UnitTesting;\r\n");
            
            #line 8 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"

foreach (var proc in this.Manifest.Values)
{
	var className = proc.Preface + proc.Name;

            
            #line default
            #line hidden
            this.Write("\t[TestClass]\r\n\tpublic class ");
            
            #line 14 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(proc.Preface.CamelCase()));
            
            #line default
            #line hidden
            
            #line 14 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(proc.Name.CamelCase()));
            
            #line default
            #line hidden
            this.Write("Test\r\n\t{\r\n\t\t[TestMethod]\r\n\t\tpublic void Constructor()\r\n\t\t{\r\n\t\t\tnew ");
            
            #line 19 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("(); \r\n\t\t}\r\n\t\t\r\n\t\t[TestMethod]\r\n\t\tpublic void IsIStoredProc()\r\n\t\t{\r\n\t\t\tAssert.IsNo" +
                    "tNull(new ");
            
            #line 25 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("() as IStoredProc); \r\n\t\t}\r\n\t\t\r\n\t\t[TestMethod]\r\n\t\tpublic void IsIValidate");
            
            #line 29 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("()\r\n\t\t{\r\n\t\t\tAssert.IsNotNull(new ");
            
            #line 31 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("() as IValidate<");
            
            #line 31 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write(">);\r\n\t\t}\r\n\r\n\t\t#region Paremeter Tests\r\n");
            
            #line 35 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"

foreach (var parameter in proc.Variables)
{
	var name = parameter.Name.Replace("@", string.Empty);
	if (!string.IsNullOrWhiteSpace(name))
	{

            
            #line default
            #line hidden
            this.Write("\t\t[TestMethod]\r\n\t\tpublic void ");
            
            #line 43 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(name.CamelCase()));
            
            #line default
            #line hidden
            this.Write("Parameter()\r\n\t\t{\r\n\t\t\tAssert.AreEqual<string>(\"");
            
            #line 45 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 45 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 45 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(name));
            
            #line default
            #line hidden
            this.Write("Parameter);\r\n\t\t}\r\n\r\n");
            
            #line 48 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"

	}
}

            
            #line default
            #line hidden
            this.Write("\t\t#endregion\r\n\t\t\r\n\t\t#region Property Tests\r\n");
            
            #line 55 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"

foreach (var parameter in proc.Variables)
{
	var dataTypeCSharp = DataTypeMappings.DataTypeCSharp(parameter.DataType);
	var name = parameter.Name.Replace("@", string.Empty);
	if (!string.IsNullOrWhiteSpace(name))
	{

            
            #line default
            #line hidden
            this.Write("\t\t[TestMethod]\r\n\t\tpublic void ");
            
            #line 64 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(name.CamelCase()));
            
            #line default
            #line hidden
            this.Write("GetSet()\r\n\t\t{\r\n\t\t\tvar item = new ");
            
            #line 66 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("();\r\n\t\t\tvar data = ");
            
            #line 67 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DataTypeMappings.DataTypeInitialize(dataTypeCSharp)));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\titem.");
            
            #line 68 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(name));
            
            #line default
            #line hidden
            this.Write(" = data;\r\n\t\t\tAssert.AreEqual<");
            
            #line 69 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DataTypeMappings.DataTypeCSharp(parameter.DataType)));
            
            #line default
            #line hidden
            this.Write(">(data, item.");
            
            #line 69 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(name));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t}\r\n\r\n\t\t[TestMethod]\r\n\t\tpublic void ");
            
            #line 73 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(name.CamelCase()));
            
            #line default
            #line hidden
            this.Write("DataMapper()\r\n\t\t{\r\n\t\t\tvar item = new ");
            
            #line 75 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("();\r\n            var property = (from prop in item.GetProperties()\r\n             " +
                    "              where prop.Name == \"");
            
            #line 77 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(name));
            
            #line default
            #line hidden
            this.Write("\"\r\n                           select prop).FirstOrDefault();\r\n            Assert." +
                    "IsNotNull(property);\r\n            var mapper = property.GetAttribute<DataMapperA" +
                    "ttribute>();\r\n            Assert.IsNotNull(mapper);\r\n            Assert.AreEqual" +
                    "<string>(\"");
            
            #line 82 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write("\", mapper.ParameterName);\r\n            Assert.AreEqual<DbType>(");
            
            #line 83 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DataTypeMappings.DataTypeDbType(parameter.DataType)));
            
            #line default
            #line hidden
            this.Write(", mapper.DatabaseType);\r\n\t\t}\r\n\r\n");
            
            #line 86 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"

	}
}

            
            #line default
            #line hidden
            this.Write("\t\t#endregion\r\n\t\t/**\r\n\t\t#region Validation Tests\r\n");
            
            #line 93 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"

foreach (var parameter in proc.Variables)
{
	var dataTypeCSharp = DataTypeMappings.DataTypeCSharp(parameter.DataType);
	if (dataTypeCSharp == "string")
	{
		var name = parameter.Name.Replace("@", string.Empty);
		if (0 < parameter.MaxLength)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[TestMethod]\r\n\t\tpublic void ");
            
            #line 104 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(name));
            
            #line default
            #line hidden
            this.Write("TooLong()\r\n\t\t{\r\n\t\t\tvar item = new ");
            
            #line 106 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("();\r\n\t\t\t");
            
            #line 107 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DataTypeMappings.StringTooLong(parameter.MaxLength)));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\titem.");
            
            #line 108 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(name));
            
            #line default
            #line hidden
            this.Write(" = data;\r\n\t\t\tvar validate = new Validator<");
            
            #line 109 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write(">();\r\n\t\t\tAssert.IsFalse(validate.IsValid(item), validate.AllMessages(item));\r\n\t\t}" +
                    "\r\n");
            
            #line 112 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"

		}

            
            #line default
            #line hidden
            this.Write("\t\t[TestMethod]\r\n\t\tpublic void ");
            
            #line 116 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(name));
            
            #line default
            #line hidden
            this.Write("Valid()\r\n\t\t{\r\n\t\t\tvar item = new ");
            
            #line 118 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("();\r\n\t\t\t");
            
            #line 119 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DataTypeMappings.StringValid(parameter.MaxLength)));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\titem.");
            
            #line 120 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(name));
            
            #line default
            #line hidden
            this.Write(" = data;\r\n\t\t\tvar validate = new Validator<");
            
            #line 121 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write(">();\r\n\t\t\tAssert.IsTrue(validate.IsValid(item), validate.AllMessages(item));\r\n\t\t}\r" +
                    "\n");
            
            #line 124 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"

	}
}

            
            #line default
            #line hidden
            this.Write("\t\t#endregion\r\n\t\t**/\r\n\t}\r\n\t\r\n");
            
            #line 132 "D:\Git\King.Mapper.Generator\King.Mapper.Generator.Core\Templates\StoredProceduresTests.tt"

}

            
            #line default
            #line hidden
            this.Write("}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class StoredProceduresTestsBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
