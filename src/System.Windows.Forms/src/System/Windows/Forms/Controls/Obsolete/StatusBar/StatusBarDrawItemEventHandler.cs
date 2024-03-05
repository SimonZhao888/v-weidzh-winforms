﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;

namespace System.Windows.Forms;

#pragma warning disable RS0016
[Obsolete("StatusBarDrawItemEventHandler has been deprecated. Use DrawItemEventHandler instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
public delegate void StatusBarDrawItemEventHandler(object sender, StatusBarDrawItemEventArgs sbdevent);
