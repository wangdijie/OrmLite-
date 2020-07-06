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
    using System.Diagnostics;
    using System.Globalization;

    #endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public abstract class NumberExporterBase : ExporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected NumberExporterBase(Type inputType) : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(inputType) {}
        
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void ExportValue(ExportContext context, object value, JsonWriter writer)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (context == null)
                throw new ArgumentNullException("context");
            
            if (value == null)
                throw new ArgumentNullException("value");

            if (writer == null)
                throw new ArgumentNullException("writer");
            
            string s;

            try
            {
                s = ConvertToString(value);
            }
            catch (InvalidCastException e)
            {
                throw new JsonException(e.Message, e);
            }

            writer.WriteNumber(s);
        }
        
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected abstract string ConvertToString(object value);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
    
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class ByteExporter : NumberExporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ByteExporter() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(byte)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override string ConvertToString(object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return ((byte) value).ToString(CultureInfo.InvariantCulture);
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class Int16Exporter : NumberExporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Int16Exporter() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(short)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override string ConvertToString(object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return ((short) value).ToString(CultureInfo.InvariantCulture);
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class Int32Exporter : NumberExporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Int32Exporter() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(int)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override string ConvertToString(object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return ((int) value).ToString(CultureInfo.InvariantCulture);
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class Int64Exporter : NumberExporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Int64Exporter() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(long)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override string ConvertToString(object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return ((long) value).ToString(CultureInfo.InvariantCulture);
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class SingleExporter : NumberExporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public SingleExporter() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(float)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override string ConvertToString(object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return ((float) value).ToString(CultureInfo.InvariantCulture);
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class DoubleExporter : NumberExporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DoubleExporter() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(double)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override string ConvertToString(object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return ((double) value).ToString(CultureInfo.InvariantCulture);
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class DecimalExporter : NumberExporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DecimalExporter() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(decimal)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override string ConvertToString(object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return ((decimal) value).ToString(CultureInfo.InvariantCulture);
        }
    }
}
