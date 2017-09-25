using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostProgram
{
    class BlogPost
    {
        public string AuthorName;
        public string Title;
        public string Text;
        public DateTime PublicationDate;

        public BlogPost(string authorName, string title, string text, DateTime publicationDate)
        {
            AuthorName = authorName;
            Title = title;
            Text = text;
            PublicationDate = publicationDate;
        }
    }


}
