using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public partial class GenericApplication
    {
        static GenericApplication()
        {
            appinfo = new APILibrary.Win32.AppInfo()
            {
                style = (uint)appstyle,
                cbClsExtra = 0,
                cbWndExtra = 0,
                hInstance = APILibrary.Win32.Internal.GetModuleHandle(null),
                hbrBackground = APILibrary.Win32.Internal.GetStockObject(0),
                hCursor = IntPtr.Zero,
                lpszMenuName = null
            };
        }

        private static APILibrary.Win32.AppInfoStyle appstyle = APILibrary.Win32.AppInfoStyle.CS_DBLCLKS;

        private static string AppIcon = null;
        private static APILibrary.Win32.AppInfo appinfo;

        internal static APILibrary.Win32.AppInfo AppInfo
        {
            get
            {
                if (appinfo.hInstance == IntPtr.Zero)
                    throw new Exception("Must Create Application before Create Window");
                return appinfo;
            }
        }
    }
}
