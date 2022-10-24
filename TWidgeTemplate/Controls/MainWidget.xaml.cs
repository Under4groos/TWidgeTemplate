using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WallpaperEngineLib.Model;

namespace TWidgeTemplate.Controls
{
    /// <summary>
    /// Логика взаимодействия для MainWidget.xaml
    /// </summary>
    public partial class MainWidget : UserControl
    {
        public MainWidget()
        {
            InitializeComponent();
            this.Loaded += (o, e) =>
            {
                DispatcherTimer timer = new DispatcherTimer();
                timer.Tick += (ao,ae) => Tick();
                timer.Interval = new TimeSpan(0, 0, 1);
                timer.Start();
                 
            };
        }
        void Tick()
        {
            _label.Content = DateTime.Now.ToString(@"HH:mm:ss");
        }
    }
}
