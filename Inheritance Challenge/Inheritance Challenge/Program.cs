using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program

    { 
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes.", true, "Patrick Gens");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check this out!", "Patrick Gens", 
                "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwiP7veE05bfAhVjtIMKHat8BYcQjRx6BAgBEAU&url=https%3A%2F%2Fwww.foxsportsasia.com%2Fesports%2Foverwatch%2F992851%2Fthe-game-awards-2018-overwatch-wins-best-esports-game%2F&psig=AOvVaw25CO-7vy6uc-PrivlUSj9Q&ust=1544578923951740", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("This clip is AWESOME!", "Patrick Gens",
                 "https://www.youtube.com/watch?v=dushZybUYnM", 22, true);
            Console.WriteLine(videoPost1.ToString());



            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();



        }


       
    }
}
