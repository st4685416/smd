namespace ConsoleApp1
{
	internal class LoyaltyCard : IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public decimal DiscountPercent { get; set; }

		public LoyaltyCard(int userId, decimal discountPercent)
		{
			UserId = userId;
			DiscountPercent = discountPercent;
		}

		public override string ToString()
		{
			return $"Id: {Id}, UserId: {UserId}, Discount: {DiscountPercent}%";
		}
	}
}