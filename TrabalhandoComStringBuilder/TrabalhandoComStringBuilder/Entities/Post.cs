
namespace TrabalhandoComStringBuilder.Enitities
{
       class Post
    {
        public string Title { get; set; }
        public DateTime Moment { get; set; }
        public string Content { get; set; } 
        public int Likes { get; set; }

        public Post(string title, DateTime moment, string content, int likes)
        {
            Title = title;
            Moment = moment;
            Content = content;
            Likes = likes;
        }
        override
        public string ToString()
        {
            return " -------- Post --------- " +
                "\n Title " + Title +
                "\n Moment: " + Moment +
                "\n Content: " + Content +
                "\n Likes: " + Likes;
        }
    }
}
