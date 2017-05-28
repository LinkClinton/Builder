﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public partial class GenericWindow
    {
        private static APILibrary.Win32.WindowExStyles exstyle = APILibrary.Win32.WindowExStyles.WS_EX_LAYERED;
        private static APILibrary.Win32.AppInfoStyle appstyle = APILibrary.Win32.AppInfoStyle.CS_HREDRAW | APILibrary.Win32.AppInfoStyle.CS_VREDRAW;
        private static APILibrary.Win32.WindowStyles windowstyle = APILibrary.Win32.WindowStyles.WS_OVERLAPPEDWINDOW ^ APILibrary.Win32.WindowStyles.WS_SIZEBOX; 
    }
}
