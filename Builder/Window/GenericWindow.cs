using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public partial class GenericWindow : IGenericWindow
    {
        public bool IsVisible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsMinimized { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsMaximized { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsFocus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEnable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Opacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float PositionX { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float PositionY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event UpdateHandler Update;
        public event MouseMoveHandler MouseMove;
        public event MouseClickHandler MouseClick;
        public event MouseWheelHandler MouseWheel;
        public event KeyEventHandler KeyEvent;

        public GenericWindow(string Tag,int Width,int Height)
        {
            processEvent += APILibrary.Win32.Internal.DefWindowProc;
        }

        public void Destory()
        {
            throw new NotImplementedException();
        }

        public void Enable(bool enable)
        {
            throw new NotImplementedException();
        }

        public void Hide()
        {
            throw new NotImplementedException();
        }

        public void Maximize()
        {
            throw new NotImplementedException();
        }

        public void Minimize()
        {
            throw new NotImplementedException();
        }

        public void MoveTo(int x, int y)
        {
            throw new NotImplementedException();
        }

        public virtual void OnKeyEvent(object sender, KeyEventArgs e)
        {

        }

        public virtual void OnMouseClick(object sender, MouseClickEventArgs e)
        {
           
        }

        public virtual void OnMouseMove(object sender, MouseMoveEventArgs e)
        {
           
        }

        public virtual void OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
           
        }

        public virtual void OnUpdate(object sender)
        {
            
        }

        public void SetFocus()
        {
            throw new NotImplementedException();
        }

        public void SetOpacity(float opacity)
        {
            throw new NotImplementedException();
        }

        public void SetTitle(string Title)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
