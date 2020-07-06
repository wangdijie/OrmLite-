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

namespace Jayrock.Collections
{
    #region Imports

    using System;
    using System.Collections;

    #endregion

    [ Serializable ]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public abstract class KeyedCollection : CollectionBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        private Hashtable _valueByKey; // TODO: Mark [ NonSerializable ] and implement IDeserializationCallback

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected KeyedCollection()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            _valueByKey = new Hashtable();
        }
        
        private Hashtable ValueByKey
        {
            get { return _valueByKey; }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected void Add(object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            List.Add(value);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected object GetByKey(object key)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (key == null)
                throw new ArgumentNullException("key");
            
            return ValueByKey[key];
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected bool Contains(object key)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (key == null)
                throw new ArgumentNullException("key");
            
            return ValueByKey.ContainsKey(key);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected bool Remove(object key)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (key == null)
                throw new ArgumentNullException("key");

            object value = GetByKey(key);
            
            if (value == null)
                return false;
            
            List.Remove(value);
            return true;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void OnValidate(object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            base.OnValidate(value);
            
            if (KeyFromValue(value) == null)
                throw new ArgumentException("value");
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void OnInsertComplete(int index, object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            ValueByKey.Add(KeyFromValue(value), value);
            base.OnInsertComplete(index, value);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void OnRemoveComplete(int index, object value)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            ValueByKey.Remove(KeyFromValue(value));
            base.OnRemoveComplete(index, value);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void OnSetComplete(int index, object oldValue, object newValue)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            ValueByKey.Remove(KeyFromValue(oldValue));
            ValueByKey.Add(KeyFromValue(newValue), newValue);
            base.OnSetComplete(index, oldValue, newValue);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void OnClearComplete()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            ValueByKey.Clear();
            base.OnClearComplete();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected void ListKeysByIndex(Array keys)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (keys == null)
                throw new ArgumentNullException("keys");
            
            if (keys.Rank != 1)
                throw new ArgumentException("keys");

            for (int i = 0; i < Math.Min(Count, keys.Length); i++)
                keys.SetValue(KeyFromValue(InnerList[i]), i);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected abstract object KeyFromValue(object value);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
