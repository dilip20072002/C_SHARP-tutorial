using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class O_Static
    {
        public string song;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public O_Static(string aSong, string newArtist, int aDuration)
        {
            song = aSong;
            artist = newArtist;
            duration = aDuration;
            songCount++;
        }


    }
}