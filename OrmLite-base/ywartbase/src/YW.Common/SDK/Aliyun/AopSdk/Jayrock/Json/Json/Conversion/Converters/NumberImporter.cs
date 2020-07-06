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
    public abstract class NumberImporterBase : ImporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected NumberImporterBase(Type type) :
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(type) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ImportFromString(ImportContext context, JsonReader reader)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return ImportFromNumber(context, reader);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ImportFromNumber(ImportContext context, JsonReader reader)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (context == null)
                throw new ArgumentNullException("context");

            if (reader == null)
                throw new ArgumentNullException("reader");

            string text = reader.Text;
            
            try
            {
                return ReadReturning(reader, ConvertFromString(text));
            }
            catch (FormatException e)
            {
                throw NumberError(e, text);
            }
            catch (OverflowException e)
            {
                throw NumberError(e, text);
            }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ImportFromBoolean(ImportContext context, JsonReader reader)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Convert.ChangeType(BooleanObject.Box(reader.ReadBoolean()), OutputType);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected abstract object ConvertFromString(string s);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        private Exception NumberError(Exception e, string text)
        {
            return new JsonException(string.Format("Error importing JSON Number {0} as {1}.", text, OutputType.FullName), e);
        }
    }
    
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class ByteImporter : NumberImporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ByteImporter() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(byte)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ConvertFromString(string s)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Convert.ToByte(s, CultureInfo.InvariantCulture);
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class Int16Importer : NumberImporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Int16Importer() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(short)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ConvertFromString(string s)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Convert.ToInt16(s, CultureInfo.InvariantCulture);
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class Int32Importer : NumberImporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Int32Importer() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(int)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ConvertFromString(string s)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Convert.ToInt32(s, CultureInfo.InvariantCulture);
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class Int64Importer : NumberImporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Int64Importer() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(long)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ConvertFromString(string s)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Convert.ToInt64(s, CultureInfo.InvariantCulture);
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class SingleImporter : NumberImporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public SingleImporter() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(float)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ConvertFromString(string s)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Convert.ToSingle(s, CultureInfo.InvariantCulture);
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class DoubleImporter : NumberImporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DoubleImporter() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(double)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ConvertFromString(string s)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Convert.ToDouble(s, CultureInfo.InvariantCulture);
        }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class DecimalImporter : NumberImporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DecimalImporter() : 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            base(typeof(decimal)) {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ConvertFromString(string s)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Convert.ToDecimal(s, CultureInfo.InvariantCulture);
        }
    }
}