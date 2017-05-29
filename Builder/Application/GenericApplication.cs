using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public partial class GenericApplication : IGenericApplication
    {
        /// <summary>
        /// Create Application
        /// </summary>
        /// <param name="Icon">Window's Icon</param>
        public GenericApplication(string Icon)
        {
            Application.AppIcon = Icon;
        }

        /// <summary>
        /// If Application destory itself,this will be false.
        /// </summary>
        public bool IsVailed => Application.IsVailed;

        /// <summary>
        /// Add Window to "addlist"
        /// </summary>
        /// <param name="window">A Window</param>
        public void Add(GenericWindow window)
        {
            Application.Add(window);
        }

        /// <summary>
        /// Destory itself
        /// </summary>
        public void Destory()
        {
            Application.Destory();
        }

        /// <summary>
        /// Remove a window from Application
        /// </summary>
        /// <param name="window"></param>
        public void Remove(GenericWindow window)
        {
            Application.Remove(window);
        }

        /// <summary>
        /// MainLoop
        /// </summary>
        /// <param name="UpdateCount">Update Per Time</param>
        /// <param name="SleepTime">Update Sleep Time (milliseconds)</param>
        public void RunLoop(int UpdateCount = 0, int SleepTime = 0)
        {
            Application.UpdateCount = UpdateCount;
            Application.SleepTime = SleepTime;
            Application.RunLoop();
        }
    }
}
