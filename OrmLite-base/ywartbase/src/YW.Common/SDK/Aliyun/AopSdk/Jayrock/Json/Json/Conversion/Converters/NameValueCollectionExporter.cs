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

namespace Jayrock.Json.Conversion.Converters
{
    #region Imports

    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Diagnostics;
    
    #endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class NameValueCollectionExporter : ExporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public NameValueCollectionExporter() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            this(typeof(NameValueCollection)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public NameValueCollectionExporter(Type inputType) : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(inputType) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void ExportValue(ExportContext context, object value, JsonWriter writer)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Debug.Assert(context != null);
            Debug.Assert(value != null);
            Debug.Assert(writer != null);

            ExportCollection(context, (NameValueCollection) value, writer);
        }

        private static void ExportCollection(ExportContext context, NameValueCollection collection, JsonWriter writer)
        {
            Debug.Assert(context != null);
            Debug.Assert(collection != null);
            Debug.Assert(writer != null);

            writer.WriteStartObject();

            for (int i = 0; i < collection.Count; i++)
            {
                writer.WriteMember(collection.GetKey(i));

                string[] values = collection.GetValues(i);

                if (values == null)
                    writer.WriteNull();
                else if (values.Length > 1)
                    context.Export(values, writer);
                else
                    context.Export(values[0], writer);
            }

            writer.WriteEndObject();
        }
    }
}
