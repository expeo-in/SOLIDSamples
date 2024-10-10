using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.ISP.Solution
{
    internal interface IVideoPlayer
    {
        void PlayVideo();
        void StopVideo();
        void AdjustVideoBrightness();
    }
}
