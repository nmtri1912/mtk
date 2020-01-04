using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationFramework.TypeShow
{
    public class Popup : ShowBehavior
    {
        public Popup()
        {

        }
        public void show(string str)
        {
            NotifyWindows nb = new NotifyWindows(str);
            nb.ShowDialog();
        }
    }
}
