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
    using System.Runtime.Serialization;

    #endregion

    [ Serializable ]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class JsonTokenClass : IObjectReference
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly JsonTokenClass Null = new JsonTokenClass("Null");
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly JsonTokenClass Boolean = new JsonTokenClass("Boolean", Superclass.Scalar);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly JsonTokenClass Number = new JsonTokenClass("Number", Superclass.Scalar);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly JsonTokenClass String = new JsonTokenClass("String", Superclass.Scalar);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly JsonTokenClass Array = new JsonTokenClass("Array");
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly JsonTokenClass EndArray = new JsonTokenClass("EndArray", Superclass.Terminator);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly JsonTokenClass Object = new JsonTokenClass("Object");
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly JsonTokenClass EndObject = new JsonTokenClass("EndObject", Superclass.Terminator);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly JsonTokenClass Member = new JsonTokenClass("Member");
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly JsonTokenClass BOF = new JsonTokenClass("BOF", Superclass.Terminator);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly JsonTokenClass EOF = new JsonTokenClass("EOF", Superclass.Terminator);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static readonly ICollection All = new JsonTokenClass[] { BOF, EOF, Null, Boolean, Number, String, Array, EndArray, Object, EndObject, Member };
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            
        private readonly string _name;
        [ NonSerialized ] private readonly Superclass _superclass;
        
        private enum Superclass
        {
            Unspecified,
            Scalar,
            Terminator
        }
           
        private JsonTokenClass(string name) :
            this(name, Superclass.Unspecified) {}
        
        private JsonTokenClass(string name, Superclass superclass)
        {
            Debug.Assert(name != null);
            Debug.Assert(name.Length > 0);
                
            _name = name;
            _superclass = superclass;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string Name
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get { return _name; }
        }

        internal bool IsTerminator
        {
            get { return _superclass == Superclass.Terminator; }
        }

        internal bool IsScalar
        {
            get { return _superclass == Superclass.Scalar; }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override int GetHashCode()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Name.GetHashCode();
        }
            
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override string ToString()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Name;
        }
            
        object IObjectReference.GetRealObject(StreamingContext context)
        {
            foreach (JsonTokenClass clazz in All)
            {
                if (string.CompareOrdinal(clazz.Name, Name) == 0)
                    return clazz;
            }
                
            throw new SerializationException(string.Format("{0} is not a valid {1} instance.", Name, typeof(JsonTokenClass).FullName));
        }
    }
}