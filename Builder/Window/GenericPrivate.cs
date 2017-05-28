using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public partial class GenericWindow
    {
        private APILibrary.Win32.Internal.WndProc processEvent;

        private bool isVisible = false;
        private bool isMinimized = false;
        private bool isMaximized = false;
        private bool isFocus = false;
        private bool isEnable = true;

        private float opacity = 1;
        private string tag = null;
        private string icon = null;

        private int width = 0;
        private int height = 0;
        private int positionx = 0;
        private int positiony = 0;

        private APILibrary.Win32.AppInfo appinfo;
        private IntPtr handle = IntPtr.Zero;


        internal void PrivateOnUpdate(object sender)
        {
            OnUpdate(sender);

            Update?.Invoke(sender);
        }

        internal void PrivateMouseMove(object sender, MouseMoveEventArgs e)
        {
            OnMouseMove(sender, e);

            MouseMove?.Invoke(sender, e);
        }

        internal void PrivateMouseClick(object sender, MouseClickEventArgs e)
        {
            OnMouseClick(sender, e);

            MouseClick?.Invoke(sender, e);
        }

        internal void PrivateMouseWheel(object sender, MouseWheelEventArgs e)
        {
            OnMouseWheel(sender, e);

            MouseWheel?.Invoke(sender, e);
        }

        internal void PrivateKeyEvent(object sender, KeyEventArgs e)
        {
            OnKeyEvent(sender, e);

            KeyEvent?.Invoke(sender, e);
        }

    }
}
