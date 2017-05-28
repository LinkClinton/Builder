using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public partial class GenericApplication
    {
        private List<GenericWindow> Windows = new List<GenericWindow>();

        private List<GenericWindow> AddList = new List<GenericWindow>();
        private List<GenericWindow> RemoveList = new List<GenericWindow>();

        private bool isVailed = true;

        private void PumpMessage()
        {
            while (APILibrary.Win32.Internal.PeekMessage(out APILibrary.Win32.Message message, IntPtr.Zero, 0, 0,
                (int)APILibrary.Win32.PeekMessageFlags.PM_REMOVE) is true)
            {
                APILibrary.Win32.Internal.TranslateMessage(ref message);
                APILibrary.Win32.Internal.DispatchMessage(ref message);
            }
        }


    }
}
