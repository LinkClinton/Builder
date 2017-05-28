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

        private float opacity;
        private float tag;
        private float positionx;
        private float positiony;
    }
}
