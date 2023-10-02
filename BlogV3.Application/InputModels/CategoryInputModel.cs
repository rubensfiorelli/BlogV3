using BlogV3.Domain.Entities;

namespace BlogV3.Application.InputModels
{
    public class CategoryInputModel
    {
        public string Name { get; set; }
        public string Slug { get; set; }

        public Category ToEntity()
            => new Category(Name, Slug);

    }
}
