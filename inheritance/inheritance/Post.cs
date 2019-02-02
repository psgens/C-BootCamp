using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Post
    {
        private static int currentPostId;

        // properties
        protected int ID { get; set; }
        public string Title { get; set; }
        public string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // Default constructor. If a derived class does not invoke a base-
        // class constructor explicitly, the default consructor is called
        // implicity

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Patrick Gens";

        }

        // Instance constuctor that has three parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // Virtual method override of the ToString method that is inherited
        // from System.Object.

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
