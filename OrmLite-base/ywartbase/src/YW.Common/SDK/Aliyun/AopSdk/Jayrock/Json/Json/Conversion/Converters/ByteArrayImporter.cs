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
    using System.IO;

    #endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class ByteArrayImporter : ImporterBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ByteArrayImporter() : base(typeof(byte[])) {}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ImportFromArray(ImportContext context, JsonReader reader)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Debug.Assert(context != null);
            Debug.Assert(reader != null);

            reader.Read();
            
            MemoryStream ms = new MemoryStream();
            Type byteType = typeof(byte);

            while (reader.TokenClass != JsonTokenClass.EndArray)
                ms.WriteByte((byte) context.Import(byteType, reader));

            return ReadReturning(reader, ms.ToArray());
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ImportFromBoolean(ImportContext context, JsonReader reader)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return new byte[] { (byte) (reader.ReadBoolean() ? 1 : 0) };
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ImportFromNumber(ImportContext context, JsonReader reader)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return new byte[] { reader.ReadNumber().ToByte() };
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override object ImportFromString(ImportContext context, JsonReader reader)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            try
            {
                return Convert.FromBase64String(reader.ReadString());
            }
            catch (FormatException e)
            {
                throw new JsonException("Error converting JSON String containing base64-encode data to " + OutputType.FullName + ".", e);
            }
        }
    }
}