using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.ISP.Problem
{
    internal class AviVideoPlayer : IMediaPlayer
    {
        public void PlayAudio()
        {
            throw new NotImplementedException();
        }

        public void StopAudio()
        {
            throw new NotImplementedException();
        }

        public void AdjustAudioVolume()
        {
            throw new NotImplementedException();

        }

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
