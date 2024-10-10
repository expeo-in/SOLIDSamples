using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.ISP.Problem
{
    internal class MP3Player : IMediaPlayer
    {
        public void PlayAudio()
        {
            Console.WriteLine("play audio");
        }

        public void StopAudio()
        {
            Console.WriteLine("Stop audio");
        }

        public void AdjustAudioVolume()
        {
            Console.WriteLine("Adjust audio volume");
        }

        public void PlayVideo()
        {
            throw new NotImplementedException();
        }

        public void StopVideo()
        {
            throw new NotImplementedException();
        }

        public void AdjustVideoBrightness()
        {
            throw new NotImplementedException();
        }
    }
}
