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

namespace Jayrock.Json.Conversion
{
    #region Imports

    using System;
    using System.IO;
    using System.Text;

    #endregion

    /// <summary>
    /// Provides methods for converting between Common Language Runtime 
    /// (CLR) types and JSON types.
    /// </summary>
    
    public sealed class JsonConvert
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static void Export(object value, JsonWriter writer)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (writer == null)
                throw new ArgumentNullException("writer");
            
            ExportContext context = new ExportContext();
            context.Export(value, writer);
        }
        
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static void Export(object value, TextWriter writer)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (writer == null)
                throw new ArgumentNullException("writer");
            
            Export(value, new JsonTextWriter(writer));
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static void Export(object value, StringBuilder sb)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (sb == null)
                throw new ArgumentNullException("sb");
            
            Export(value, new StringWriter(sb));
        }
        
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static string ExportToString(object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            StringBuilder sb = new StringBuilder();
            Export(value, sb);
            return sb.ToString();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static object Import(string text)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Import(new StringReader(text));
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static object Import(TextReader reader)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Import(new JsonTextReader(reader));
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static object Import(JsonReader reader)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Import(AnyType.Value, reader);
        }
        
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static object Import(Type type, string text)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Import(type, new StringReader(text));
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static object Import(Type type, TextReader reader)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Import(type, new JsonTextReader(reader));
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static object Import(Type type, JsonReader reader)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (reader == null)
                throw new ArgumentNullException("reader");
            
            ImportContext context = new ImportContext();
            return context.Import(type, reader);
        }

#if NET_2_0

        //
        // Generic versions of Import methods.
        //

        public static T Import<T>(string text)
        {
            return (T) Import(typeof(T), text);
        }

        public static T Import<T>(TextReader reader)
        {
            return (T) Import(typeof(T), reader);
        }

        public static T Import<T>(JsonReader reader)
        {
            return (T) Import(typeof(T), reader);
        }

#endif

        private JsonConvert()
        {
            throw new NotSupportedException();
        }
    }
}
