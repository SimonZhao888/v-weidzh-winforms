﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;

namespace System.Windows.Forms;

[Obsolete(
    Obsoletions.ToolBarMessage,
    error: false,
    DiagnosticId = Obsoletions.ToolBarDiagnosticId,
    UrlFormat = Obsoletions.SharedUrlFormat)]
[EditorBrowsable(EditorBrowsableState.Never)]
public class ToolBarButtonClickEventArgs : EventArgs
{
    public ToolBarButtonClickEventArgs(ToolBarButton button)
    {
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ToolBarButton Button
    {
        get => throw new PlatformNotSupportedException();
        set => throw new PlatformNotSupportedException();
    }
}
