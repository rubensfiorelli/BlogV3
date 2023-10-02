using BlogV3.Domain.Primitives;

namespace BlogV3.Domain.Entities
{
    public class User : BaseEntity
    {
        public User(string name,
                    string email,
                    string passwordHash,
                    string image,
                    string slug,
                    string bio) : base()
        {
            Name = name;
            Email = email;
            PasswordHash = passwordHash;
            Image = image;
            Slug = slug;
            Bio = bio;

            Posts = new List<Post>();
            Roles = new List<Role>();
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public string Image { get; private set; }
        public string Slug { get; private set; }
        public string Bio { get; private set; }

        public List<Post> Posts { get; set; }
        public List<Role> Roles { get; set; }
    }
}