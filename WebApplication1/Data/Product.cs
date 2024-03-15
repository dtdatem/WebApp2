namespace WebApplication1.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public int Gia { get; set; }
        public string Hinh { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<OrderProduct>? OrderProducts { get; set; }
    }
}
