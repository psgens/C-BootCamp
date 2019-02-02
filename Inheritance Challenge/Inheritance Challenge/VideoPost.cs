using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace inheritance
{
    class VideoPost:Post
    {
        //member fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        //using System.Threading on Timer.
        Timer timer;



        //Properties
        protected string VideoURL { get; set; }
        protected int Lengthy { get; set; }




        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic)
        {
            // The following properties and the GetNextID method ar inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            // Property VideoURL is a member of ImagePost, but not of Post.
            this.VideoURL = videoURL;
            this.Lengthy = length;

        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }


        }

        private void TimerCallback(Object o)
        {
            if (currentDuration < Lengthy)
            {
                currentDuration++;
                Console.WriteLine("Video at {0}s", currentDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currentDuration);
                currentDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} -{2} Length: {3} - by {4}", this.ID, this.Title, this.VideoURL, this.Lengthy, this.SendByUsername);
        }
    }
}
