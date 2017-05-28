using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IGenericWindow
    {
        event UpdateHandler Update;
        event MouseMoveHandler MouseMove;
        event MouseClickHandler MouseClick;
        event MouseWheelHandler MouseWheel;
        event KeyEventHandler KeyEvent;
        event DestroyedHandler Destroyed;

        void OnUpdate(object sender);
        void OnMouseMove(object sender, MouseMoveEventArgs e);
        void OnMouseClick(object sender, MouseClickEventArgs e);
        void OnMouseWheel(object sender, MouseWheelEventArgs e);
        void OnKeyEvent(object sender, KeyEventArgs e);
        void OnDestroyed(object sender);

        void Show();
        void Hide();
        void Maximize();
        void Minimize();

        void SetFocus();
        void SetCapture();
        void SetOpacity(float Opacity);
        void SetTitle(string Title);
        void Enable(bool enable);

        void MoveTo(int x, int y);
        void Destory();
        
        bool IsVisible { get; set; }
        bool IsMinimized { get; }
        bool IsMaximized { get; }
        bool IsFocus { get; }
        bool IsEnable { get; set; }
        bool IsVailed { get; }

        float Opacity { get; set; }
        string Title { get; set; }

        int PositionX { get; set; }
        int PositionY { get; set; }
        int Width { get; }
        int Height { get; }

        IntPtr Handle { get; }
    }
}
