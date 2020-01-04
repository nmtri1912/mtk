using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ValidationFramework.TypeShow
{
    public class MessBox : ShowBehavior
    {
        public MessBox()
        {

        }

        public void show(string str)
        {
            MessageBox.Show(str, "Thông báo lỗi");
        }
    }
}
