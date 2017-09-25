using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostItProgram
{
    public struct PostIt
    {
        public string Text;
        public string BackgroundColor;
        public string TextColor;

        public PostIt(string text, string backgroundColor, string textColor)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            BackgroundColor = backgroundColor ?? throw new ArgumentNullException(nameof(backgroundColor));
            TextColor = textColor ?? throw new ArgumentNullException(nameof(textColor));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PostIt[] postIts = new PostIt[3];
            //List<PostIt> postItsList = new List<PostIt>;

            postIts[0] = new PostIt("Idea 1", "orange", "blue");
            postIts[1] = new PostIt("Awesome", "pink", "black");
            postIts[2] = new PostIt("Superb!", "yellow", "green");
        }
    }
}
