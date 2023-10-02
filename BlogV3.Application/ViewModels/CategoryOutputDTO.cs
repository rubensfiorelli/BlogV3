using BlogV3.Domain.Entities;

namespace BlogV3.Application.ViewModels
{
    public class CategoryOutputDTO
    {
        public CategoryOutputDTO(Guid id, string name, string slug)
        {
            Id = id;
            Name = name;
            Slug = slug;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Slug { get; private set; }


        public static implicit operator CategoryOutputDTO(Category entity)
        {
            return new CategoryOutputDTO(entity.Id, entity.Name, entity.Slug);
            
        }
       

    }
}
