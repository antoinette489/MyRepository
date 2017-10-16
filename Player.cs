using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
namespace Dictofon
{
    class Player
    {
        public SoundPlayer simpleSound { get; set; }
        public string currdirText { get; set; }
        public string PlayingTime { get; set; }
        public Player()
        {
            simpleSound = new SoundPlayer();
            PlayingTime = "";
            currdirText = Directory.GetCurrentDirectory() + "\\Text\\";
        }
        public void LoadFile(string path)
        {
            simpleSound.SoundLocation = path;
            simpleSound.LoadAsync();
        }
        public void Play()
        {
            if (simpleSound.IsLoadCompleted)
            {
                simpleSound.Play();                
            }
        }
        public void Stop()
        {
            simpleSound.Stop();
        }
    }
}

    

