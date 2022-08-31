using BlogAPI.Constants;

namespace BlogAPI.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Content { get; set; }=null!;
        public DateTime CreatedOn { get; set; }=default!;
        public CommentType CommentedBy { get; set; }=default!;

    }
}
