using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.ISP.Solution
{
    internal class MP3Player : IAudioPlayer
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
    }
}
