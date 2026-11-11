namespace ConsoleApp1
{
	internal class OrderItem : IEntity
	{
		public int Id { get; set; }
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }

		public OrderItem(int orderId, int productId, int quantity, decimal unitPrice)
		{
			OrderId = orderId;
			ProductId = productId;
			Quantity = quantity;
			UnitPrice = unitPrice;
		}

		public override string ToString()
		{
			return $"Id: {Id}, OrderId: {OrderId}, ProductId: {ProductId}, Quantity: {Quantity}, UnitPrice: {UnitPrice}";
		}
	}
}