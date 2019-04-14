using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BcInstaller.Extensions
{
    public static class ControlExtensions
    {
        public static void InvokeSafe<TControl>(this TControl control, Action<TControl> cb) where TControl : Control
        {
            if (cb == null) return;

            if (control.InvokeRequired) control.Invoke(cb, control);
            else cb?.Invoke(control);
        }

        public static void DisableWhile<TControl>(this TControl control, Action cb) where TControl : Control
        {
            control.InvokeSafe(c => { c.Enabled = false; });
            cb?.Invoke();
            control.InvokeSafe(c => { c.Enabled = true; });
        }
    }
}
