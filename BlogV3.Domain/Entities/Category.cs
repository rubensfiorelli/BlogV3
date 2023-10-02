using BlogV3.Domain.Primitives;

namespace BlogV3.Domain.Entities
{
    public sealed class Category : BaseEntity
    {
        public Category(string name, string slug) : base()
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