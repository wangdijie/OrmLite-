#region License, Terms and Conditions
//
// Jayrock - JSON and JSON-RPC for Microsoft .NET Framework and Mono
// Written by Atif Aziz (atif.aziz@skybow.com)
// Copyright (c) 2005 Atif Aziz. All rights reserved.
//
// This library is free software; you can redistribute it and/or modify it under
// the terms of the GNU Lesser General Public License as published by the Free
// Software Foundation; either version 2.1 of the License, or (at your option)
// any later version.
//
// This library is distributed in the hope that it will be useful, but WITHOUT
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
// FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more
// details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this library; if not, write to the Free Software Foundation, Inc.,
// 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA 
//
#endregion

namespace Jayrock.Json
{
    #region Imports

    using System;
    using System.IO;

    #endregion
    
    /// <summary>
    /// Represents a writer that provides a fast, non-cached, forward-only means of 
    /// emitting JSON data formatted as JSON text (RFC 4627).
    /// </summary>

    public class JsonTextWriter : JsonWriterBase
    {
        private readonly TextWriter _writer;

        //
        // Pretty printing as per:
        // http://developer.mozilla.org/es4/proposals/json_encoding_and_decoding.html
        //
        // <quote>
        // ...linefeeds are inserted after each { and , and before } , and multiples 
        // of 4 spaces are inserted to indicate the level of nesting, and one space 
        // will be inserted after :. Otherwise, no whitespace is inserted between 
        // the tokens.
        // </quote>
        //
        
        private bool _prettyPrint;
        private bool _newLine;
        private int _indent;
        private char[] _indentBuffer;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public JsonTextWriter() :
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            this(null) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public JsonTextWriter(TextWriter writer)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            _writer = writer != null ? writer : new StringWriter();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public bool PrettyPrint
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get { return _prettyPrint; }
            set { _prettyPrint = value; }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected TextWriter InnerWriter
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get { return _writer; }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Flush()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            _writer.Flush();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override string ToString()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            StringWriter stringWriter = _writer as StringWriter;
            return stringWriter != null ? 
                stringWriter.ToString() : base.ToString();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteStartObjectImpl()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            OnWritingValue();
            WriteDelimiter('{');
            PrettySpace();
        }
        
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteEndObjectImpl()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (Index > 0)
            {
                PrettyLine();
                _indent--;
            }

            WriteDelimiter('}');
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteMemberImpl(string name)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (Index > 0)
            {
                WriteDelimiter(',');
                PrettyLine();
            }
            else
            {
                PrettyLine();
                _indent++;
            }
            
            WriteStringImpl(name);
            PrettySpace();
            WriteDelimiter(':');
            PrettySpace();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteStringImpl(string value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WriteScalar(JsonString.Enquote(value));
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteNumberImpl(string value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WriteScalar(value);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteBooleanImpl(bool value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WriteScalar(value ? JsonBoolean.TrueText : JsonBoolean.FalseText);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteNullImpl()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WriteScalar(JsonNull.Text);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteStartArrayImpl()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            OnWritingValue();
            WriteDelimiter('[');
            PrettySpace();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteEndArrayImpl()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (IsNonEmptyArray())
                PrettySpace();

            WriteDelimiter(']');
        }

        private void WriteScalar(string text)
        {
            OnWritingValue();
            PrettyIndent();
            _writer.Write(text);
        }
        
        private bool IsNonEmptyArray()
        {
            return Bracket == JsonWriterBracket.Array && Index > 0;
        }
        
        //
        // Methods below are mostly related to pretty-printing of JSON text.
        //

        private void OnWritingValue()
        {
            if (IsNonEmptyArray())
            {
                WriteDelimiter(',');
                PrettySpace();
            }
        }

        private void WriteDelimiter(char ch)
        {
            PrettyIndent();
            _writer.Write(ch);
        }

        private void PrettySpace()
        {
            if (!_prettyPrint) return;
            WriteDelimiter(' ');
        }

        private void PrettyLine()
        {
            if (!_prettyPrint) return;
            _writer.WriteLine();
            _newLine = true;
        }

        private void PrettyIndent() 
        {
            if (!_prettyPrint)
                return;
            
            if (_newLine)
            {
                if (_indent > 0)
                {
                    int spaces = _indent * 4;
                    
                    if (_indentBuffer == null || _indentBuffer.Length < spaces)
                        _indentBuffer = new string(' ', spaces * 4).ToCharArray();
                    
                    _writer.Write(_indentBuffer, 0, spaces);
                }
                
                _newLine = false;
            }
        }
    }
}
