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
    using Jayrock.Diagnostics;

    #endregion

    [ Serializable ]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public struct JsonToken
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        private readonly JsonTokenClass _class;
        private readonly string _text;

        private JsonToken(JsonTokenClass clazz) :
            this(clazz, null) {}

        private JsonToken(JsonTokenClass clazz, string text)
        {
            _class = clazz;
            _text = text;
        }
        
        /// <summary>
        /// Gets the class/type/category of the token.
        /// </summary>

        public JsonTokenClass Class
        {
            get { return _class; }
        }

        /// <summary>
        /// Gets the current token text, if applicable, otherwise null.
        /// </summary>

        public string Text
        {
            get { return _text; }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override string ToString()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Text == null ? Class.Name : Class.Name + ":" + DebugString.Format(Text);
        }
        
        //
        // Static methods for building tokens of various classes...
        //

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonToken Null()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return new JsonToken(JsonTokenClass.Null, JsonNull.Text);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonToken Array()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return new JsonToken(JsonTokenClass.Array);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonToken EndArray()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return new JsonToken(JsonTokenClass.EndArray);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonToken Object()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return new JsonToken(JsonTokenClass.Object);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonToken EndObject()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return new JsonToken(JsonTokenClass.EndObject);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonToken BOF()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return new JsonToken(JsonTokenClass.BOF);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonToken EOF()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return new JsonToken(JsonTokenClass.EOF);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonToken String(string text)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return new JsonToken(JsonTokenClass.String, Mask.NullString(text));
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonToken Boolean(bool value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return new JsonToken(JsonTokenClass.Boolean, value ? "true" : "false");
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonToken True()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Boolean(true);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonToken False()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Boolean(false);
        }
        
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonToken Number(string text)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (text == null)                   
                throw new ArgumentNullException("text)");
                    
            if (text.Length == 0)
                throw new ArgumentException("Number text cannot zero in length.", "text)");
                    
            return new JsonToken(JsonTokenClass.Number, text);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static JsonToken Member(string name)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return new JsonToken(JsonTokenClass.Member, name);
        }
    }
}