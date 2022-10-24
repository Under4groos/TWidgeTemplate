using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WallpaperEngineLib.Attribute;

namespace TWidgeTemplate
{
    public class WidgetMian
    {
        [WidgetAttribute("Window")]
        public class wwWidget
        {

            [WidgetAttribute("Create")]
            public UserControl Create()
            {
                return new Controls.MainWidget();
            }


            // Настройки
            [WidgetAttribute("Setting")]
            public Dictionary<string, bool> StartSetting()
            {
                return new Dictionary<string, bool>()
                {
                    { "DragStatus" , true },
                    { "Transparent" , false },

                };
            }


        }
    }
}
