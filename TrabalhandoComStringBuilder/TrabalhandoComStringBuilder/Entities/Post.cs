
using ExempleCommnets;
using System.Text;

namespace Posts;

class Post
{
    public string Title { get; set; }
    public DateTime Moment { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }
    public List<Comments> comments { get; set; } = new List<Comments>();

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
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("\n Title: " +Title);
        sb.Append(" Likes - ");
        sb.Append( Likes);
        sb.AppendLine("\n Date: " +Moment.ToString("dd/MM/yyyy"));
        sb.AppendLine(" Content: " + Content);
        sb.AppendLine("\n Comments: ");
        foreach (Comments cm in comments)
        {
            sb.AppendLine(" " + cm.Text+  " Moment coments: " + DateTime.Now );
        }
        return sb.ToString();
            

    }
    public void AddComent(Comments comment)
    {
        comments.Add(comment);
    }
    public void RemoveComment(Comments comment)
    {
        comments.Remove(comment);
    }
}

