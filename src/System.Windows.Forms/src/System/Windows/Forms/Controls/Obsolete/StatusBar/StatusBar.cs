﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;

namespace System.Windows.Forms;

#nullable disable

[Obsolete(
    Obsoletions.StatusBarMessage,
    error: false,
    DiagnosticId = Obsoletions.StatusBarDiagnosticId,
    UrlFormat = Obsoletions.SharedUrlFormat)]
[EditorBrowsable(EditorBrowsableState.Never)]
[Browsable(false)]
public partial class StatusBar : Control
{
    public StatusBar() => throw new PlatformNotSupportedException();

    public new event EventHandler BackColorChanged
    {
        add => throw new PlatformNotSupportedException();
        remove => throw new PlatformNotSupportedException();
    }

    public new event EventHandler BackgroundImageChanged
    {
        add => throw new PlatformNotSupportedException();
        remove => throw new PlatformNotSupportedException();
    }

    public new event EventHandler BackgroundImageLayoutChanged
    {
        add => throw new PlatformNotSupportedException();
        remove => throw new PlatformNotSupportedException();
    }

    public new event EventHandler ForeColorChanged
    {
        add => throw new PlatformNotSupportedException();
        remove => throw new PlatformNotSupportedException();
    }

    public new ImeMode ImeMode
    {
        get => throw new PlatformNotSupportedException();
        set => throw new PlatformNotSupportedException();
    }

    public new event EventHandler ImeModeChanged
    {
        add => throw new PlatformNotSupportedException();
        remove => throw new PlatformNotSupportedException();
    }

    public StatusBarPanelCollection Panels => throw new PlatformNotSupportedException();

    public bool ShowPanels
    {
        get => throw new PlatformNotSupportedException();
        set => throw new PlatformNotSupportedException();
    }

    public bool SizingGrip
    {
        get => throw new PlatformNotSupportedException();
        set => throw new PlatformNotSupportedException();
    }

    public new bool TabStop
    {
        get => throw new PlatformNotSupportedException();
        set => throw new PlatformNotSupportedException();
    }

    public event StatusBarDrawItemEventHandler DrawItem
    {
        add => throw new PlatformNotSupportedException();
        remove => throw new PlatformNotSupportedException();
    }

    public event StatusBarPanelClickEventHandler PanelClick
    {
        add => throw new PlatformNotSupportedException();
        remove => throw new PlatformNotSupportedException();
    }

    public new event PaintEventHandler Paint
    {
        add => throw new PlatformNotSupportedException();
        remove => throw new PlatformNotSupportedException();
    }

    protected virtual void OnPanelClick(StatusBarPanelClickEventArgs e) => throw new PlatformNotSupportedException();

    protected virtual void OnDrawItem(StatusBarDrawItemEventArgs subevent) => throw new PlatformNotSupportedException();
}
