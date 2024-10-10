using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.ISP.Solution
{
    internal class AviVideoPlayer: IVideoPlayer
    {
        public void PlayVideo()
        {
            Console.WriteLine("Play video");
        }

        public void StopVideo()
        {
            Console.WriteLine("Stop video");
        }

        public void AdjustVideoBrightness()
        {
            Console.WriteLine("Adjust video brightness");
        }
    }
}
