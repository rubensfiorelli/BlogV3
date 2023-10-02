using BlogV3.Domain.Primitives;

namespace BlogV3.Domain.Entities
{
    public class Role : BaseEntity
    {
        public Role(string name, string slug) : base()
        {
            Name = name;
            Slug = slug;

            Users = new List<User>();
        }

        public string Name { get; private set; }
        public string Slug { get; private set; }

        public List<User> Users { get; set; }
    }
}