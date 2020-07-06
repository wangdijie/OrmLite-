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

namespace Jayrock
{
    #region Imports

    using System;
    using System.Globalization;
    using System.IO;
    using System.Text;

    #endregion

    /// <summary>
    /// Drop-in replacement for <see cref="System.CodeDom.Compiler.IndentedTextWriter"/>
    /// that does not require a full-trust link and inheritance demand.
    /// </summary>

    public sealed class IndentedTextWriter : TextWriter
    {
        private TextWriter _writer;
        private int _level;
        private bool _tabsPending;
        private string _tab;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string DefaultTabString = "\x20\x20\x20\x20";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public IndentedTextWriter(TextWriter writer) : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            this(writer, DefaultTabString) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public IndentedTextWriter(TextWriter writer, string tabString) : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(CultureInfo.InvariantCulture)
        {
            _writer = writer;
            _tab = tabString;
            _level = 0;
            _tabsPending = false;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override Encoding Encoding
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get { return _writer.Encoding; }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override string NewLine
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get { return _writer.NewLine; }

            set { _writer.NewLine = value; }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int Indent
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get { return _level; }
            set { _level = value < 0 ? 0 : value; }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public TextWriter InnerWriter
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get { return _writer; }
        }

        internal string TabString
        {
            get { return _tab; }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Close()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            _writer.Close();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Flush()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            _writer.Flush();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Write(string s)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.Write(s);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Write(bool value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.Write(value);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Write(char value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.Write(value);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Write(char[] buffer)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.Write(buffer);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Write(char[] buffer, int index, int count)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.Write(buffer, index, count);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Write(double value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.Write(value);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Write(float value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.Write(value);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Write(int value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.Write(value);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Write(long value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.Write(value);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Write(object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.Write(value);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Write(string format, object arg0)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.Write(format, arg0);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Write(string format, object arg0, object arg1)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.Write(format, arg0, arg1);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void Write(string format, params object[] arg)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.Write(format, arg);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public void WriteLineNoTabs(string s)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            _writer.WriteLine(s);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine(string s)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine(s);
            _tabsPending = true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine();
            _tabsPending = true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine(bool value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine(value);
            _tabsPending = true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine(char value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine(value);
            _tabsPending = true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine(char[] buffer)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine(buffer);
            _tabsPending = true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine(char[] buffer, int index, int count)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine(buffer, index, count);
            _tabsPending = true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine(double value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine(value);
            _tabsPending = true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine(float value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine(value);
            _tabsPending = true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine(int value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine(value);
            _tabsPending = true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine(long value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine(value);
            _tabsPending = true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine(object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine(value);
            _tabsPending = true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine(string format, object arg0)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine(format, arg0);
            _tabsPending = true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine(string format, object arg0, object arg1)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine(format, arg0, arg1);
            _tabsPending = true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override void WriteLine(string format, params object[] arg)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            WritePendingTabs();
            _writer.WriteLine(format, arg);
            _tabsPending = true;
        }

        private void WritePendingTabs()
        {
            if (!_tabsPending)
                return;

            _tabsPending = false;

            for (int i = 0; i < _level; i++)
                _writer.Write(_tab);
        }
    }
}
