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
            appinfo.hIcon = APILibrary.Win32.Internal.LoadImage(IntPtr.Zero, AppIcon = Icon, 1, 0, 0, 0x00000010);

            
        }

        /// <summary>
        /// If Application destory itself,this will be false.
        /// </summary>
        public bool IsVailed => isVailed;

        /// <summary>
        /// Add Window to "addlist"
        /// </summary>
        /// <param name="window">A Window</param>
        public void Add(GenericWindow window)
        {
            AddList.Add(window);
        }

        /// <summary>
        /// Destory itself
        /// </summary>
        public void Destory()
        {
            isVailed = false;
        }

        /// <summary>
        /// Remove a window from Application
        /// </summary>
        /// <param name="window"></param>
        public void Remove(GenericWindow window)
        {
            RemoveList.Add(window);
        }

        /// <summary>
        /// MainLoop
        /// </summary>
        /// <param name="UpdateCount">Update Per Time</param>
        /// <param name="SleepTime">Update Sleep Time (milliseconds)</param>
        public void RunLoop(int UpdateCount = 0, int SleepTime = 0)
        {
            float delta = (UpdateCount != 0) ? 1f / UpdateCount : 0;

            float passtime = delta;
            DateTime last_time = DateTime.Now;

            while (IsVailed is true)
            {
                System.Threading.Thread.Sleep(SleepTime);

                DateTime current_time = DateTime.Now;
                passtime += (float)(current_time - last_time).TotalSeconds;
                last_time = current_time;

                if (passtime < delta) continue;

                passtime -= delta;

                PumpMessage();

                foreach (var item in Windows)
                {
                    if (item.IsEnable is false) continue;
                    if (item.IsVailed is false) Remove(item);

                    item.PrivateOnUpdate(item);
                }

                foreach (var item in RemoveList) Windows.Remove(item);
                foreach (var item in AddList) Windows.Add(item);

                RemoveList.Clear();
                AddList.Clear();
            }
        }
    }
}
