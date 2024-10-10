using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.ISP.Solution
{
    internal interface IAudioPlayer
    {
        void PlayAudio();
        void StopAudio();
        void AdjustAudioVolume();
    }
}
