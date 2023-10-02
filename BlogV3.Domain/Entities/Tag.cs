using BlogV3.Domain.Primitives;

namespace BlogV3.Domain.Entities
{
    public class Tag : BaseEntity
    {
        public Tag(string name, string slug) : base()
        {
            Name = name;
            Slug = slug;

            Posts = new List<Post>();
        }

        public string Name { get; private set; }
        public string Slug { get; private set; }

        public List<Post> Posts { get; set; }
    }
}