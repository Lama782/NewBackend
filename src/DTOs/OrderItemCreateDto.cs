namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs;
public class OrderItemCreateDto
{
    public double Price { get; set; }
    public int Quantity { get; set; }
    public Guid ProductId { get; set; }
}
