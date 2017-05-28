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

        void OnUpdate(object sender);
        void OnMouseMove(object sender, MouseMoveEventArgs e);
        void OnMouseClick(object sender, MouseClickEventArgs e);
        void OnMouseWheel(object sender, MouseWheelEventArgs e);
        void OnKeyEvent(object sender, KeyEventArgs e);

        void Show();
        void Hide();
        void Maximize();
        void Minimize();

        void SetFocus();
        void SetCapture();
        void SetOpacity(float opacity);
        void SetTitle(string Title);
        void Enable(bool enable);

        void MoveTo(int x, int y);
        void Destory();

        bool IsVisible { get; set; }
        bool IsMinimized { get; set; }
        bool IsMaximized { get; set; }
        bool IsFocus { get; set; }
        bool IsEnable { get; set; }

        float Opacity { get; set; }
        string Title { get; set; }

        float PositionX { get; set; }
        float PositionY { get; set; }

        IntPtr Handle { get; }
    }
}
