using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class VideoPost:Post
    {
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

        public override string ToString()
        {
            return String.Format("{0} - {1} -{2} Length: {3} - by {4}", this.ID, this.Title, this.VideoURL, this.Lengthy, this.SendByUsername);
        }
    }
}
