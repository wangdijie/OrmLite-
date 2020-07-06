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
    using System.Collections;
    using System.Diagnostics;

    #endregion

    [ Serializable ]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class JsonRecorder : JsonWriterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        private ArrayList _tokenList;

        private ArrayList TokenList
        {
            get
            {
                if (_tokenList == null)
                    _tokenList = new ArrayList();

                return _tokenList;
            }
        }

        private void Write(JsonToken token)
        {
            TokenList.Add(token);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteStartObjectImpl()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Write(JsonToken.Object());
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteEndObjectImpl()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Write(JsonToken.EndObject());
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteMemberImpl(string name)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Write(JsonToken.Member(name));
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteStartArrayImpl()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Write(JsonToken.Array());
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteEndArrayImpl()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Write(JsonToken.EndArray());
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteStringImpl(string value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Write(JsonToken.String(value));
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteNumberImpl(string value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Write(JsonToken.Number(value));
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteBooleanImpl(bool value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Write(JsonToken.Boolean(value));
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void WriteNullImpl()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Write(JsonToken.Null());
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public JsonReader CreatePlayer()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            int count = _tokenList == null ? 0 : _tokenList.Count;
            
            JsonToken[] tokens = new JsonToken[count + 2];
            
            if (count > 0)
                _tokenList.CopyTo(tokens, 1);
            
            tokens[0] = JsonToken.BOF();
            tokens[tokens.Length - 1] = JsonToken.EOF();

            return new JsonPlayer(tokens);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public void Playback(JsonWriter writer)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (writer == null)
                throw new ArgumentNullException("writer");

            writer.WriteFromReader(CreatePlayer());
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonRecorder Record(JsonReader reader)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (reader == null)
                throw new ArgumentNullException("reader");

            JsonRecorder recorder = new JsonRecorder();
            recorder.WriteFromReader(reader);
            return recorder;
        }

        [ Serializable ]
        private sealed class JsonPlayer : JsonReaderBase
        {
            private int _index;
            private readonly JsonToken[] _tokens;

            public JsonPlayer(JsonToken[] tokens)
            {
                Debug.Assert(tokens != null);
                
                _tokens = tokens;
            }

            protected override JsonToken ReadTokenImpl()
            {
                return _tokens[++_index];
            }
        }
    }
}
