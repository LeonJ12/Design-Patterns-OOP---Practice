using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_JL
{
    internal interface ITheme
    {
       void  SetBackgroundColor();
        void SetFontColor();
        string GetHeader(int width);
        string GetFooter(int width);

    }
}
