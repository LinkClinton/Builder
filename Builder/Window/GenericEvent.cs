using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public enum MouseButton
    {
        Null,
        LeftButton = 1,
        MiddleButton = 2,
        RightButton = 3
    }

    public class MouseMoveEventArgs : EventArgs
    {
        internal int x = 0;
        internal int y = 0;

        public int X => x;
        public int Y => y;
    }

    public class MouseClickEventArgs : MouseMoveEventArgs
    {
        internal bool isdown = false;
        internal MouseButton which = MouseButton.Null;

        public bool IsDown { get => isdown; }
        public MouseButton Which { get => which; }
    }

    public class MouseWheelEventArgs : MouseMoveEventArgs
    {
        internal int offset = 0;

        public int Offsett => offset;
    }

    public class KeyEventArgs : EventArgs
    {
        internal bool isdown = false;
        internal KeyCode keycode = 0;

        public bool IsDown { get => isdown; }
        public KeyCode KeyCode { get => keycode; }
    }

    public delegate void UpdateHandler(object sender);
    public delegate void MouseMoveHandler(object sender, MouseMoveEventArgs e);
    public delegate void MouseClickHandler(object sender, MouseClickEventArgs e);
    public delegate void MouseWheelHandler(object sender, MouseWheelEventArgs e);
    public delegate void KeyEventHandler(object sender, KeyEventArgs e);

    public struct WindowDefinition
    {
        public int Width;
        public int Height;
        public string Title;
        public string Icon;

        public static explicit operator (string Title, string Icon, int Width, int Height) (WindowDefinition definition)
            => (definition.Title, definition.Icon, definition.Width, definition.Height); 
    }


}
