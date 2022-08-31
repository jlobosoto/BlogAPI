using BlogAPI.Constants;

namespace BlogAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime CreatedOn { get; set; }=default!;
        public PostStatus Status { get; set; } = default;
        public IEnumerable<Comment> Comments { get; set; } = null!;
    }
}
