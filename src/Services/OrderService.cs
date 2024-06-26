using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

public class OrderService : IOrderService
{

    private IOrderRepository _orderRepository;
    private IOrderItemRepository _orderItemRepository;

    private IMapper _mapper;

    public OrderService(IOrderRepository orderRepository, IOrderItemRepository orderItemRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _orderItemRepository = orderItemRepository;
        _mapper = mapper;
    }
    public List<OrderReadDto> GetAll()

    {
        var orders = _orderRepository.GetAll();
        var orderRead = orders.Select(_mapper.Map<OrderReadDto>);
        return orderRead.ToList();


    }

    public Order CreateOne(OrderCreatDto orderCreatDto)
    {


        var order = _mapper.Map<Order>(orderCreatDto);

        return _orderRepository.CreateOne(order);

    }

    // public IEnumerable<Order> DeleteOne(Guid id)
    // {
    //     return _orderRepository.DeleteOne(id);
    // }

    public OrderReadDto FindOne(Guid id)
    {

        var order = _orderRepository.FindOne(id);
        var orderRead = _mapper.Map<OrderReadDto>(order);
        return orderRead;
    }

    public Order Checkout(List<OrderItemCreateDto> orderItemCreateDtos, string userId)
    {
        // create an order 

        var order = new Order
        {
            UserId = new Guid(userId)
        };
        // save order in order table 
        _orderRepository.CreateOne(order); 
        // for loop in the list of order item create Dto
        Console.WriteLine($"ORDER ID: {order.Id}");
        Console.WriteLine($"USER ID: {userId}");

    

        // for loop in the list of order item create Dto 
        foreach (var item in orderItemCreateDtos)

        {
            var orderItem = new OrderItem
            {
                OrderId = order.Id,
                ProductId = item.ProductId,
                Price = item.Price,
                Quantity = item.Quantity
            };
            _orderItemRepository.CreteOne(orderItem);
        }

                Console.WriteLine($"AFTER LOOP");

      
       
        return order; 


    }
    //Add Check for Prodect and the quantity.
}