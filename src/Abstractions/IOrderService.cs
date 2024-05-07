
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;


public interface IOrderService
{
    public IEnumerable<Order> GetAll();
    public IEnumerable<Order> CreateOne(Order order);

    public IEnumerable<Order> DeleteOne(Guid id);

    public IEnumerable<Order> FindOne(Guid id);

      public Order Checkout(List<OrderItemCreateDto> orderItemCreateDtos);
}



