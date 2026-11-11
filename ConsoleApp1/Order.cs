namespace ConsoleApp1
{
	internal class Order : IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public decimal TotalAmount { get; set; }
		public DateTime CreatedAt { get; set; }

		public Order(int userId, decimal totalAmount, DateTime createdAt)
		{
			UserId = userId;
			TotalAmount = totalAmount;
			CreatedAt = createdAt;
		}

		public override string ToString()
		{
			return $"Id: {Id}, UserId: {UserId}, TotalAmount: {TotalAmount}, CreatedAt: {CreatedAt:dd.MM.yyyy HH:mm}";
		}
	}
}