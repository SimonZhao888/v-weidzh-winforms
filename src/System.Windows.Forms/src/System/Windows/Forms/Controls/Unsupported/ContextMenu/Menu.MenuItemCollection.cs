﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.ComponentModel;

namespace System.Windows.Forms;

#nullable disable

public abstract partial class Menu
{
    [Obsolete(
        Obsoletions.MenuMessage,
        error: false,
        DiagnosticId = Obsoletions.MenuDiagnosticId,
        UrlFormat = Obsoletions.SharedUrlFormat)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ListBindable(false)]
    public class MenuItemCollection : IList
    {
        public MenuItemCollection(Menu owner) => throw new PlatformNotSupportedException();

        public virtual MenuItem this[int index] => throw new PlatformNotSupportedException();

        object IList.this[int index]
        {
            get => throw new PlatformNotSupportedException();
            set => throw new PlatformNotSupportedException();
        }

        public virtual MenuItem this[string key] => throw new PlatformNotSupportedException();

        public int Count => throw new PlatformNotSupportedException();

        object ICollection.SyncRoot => throw new PlatformNotSupportedException();

        bool ICollection.IsSynchronized => throw new PlatformNotSupportedException();

        bool IList.IsFixedSize => throw new PlatformNotSupportedException();

        public bool IsReadOnly => throw new PlatformNotSupportedException();

        public virtual MenuItem Add(string caption) => throw new PlatformNotSupportedException();

        public virtual MenuItem Add(string caption, EventHandler onClick) => throw new PlatformNotSupportedException();

        public virtual MenuItem Add(string caption, MenuItem[] items) => throw new PlatformNotSupportedException();

        public virtual int Add(MenuItem item)  => throw new PlatformNotSupportedException();

        public virtual int Add(int index, MenuItem item) => throw new PlatformNotSupportedException();

        public virtual void AddRange(MenuItem[] items) => throw new PlatformNotSupportedException();

        int IList.Add(object value) => throw new PlatformNotSupportedException();

        public bool Contains(MenuItem value) => throw new PlatformNotSupportedException();

        bool IList.Contains(object value) => throw new PlatformNotSupportedException();

        public virtual bool ContainsKey(string key) => throw new PlatformNotSupportedException();

        public virtual void Clear() => throw new PlatformNotSupportedException();

        public void CopyTo(Array dest, int index) => throw new PlatformNotSupportedException();

        public MenuItem[] Find(string key, bool searchAllChildren) => throw new PlatformNotSupportedException();

        public int IndexOf(MenuItem value) => throw new PlatformNotSupportedException();

        public virtual int IndexOfKey(string key) => throw new PlatformNotSupportedException();

        int IList.IndexOf(object value) => throw new PlatformNotSupportedException();

        void IList.Insert(int index, object value) => throw new PlatformNotSupportedException();

        public IEnumerator GetEnumerator() => throw new PlatformNotSupportedException();

        public virtual void RemoveAt(int index) => throw new PlatformNotSupportedException();

        public virtual void RemoveByKey(string key) => throw new PlatformNotSupportedException();

        public virtual void Remove(MenuItem item) => throw new PlatformNotSupportedException();

        void IList.Remove(object value) => throw new PlatformNotSupportedException();
    }
}