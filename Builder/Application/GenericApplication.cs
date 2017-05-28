using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public partial class GenericApplication : IGenericApplication
    {
        public GenericApplication(string Icon)
        {
            appinfo.hIcon = APILibrary.Win32.Internal.LoadImage(IntPtr.Zero, AppIcon = Icon, 1, 0, 0, 0x00000010);


        }

        public bool IsVailed => isVailed;

        public void Add(GenericWindow window)
        {
            AddList.Add(window);
        }

        public void Destory()
        {
            isVailed = false;
        }

        public void Remove(GenericWindow window)
        {
            RemoveList.Add(window);
        }

        public void RunLoop(float delta)
        {
            float passtime = delta;
            DateTime last_time = DateTime.Now;

            while (IsVailed is true)
            {
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
