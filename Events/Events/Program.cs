using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class MusicPlayer 
    {
        public delegate void MusicEventHandler(string status); //define delegate 

        public event MusicEventHandler Musicevent; //define event based on delegate

        private bool isPlaying = false;

        public void TogglePlaypause()
        {
            isPlaying = !isPlaying;
            string status = isPlaying ? "Playing" : "Paused";

            Console.WriteLine($"music : {status}");

            Musicevent?.Invoke(status);  //invoiking event
        }
    }
    class UserInterface //methos to handel the event
    {
        public void DisplayStatus(string message)
        {
            Console.WriteLine($"UI:Music is playing now {message} ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicPlayer player = new MusicPlayer();
            UserInterface ui = new UserInterface();

            player.Musicevent += ui.DisplayStatus;

            player.TogglePlaypause();
            player.TogglePlaypause();

            Console.ReadLine();


        }
    }
}
