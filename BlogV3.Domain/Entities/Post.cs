using BlogV3.Domain.Primitives;

namespace BlogV3.Domain.Entities
{
    public sealed class Post : BaseEntity
    {
        public Post(string title,
                    string summary,
                    string body,
                    string slug) : base()
        {
            Title = title;
            Summary = summary;
            Body = body;
            Slug = slug;

            Tags = new List<Tag>();
        }

        public string Title { get; private set; }
        public string Summary { get; private set; }
        public string Body { get; private set; }
        public string Slug { get; private set; }
        public Category Category { get; private set; }
        public User Author { get; private set; }

        public List<Tag> Tags { get; set; }
    }
}