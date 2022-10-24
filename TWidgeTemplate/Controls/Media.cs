using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TWidgeTemplate.Control
{
    public class Media : MediaElement
    {
        public Media()
        {
            this.LoadedBehavior = MediaState.Manual;
            this.Volume = 0;
            this.ScrubbingEnabled = true;
            this.MediaEnded += (o, e) =>
            {
                this.Stop();
                this.Position = TimeSpan.Zero;
                this.Play();
               
            };
            this.Loaded += (o, e) =>
            {
                this.Play();
            };
        }
    }
}
