namespace ConsoleApp1
{
	internal class Product : IEntity
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public string Name { get; set; }
		public decimal CurrentPrice { get; set; }
		public int Stock { get; set; }

		public Product(int categoryId, string name, decimal currentPrice, int stockQuantity)
		{
			CategoryId = categoryId;
			Name = name;
			CurrentPrice = currentPrice;
			Stock = stockQuantity;
		}

		public override string ToString()
		{
			return $"Id: {Id}, CategoryId: {CategoryId}, Name: {Name}, Price: {CurrentPrice}, Stock: {Stock}";
		}
	}
}