using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public interface IProductRepository
{
    // public IEnumerable<Product> GetAll();
    public IEnumerable<Product> GetAll(GetAllOptions getAllOptions);
    public Product CreateOne(Product product);
    public bool UpdateOne(Product updateObject);
    public bool DeleteOne(Product product);
    public Product FindOne(string name);
    // public IEnumerable<Product> FindAll(string searchBy);

}
