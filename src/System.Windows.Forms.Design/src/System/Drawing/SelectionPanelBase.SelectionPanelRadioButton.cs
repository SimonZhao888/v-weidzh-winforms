// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Windows.Forms;

namespace System.Drawing.Design;

internal abstract partial class SelectionPanelBase
{
    protected class SelectionPanelRadioButton : RadioButton
    {
        private const int WM_PAINT = 0x000F;

        public SelectionPanelRadioButton()
        {
            AutoCheck = false;
        }

        protected override bool ShowFocusCues => true;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg != WM_PAINT || !Focused || !ShowFocusCues)
            {
                return;
            }

            Rectangle focusBounds = ClientRectangle;
            focusBounds.Inflate(-3, -3);
            if (focusBounds.Width <= 0 || focusBounds.Height <= 0)
            {
                return;
            }

            using Graphics g = CreateGraphics();
            ControlPaint.DrawFocusRectangle(g, focusBounds, ForeColor, BackColor);
        }

        protected override bool IsInputKey(Keys keyData) => keyData switch
        {
            Keys.Left or Keys.Right or Keys.Up or Keys.Down or Keys.Return => true,
            _ => base.IsInputKey(keyData),
        };
    }
}
