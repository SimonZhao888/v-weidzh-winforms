﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Windows.Forms;

#pragma warning disable RS0016 // Add public types and members to the declared API to simplify porting of applications from .NET Framework to .NET.
// These types will not work, but if they are not accessed, other features in the application will work.
[Obsolete(
    Obsoletions.StatusBarPanelBorderStyleMessage,
    error: false,
    DiagnosticId = Obsoletions.StatusBarPanelBorderStyleDiagnosticId,
    UrlFormat = Obsoletions.SharedUrlFormat)]
public enum StatusBarPanelBorderStyle
{
    None = 1,
    Raised = 2,
    Sunken = 3,
}