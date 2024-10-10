using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.ISP.Problem
{
    internal interface IMediaPlayer
    {
        void PlayAudio();
        void StopAudio();
        void AdjustAudioVolume();

        void PlayVideo();
        void StopVideo();
        void AdjustVideoBrightness();
    }
}
