﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms;

// Add public types and members to the declared APIto simplify porting of applications from .NET Framework to .NET. These types will not work,
// but if they are not accessed, other features in the application will work.
#pragma warning disable RS0016
#nullable disable
[Obsolete("ContextMenu has been deprecated. Use ContextMenuStrip instead.")]
public class ContextMenu : Menu
{
    internal Control sourceControl;

    /// <summary>
    ///  Creates a new ContextMenu object with no items in it by default.
    /// </summary>
    public ContextMenu()
        : base(null)
    {
        throw new PlatformNotSupportedException();
    }

    /// <summary>
    ///  Creates a ContextMenu object with the given MenuItems.
    /// </summary>
    public ContextMenu(MenuItem[] menuItems)
        : base(menuItems)
    {
        throw new PlatformNotSupportedException();
    }

    /// <summary>
    ///  The last control that was acted upon that resulted in this context
    ///  menu being displayed.
    /// </summary>
    [Browsable(false), EditorBrowsable(EditorBrowsableState.Never),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Control SourceControl
    {
        get
        {
            throw new PlatformNotSupportedException();
        }
    }

    [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
    public event EventHandler Popup
    {
        add => throw new PlatformNotSupportedException();
        remove => throw new PlatformNotSupportedException();
    }

    /// <summary>
    ///  Fires when the context menu collapses.
    /// </summary>
    [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
    public event EventHandler Collapse
    {
        add => throw new PlatformNotSupportedException();
        remove => throw new PlatformNotSupportedException();
    }

    /// <summary>
    ///  This is used for international applications where the language
    ///  is written from RightToLeft. When this property is true,
    ///  text alignment and reading order will be from right to left.
    /// </summary>
    // Add a DefaultValue attribute so that the Reset context menu becomes
    // available in the Property Grid but the default value remains No.
    [Localizable(true), DefaultValue(RightToLeft.No),
    Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
    public virtual RightToLeft RightToLeft
    {
        get
        {
            throw new PlatformNotSupportedException();
        }
        set
        {
            throw new PlatformNotSupportedException();
        }
    }

    /// <summary>
    ///  Displays the context menu at the specified position.  This method
    ///  doesn't return until the menu is dismissed.
    /// </summary>
    public void Show(Control control, Point pos)
    {
        throw new PlatformNotSupportedException();
    }

    /// <summary>
    ///  Displays the context menu at the specified position.  This method
    ///  doesn't return until the menu is dismissed.
    /// </summary>
    public void Show(Control control, Point pos, LeftRightAlignment alignment)
    {
        throw new PlatformNotSupportedException();
    }
}
